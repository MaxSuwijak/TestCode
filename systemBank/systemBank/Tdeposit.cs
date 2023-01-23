using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemBank
{
    public partial class Tdeposit : Form
    {
        public Tdeposit()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["TestDb"].ConnectionString;

        SqlConnection conn;
        private void initDb()
        {

            if (conn == null)
            {
                conn = new SqlConnection(connectionString);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

        }
        private void Tdeposit_Load(object sender, EventArgs e)
        {
            initDb();
            setAutocompleteAcc();
        }

        //Set Account look up
        private void setAutocompleteAcc()
        {
            try
            {
                string sql = "select account_id  from tb_customer where account_status = '1'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet("customer");
                da.Fill(ds, "customer");
                DataTable dt = ds.Tables["customer"];
                var arrray = new List<string>();
                if (ds.Tables["customer"].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables["customer"].Rows.Count; i++)
                    {
                        arrray.Add(ds.Tables["customer"].Rows[i]["account_id"].ToString());
                    }
                }

                txtAcc.AutoCompleteList = arrray;
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด " + ex.Message.ToString());

            }
        }


        //Search Account Detail
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtAcc.Text == "")
            {
                MessageBox.Show("Pleace enter account!!!");
                return;
            }
            try
            {
                string sql = "SELECT * FROM tb_customer where account_id ='" + txtAcc.Text + "' and account_status = '1'";
                dataset.customer dsCus = new dataset.customer();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dsCus, "customer");
                DataTable dt = dsCus.Tables["customer"];
                if (dt.Rows.Count > 0)
                {
                    txtAcc.Enabled = false;
                    btnSearch.Enabled = false;
                    btnSave.Enabled = true;
                    //Set Account Detail
                    DataRow dr = dt.Rows[0];
                    lName.Text = dr["name_cus"].ToString();
                    lMidName.Text = dr["mid_name_cus"].ToString();
                    lLastName.Text = dr["last_name_cus"].ToString();
                    double balance = Convert.ToDouble(dr["balance"].ToString());
                    lBalance.Text = balance.ToString("#,###.000");
                    txtDeposit.Enabled = true;
                }

                // Not found Account
                else
                {
                    MessageBox.Show("Not found!!!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด " + ex.Message.ToString());

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDeposit.Text == "")
            {
                MessageBox.Show("please enter money!!!");
                return;
            }
            if(Convert.ToDouble(txtDeposit.Text) < 0)
            {
                MessageBox.Show("please enter money more than zero!!!");
                return;
            }

            try
            {
                double balance = Convert.ToDouble(txtDeposit.Text.ToString());
                string message = string.Format(@"Account : {0} "+"\n"+"Name : {1}"+ 
                    "\n"+ "Middle Name : {2}" +"\n"+ "Last Name : {3}" + "\n" + "Deposit : {4}", txtAcc.Text, lName.Text, lMidName.Text, lLastName.Text,
                    Math.Round((balance - (balance * 0.001)), 3).ToString("#,###.000"));
                DialogResult dialogResult = MessageBox.Show(message, "Confirm create Account", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //insert transaction
                    string sql = "SELECT * FROM tb_transaction where transaction_id = 0";
                    dataset.transaction dsTransaction = new dataset.transaction();
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(dsTransaction, "transaction");
                    DataTable dt = dsTransaction.Tables["transaction"];

                    DataRow dr = dt.NewRow();
                    dr["account_id"] = txtAcc.Text;
                    dr["transaction_date"] = DateTime.Now;
                    dr["transaction_type"] = "DEPOSIT";
                    dr["transaction_balance"] = Math.Round((balance - (balance * 0.001)), 3);
                    dr["remark"] = "Deposit at Bank";
                    dr["transaction_status_print"] = 0;
                    dt.Rows.Add(dr);



                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(dsTransaction, "transaction");
                    cb.Dispose();
                    da.Dispose();
                    dsTransaction.Dispose();


                    //update balance
                    string sqlCus = "SELECT * FROM tb_customer where account_id ='" + txtAcc.Text + "'";
                    dataset.customer dsCus = new dataset.customer();
                    SqlDataAdapter daCus = new SqlDataAdapter(sqlCus, conn);
                    daCus.Fill(dsCus, "customer");
                    DataTable dtCus = dsCus.Tables["customer"];

                    DataRow drCus = dtCus.Rows[0];
                    drCus["balance"] = Convert.ToDouble(drCus["balance"]) + Math.Round((balance - (balance * 0.001)), 3);

                    SqlCommandBuilder cbCus = new SqlCommandBuilder(daCus);
                    daCus.Update(dsCus, "customer");
                    cbCus.Dispose();
                    daCus.Dispose();
                    dsCus.Dispose();

                    MessageBox.Show("SUCCESS!!!");
                    clearValue();
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: {0}", ex.Message);
            }
        }

        
        private void clearValue()
        {
            txtAcc.Clear();
            txtAcc.Enabled = true;
            btnSearch.Enabled = true;
            lName.Text = "";
            lMidName.Text = "";
            lLastName.Text = "";
            lBalance.Text = "";
            txtDeposit.Clear();
            txtDeposit.Enabled = false;
            btnSave.Enabled = false;
        }

        //Set Number only
        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {

                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 4)
                {
                    e.Handled = true;
                }

            }
        }


        //Clear All value
        private void brnReset_Click(object sender, EventArgs e)
        {
            clearValue();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
