using InvoiceMe.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceMe
{
    public partial class FM_MainMenu : Form
    {
        public FM_MainMenu()
        {
            InitializeComponent();
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
    }
}
