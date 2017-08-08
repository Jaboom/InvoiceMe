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
    public partial class FM_Overview : Form
    {
        SqliteHandler sq = new SqliteHandler();

        public FM_Overview()
        {
            InitializeComponent();
            DataTable dt_invoice = sq.DataTable(FM_LoginScreen.conString, "InvoiceTable");
            DataTable dt_client = sq.DataTable(FM_LoginScreen.conString, "ClientTable");
            DataSet ds = new DataSet();
            ds.Tables.Add(dt_invoice);
            ds.Tables.Add(dt_client);

            dg_invoice.DataSource = ds;
            dg_invoice.DataMember = dt_invoice.TableName;
            dg_invoice.Refresh();

            dg_client.DataSource = ds;
            dg_client.DataMember = dt_client.TableName;
            dg_client.Refresh();
        }

        private void FM_Overview_FormClosed(object sender, FormClosedEventArgs e)
        {
            FM_MainMenu mainmenu = new FM_MainMenu();
            mainmenu.Show();
        }
    }
}
