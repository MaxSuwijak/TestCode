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
    public partial class createCustomer : Form
    {
        public createCustomer()
        {
            InitializeComponent();
        }
        bool InputIsCommand = false;
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
        //Control Key input only Ctrl + c,v
        private void txtAcc_KeyDown(object sender, KeyEventArgs e)
        {
            InputIsCommand = e.Control == true && (e.KeyCode == Keys.V || e.KeyCode == Keys.C);
        }

        private void txtAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !InputIsCommand;
        }


        //link generate Account

        private void btnGenAcc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome", "http://randomiban.com/?country=Netherlands");
        }

        private void brnResetAcc_Click(object sender, EventArgs e)
        {
            txtAcc.Clear();
        }

        private void createCustomer_Load(object sender, EventArgs e)
        {
            //set Country
            cbCountry.DataSource = ISO3166.GetCollection();
            cbCountry.DisplayMember = "name";
            cbCountry.ValueMember = "alpha2";
            initDb();

        }


        private void cbCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // set dial code
            cbtel.DataSource = ISO3166.FromAlpha2(cbCountry.SelectedValue.ToString()).DialCodes;
            cbtel.DisplayMember = "DialCodes";
        }

        //Set Number only
        private void txtbalance_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            //Check value
            if(txtAcc.Text == "")
            {
                lErrAcc.Visible = true;
                return;
            }
            if(txtName.Text == "")
            {
                lErrName.Visible = true;
                return;
            }
            if (txtLastname.Text == "")
            {
                lErrLastName.Visible = true;
                return;
            }
            if (cbtel.Text == "")
            {
                lErrTel.Visible = true;
                return;
            }
            if (txtbalance.Text == "")
            {
                lErrBalance.Visible = true;
                return;
            }


            try
            {
                // check Account id in DB
                string sql = "SELECT * FROM tb_customer where account_id ='" + txtAcc.Text + "'";
                dataset.customer dsCus = new dataset.customer();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dsCus, "customer");
                DataTable dt = dsCus.Tables["customer"];
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Please generate new Account!!!");
                    txtAcc.Text = "";
                    return;
                }
                    
                // insert customer detail to DB
                else
                {
                     double balance = Convert.ToDouble(txtbalance.Text.ToString());
                     string message = string.Format(@"Account : {0} "+"\n"+ "Name : {1}" + "\n" + 
                        "Middle Name : {2}"+ "\n" + "Last Name : {3}"+"\n" +"Country : {4}" +"\n"+ "Tel : {5} {6}"+ "\n" + 
                        "Balance : {7}", txtAcc.Text, txtName.Text, txtMidName.Text, txtLastname.Text, cbCountry.Text,
                            cbtel.Text, txtTel.Text, Math.Round((balance - (balance * 0.001)), 3).ToString("#,###.000"));
                     DialogResult dialogResult = MessageBox.Show(message, "Confirm create Account", MessageBoxButtons.YesNo);
                     if (dialogResult == DialogResult.Yes)
                     {
                         DataRow dr = dt.NewRow();
                         dr["account_id"] = txtAcc.Text;
                         dr["name_cus"] = txtName.Text;
                         dr["mid_name_cus"] = txtMidName.Text;
                         dr["last_name_cus"] = txtLastname.Text;
                         dr["country"] = cbCountry.Text;
                         dr["dial_code"] = cbtel.Text;
                         dr["tel_cus"] = txtTel.Text;
                         
                         dr["balance"] = Math.Round((balance - (balance * 0.001)), 3);
                         dr["account_status"] = 1;
                         dt.Rows.Add(dr);
                         SqlCommandBuilder cb = new SqlCommandBuilder(da);
                         da.Update(dsCus, "customer");
                         cb.Dispose();
                         da.Dispose();
                         dsCus.Dispose();

                         // create transaction
                         insertTransaction();

                         MessageBox.Show("SUCCESS!!!");
                         clearValue();
                     }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: {0}", ex.Message);
            }
        }

        private void insertTransaction()
        {
            try
            {
                //insert transaction
                string sql = "SELECT * FROM tb_transaction where transaction_id = 0";
                dataset.transaction dsTransaction = new dataset.transaction();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dsTransaction, "transaction");
                DataTable dt = dsTransaction.Tables["transaction"];

                DataRow dr = dt.NewRow();
                
                //dr["transaction_id"] = ;
                dr["account_id"] = txtAcc.Text;
                dr["transaction_date"] = DateTime.Now;
                dr["transaction_type"] = "DEPOSIT";
                double balance = Convert.ToDouble(txtbalance.Text.ToString());
                dr["transaction_balance"] = Math.Round((balance - (balance * 0.001)), 3);
                dr["remark"] = "New Account";
                dr["transaction_status_print"] = 0;
                
                dt.Rows.Add(dr);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(dsTransaction, "transaction");
                cb.Dispose();
                da.Dispose();
                dsTransaction.Dispose();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: {0}", ex.Message);
            }
        }

        private void clearValue()
        {
            txtAcc.Clear();
            txtbalance.Clear();
            txtLastname.Clear();
            txtMidName.Clear();
            txtName.Clear();
            txtTel.Clear();
            cbtel.DataSource = null;
            cbCountry.SelectedIndex = 0;

        }


    }
}
