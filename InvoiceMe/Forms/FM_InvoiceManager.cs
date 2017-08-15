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
    public partial class FM_InvoiceManager : Form
    {
        SqliteHandler sql = new SqliteHandler();

        public FM_InvoiceManager()
        {
            InitializeComponent();
            cb_clientName.DataSource = sql.columnReturnData(FM_LoginScreen.conString, "ClientTable", "ClientID");
                
            //lb_producedDate.Text = DateTime.Today.ToShortDateString();
        }

        private void FM_InvoiceManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            FM_MainMenu mainmenu = new FM_MainMenu();
            mainmenu.Show();
        }

        private void tickbox_Receied_CheckedChanged(object sender, EventArgs e)
        {
            if (tickbox_Receied.Checked == false) { tickbox_Receied.BackColor = Color.LightCoral; }
            else { tickbox_Receied.BackColor = Color.Green; }
        }

        private void tickbox_paid_CheckedChanged(object sender, EventArgs e)
        {
            if (tickbox_paid.Checked == false) { tickbox_paid.BackColor = Color.LightCoral; }
            else { tickbox_paid.BackColor = Color.Green; }
        }

        private void tickBox_editMode_CheckedChanged(object sender, EventArgs e)
        {
            if (tickBox_editMode.Checked == false)
            {
                tickBox_editMode.BackColor = Color.White;
                pnl_edit.BorderStyle = BorderStyle.Fixed3D;
                btn_new.Text = "Create New"; btn_new.BackColor = Color.MediumSeaGreen;
                lb_invoiceTitle.Text = "New Invoice";
                btn_previousInvoice.Visible = btn_nextInvoice.Visible = 
                tb_invoiceNo.Visible = lb_editof.Visible = lb_invoiceTotal.Visible = false;
            }
            else
            {
                tickBox_editMode.BackColor = Color.Red;
                pnl_edit.BorderStyle = BorderStyle.FixedSingle;
                btn_new.Text = "Edit Invoice"; btn_new.BackColor = Color.LightCoral;
                lb_invoiceTitle.Text = "Edit Invoice";
                btn_previousInvoice.Visible = btn_nextInvoice.Visible = 
                tb_invoiceNo.Visible = lb_editof.Visible = lb_invoiceTotal.Visible = true;
            }
        }

        private void btn_previousInvoice_Click(object sender, EventArgs e)
        {
            // scroll to previous invoice in sinvoice table where selected client's ID = clients ID
        }

        private void btn_nextInvoice_Click(object sender, EventArgs e)
        {
            // scroll to next invoice in invoice table where selected client's ID = clients ID
        }

        private void tb_invoiceNo_TextChanged(object sender, EventArgs e)
        {
            // scroll to invoice number (NOT INVOICE ID) in invoice table where selected client's ID = clients ID
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if( tickBox_editMode.Checked == false)
            {
                // New Invoice


            }else
            {
                // Edit Invoice


            }
        }

        private void cb_clientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set_Client_fields();
        }

        private void Set_Client_fields()
        {
            //NOTE: lb_clientID is currently being used as NAME label, until i make Name field a unquie key)
            Label[] labels = { lb_clientID, lb_clientAddress, lb_clientTelephone, lb_clientMobile, lb_clientEmail, lb_clientLatepaid };
            List<string> Cdata = sql.FillForm(FM_LoginScreen.conString, "ClientTable", cb_clientName.Text);            
            
            // Seting fields ( note 4 data strings to lb_clientaddress label )
            lb_clientAddress.Text = ""; // set address field to empty

            int data = 1;
            for (int i = 0; i < labels.Length; i++)
            {
                if (i == 1) // if we are on client addresslabel
                {
                    for (int ii = 2; ii < 6; ii++, data++) // loop 4 sets of data
                    {
                        labels[i].Text += Cdata[data] + "\n"; // setting address label
                    }
                }
                else { labels[i].Text = Cdata[data]; data++; } // setting all other labels
            }
        }
    }
}
