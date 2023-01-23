using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemBank
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void createCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createCustomer fm = new createCustomer();
            fm.MdiParent = this;
            //fm.Dock = DockStyle.Fill;
            fm.Show();
        }

        private void depositToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tdeposit fm = new Tdeposit();
            fm.MdiParent = this;
            //fm.Dock = DockStyle.Fill;
            fm.Show();

        }

        private void tranfersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ttransfer fm = new Ttransfer();
            fm.MdiParent = this;
            //fm.Dock = DockStyle.Fill;
            fm.Show();
        }
    }
}
