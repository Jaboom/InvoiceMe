using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceMe.Forms
{
    public partial class FM_PrintInvoices : Form
    {
        public FM_PrintInvoices()
        {
            InitializeComponent();
        }

        private void FM_PrintInvoices_FormClosed(object sender, FormClosedEventArgs e)
        {
            FM_MainMenu mainmenu = new FM_MainMenu();
            mainmenu.Show();
        }
    }
}
