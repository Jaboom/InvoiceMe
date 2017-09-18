using InvoiceMe.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceMe
{
    public partial class FM_MainMenu : Form
    {
        public int permissions = 0;

        public FM_MainMenu()
        {
            InitializeComponent();
            permissions = AssignUserRank();
            PermisionsLock(permissions);
        }
        private int AssignUserRank()
        {
            string rank = "";
            int permissions = 0;
            if (FM_LoginScreen._userRank == 0) { rank = "Unasigned"; permissions = 0; }
            if (FM_LoginScreen._userRank == 1) { rank = "Owner"; permissions = 1; }
            if (FM_LoginScreen._userRank == 2) { rank = "Admin"; permissions = 2; }
            if (FM_LoginScreen._userRank == 3) { rank = "User"; permissions = 3; }
            lb_userInfo.Text = String.Format("User: {0} | ID: {1} | Rank: {2}", FM_LoginScreen._userName, FM_LoginScreen._userID, rank);
            return permissions;
        }

        private void PermisionsLock(int permissionsLevel)
        {
            switch (permissionsLevel)
            {
                case 0:
                    btn_extraOptions.Visible = btn_clientmgr.Enabled = btn_invoicemgr.Enabled = 
                        btn_overview.Enabled = btn_printinvoices.Enabled = false;
                    break;
                case 1:
                    btn_extraOptions.Visible = btn_clientmgr.Enabled = btn_invoicemgr.Enabled =
                        btn_overview.Enabled = btn_printinvoices.Enabled = true;
                    btn_extraOptions.Text = "Owner Options";
                    break;
                case 2:
                    btn_extraOptions.Visible = btn_clientmgr.Enabled = btn_invoicemgr.Enabled =
                        btn_overview.Enabled = btn_printinvoices.Enabled = true;
                    btn_extraOptions.Text = "Admin Options";
                    break;
                case 3:
                    btn_extraOptions.Visible = false;
                        btn_clientmgr.Enabled = btn_invoicemgr.Enabled =
                        btn_overview.Enabled = btn_printinvoices.Enabled = true;
                    break;
            }           
        }

        private void btn_invoicemgr_Click(object sender, EventArgs e)
        {
            FM_InvoiceManager invoicemanager = new FM_InvoiceManager();
            invoicemanager.Show();
            this.Hide();
        }

        private void btn_clientmgr_Click(object sender, EventArgs e)
        {
            FM_ClientManager clientmanager = new FM_ClientManager();
            clientmanager.Show();
            this.Hide();
        }

        private void btn_overview_Click(object sender, EventArgs e)
        {
            FM_Overview overview = new FM_Overview();
            overview.Show();
            this.Hide();
        }

        private void btn_printinvoices_Click(object sender, EventArgs e)
        {
            FM_PrintInvoices printinvoices = new FM_PrintInvoices();
            printinvoices.Show();
            this.Hide();
        }

        private void FM_MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_extraOptions_Click(object sender, EventArgs e)
        {
            if (permissions == 2)
                MessageBox.Show("Admin options");
            if (permissions == 1)
                MessageBox.Show("Owner options");
        }
    }
}
