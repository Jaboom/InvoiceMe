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

namespace InvoiceMe.Forms
{
    public partial class FM_InvoiceManager : Form
    {
        SqliteHandler sql = new SqliteHandler();
        DataTable dt = new DataTable();

        public FM_InvoiceManager()
        {
            InitializeComponent();
            cb_clientName.DataSource = sql.columnReturnData(FM_LoginScreen.conString, "ClientTable", "ClientID");
            //this.Size = new System.Drawing.Size(1200, 900);
            //this.MinimumSize = new System.Drawing.Size(1200, 900);
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
            Set_form_state();
        }

        private void Set_form_state()
        {
            if (tickBox_editMode.Checked == false)
            {
                tickBox_editMode.BackColor = Color.White;
                pnl_edit.BorderStyle = BorderStyle.Fixed3D;
                btn_new.Text = "Create New"; btn_new.BackColor = Color.MediumSeaGreen;
                lb_invoiceTitle.Text = "New Invoice";
                btn_previousInvoice.Visible = btn_nextInvoice.Visible = btn_delete.Visible =
                tb_invoiceNo.Visible = lb_editof.Visible = lb_invoiceTotal.Visible = false;
                Clear_Invoice_fields();
                //tb_InvoiceDescription.Enabled = false; tb_InvoiceDescription.ReadOnly = true;
                tb_InvoiceDescription.Cursor = Cursors.Default;
                btn_editItem.Visible = false;
            }
            else
            {
                tickBox_editMode.BackColor = Color.Red;
                pnl_edit.BorderStyle = BorderStyle.FixedSingle;
                btn_new.Text = "Save Changes"; btn_new.BackColor = Color.LightCoral;
                lb_invoiceTitle.Text = "Edit Invoice";
                btn_previousInvoice.Visible = btn_nextInvoice.Visible = btn_delete.Visible =
                tb_invoiceNo.Visible = lb_editof.Visible = lb_invoiceTotal.Visible = true;
                tb_invoiceNo.Text = "1";
                Set_Invoice_fields();
                //tb_InvoiceDescription.Enabled = true; tb_InvoiceDescription.ReadOnly = false;
                tb_InvoiceDescription.Cursor = Cursors.IBeam;
                btn_editItem.Visible = true;
            }
        }
        private void cb_clientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set_Client_fields();
            tb_invoiceNo.Text = "1";
            Set_Data_Table();
            //lb_invoiceTotal.Text = Convert.ToString(dt.Rows.Count);
        }

        private void btn_previousInvoice_Click(object sender, EventArgs e)
        {
            // scroll to previous invoice in sinvoice table where selected client's ID = clients ID
            //btn_previousInvoice.Text = "<";
            int invoiceno;
            Int32.TryParse(tb_invoiceNo.Text, out invoiceno);
            if (invoiceno == 1) { tb_invoiceNo.Text = lb_invoiceTotal.Text; return; }
            invoiceno--; tb_invoiceNo.Text = Convert.ToString(invoiceno);
        }

        private void btn_nextInvoice_Click(object sender, EventArgs e)
        {
            // scroll to next invoice in invoice table where selected client's ID = clients ID
            //btn_nextInvoice.Text = ">";
            int invoiceno, invoicetotal;
            Int32.TryParse(tb_invoiceNo.Text, out invoiceno); Int32.TryParse(lb_invoiceTotal.Text, out invoicetotal);
            if (invoiceno == invoicetotal) { tb_invoiceNo.Text = "1"; return; }
            invoiceno++; tb_invoiceNo.Text = Convert.ToString(invoiceno);
        }

        // scroll to invoice number (NOT INVOICE ID) in invoice table where selected client's ID = clients ID
        private void tb_invoiceNo_TextChanged(object sender, EventArgs e)
        {
            int invoiceNo, invoiceTotal;
            Int32.TryParse(tb_invoiceNo.Text, out invoiceNo);
            Int32.TryParse(lb_invoiceTotal.Text, out invoiceTotal);
            
            if ( invoiceNo > invoiceTotal )
            {
                tb_invoiceNo.Text = lb_invoiceTotal.Text;
            }
            if ( invoiceNo < 1)
            {
                tb_invoiceNo.Text = "1";
            }
            Set_Invoice_fields();
        }

        private string GetRecievedDate()
        {
            if (tickbox_Receied.Checked)
            {
                return dtp_receivedDate.Value.ToShortDateString();
            }
            else
            {
                return "- - / - - / - - - -";
            }
        }
        private string GetPaidDate()
        {
            if (tickbox_paid.Checked)
            {
                return dtp_paidDate.Value.ToShortDateString();
            }
            else
            {
                return "- - / - - / - - - -";
            }
        }


        private void btn_new_Click(object sender, EventArgs e)
        {
            string invoiceAmount = tb_invoiceAmount.Text.Remove(0, 1);
            if( tickBox_editMode.Checked == false)
            {
                // New Invoice
                if (tb_invoiceAmount.Text == "" || tb_InvoiceDescription.Text == "") { MessageBox.Show("Invoice Amount or Description can not be empty"); return; }
                //normal save mode ( more error checking required - also option on button save yes / no
                string message = "You are about to add a new Invoice for: " + lb_clientID.Text;
                string caption = "InvoiceTable";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                string receivedDate = GetRecievedDate();
                string paidDate = GetPaidDate();
                
                if (result == DialogResult.Yes)
                {
                    sql.InsertNewInvoiceData(FM_LoginScreen.conString, "InvoiceTable", cb_clientName.Text, invoiceAmount,
                                                tb_InvoiceDescription.Text, DateTime.Today.ToShortDateString(), tickbox_Receied.Checked,
                                                receivedDate, tickbox_paid.Checked, paidDate);                    
                }

            }
            else
            {
                // Edit Invoice
                if (tb_invoiceAmount.Text == "" || tb_InvoiceDescription.Text == "") { MessageBox.Show("Invoice Amount or Description can not be empty"); return; }
                //normal save mode ( more error checking required - also option on button save yes / no
                string message = "You are about to Change Invoice: " + lb_invoiceID.Text + " for: " + lb_clientID.Text;
                string caption = "InvoiceTable";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                string receivedDate = GetRecievedDate();
                string paidDate = GetPaidDate();

                if (result == DialogResult.Yes)
                {
                    sql.UpdateChangesInvoiceTable(FM_LoginScreen.conString, "InvoiceTable", Convert.ToInt32(lb_invoiceID.Text)
                                                , cb_clientName.Text, invoiceAmount, tb_InvoiceDescription.Text
                                                , DateTime.Today.ToShortDateString(), tickbox_Receied.Checked
                                                , receivedDate, tickbox_paid.Checked, paidDate);
                }


            }
            //             
            Set_Data_Table();
            tickBox_editMode.Checked = false;
            Set_form_state();
            // ADD a method to update LaidPaid in client Table ( this is only place the LaidPaid will need updating )
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
        private void Set_Data_Table()
        {
            dt = sql.FilterDataTable(FM_LoginScreen.conString, "InvoiceTable", cb_clientName.Text);
            Set_Invoice_fields();
        }
        private void Clear_Invoice_fields()
        {
            lb_invoiceID.Text = "...";
            tb_invoiceAmount.Text = "";
            tb_InvoiceDescription.Text = "";
            lb_producedDate.Text = "- - / - - / - - - -";
            tickbox_Receied.Checked = false;
            lb_receivedDate.Text = "- - / - - / - - - -";
            tickbox_paid.Checked = false;
            lb_paidDate.Text = "- - / - - / - - - -";
        }

        private void Set_Invoice_fields()
        {
            if (tickBox_editMode.Checked)
            {
                if ( tb_invoiceNo.Text == "") { return; };
                int currentrow; Int32.TryParse(tb_invoiceNo.Text, out currentrow); --currentrow;
                //DataTable dttest = sql.FilterDataTable(FM_LoginScreen.conString, "InvoiceTable", cb_clientName.Text);

                try
                {
                    lb_invoiceID.Text = Convert.ToString(dt.Rows[currentrow][0]);
                    tb_invoiceAmount.Text = Convert.ToString(dt.Rows[currentrow][2]);
                    tb_InvoiceDescription.Text = (string)dt.Rows[currentrow][3];
                    lb_producedDate.Text = (string)dt.Rows[currentrow][4];
                    tickbox_Receied.Checked = (bool)dt.Rows[currentrow][5];
                    lb_receivedDate.Text = (string)dt.Rows[currentrow][6];
                    tickbox_paid.Checked = (bool)dt.Rows[currentrow][7];
                    lb_paidDate.Text = (string)dt.Rows[currentrow][8];
                    lb_invoiceTotal.Text = Convert.ToString(dt.Rows.Count);
                    if ((string)dt.Rows[currentrow][6] == "- - / - - / - - - -" ) { dtp_receivedDate.Value = DateTime.Today; }
                    else { dtp_receivedDate.Value = Convert.ToDateTime(dt.Rows[currentrow][6]); }
                    if ((string)dt.Rows[currentrow][8] == "- - / - - / - - - -") { dtp_paidDate.Value = DateTime.Today; }
                    else { dtp_paidDate.Value = Convert.ToDateTime(dt.Rows[currentrow][8]); }
                    //lb_receivedDate.Text = (string)dt.Rows[currentrow][6];
                    //lb_paidDate.Text = (string)dt.Rows[currentrow][8];
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("No Data for this client");
                    //Clear_Invoice_fields();
                    tickBox_editMode.Checked = false;
                    Set_form_state();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Debug
        }

        private void tb_invoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only numbers allowed
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;                
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (tickBox_editMode.Checked)
            {
                string message = "You are about to Delete Invoice: " + lb_invoiceID.Text + "\nThat belongs to: " + lb_clientID.Text;
                string caption = "InvoiceTabel";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    sql.RemoveRow(FM_LoginScreen.conString, "InvoiceTable", "InvoiceID",lb_invoiceID.Text);

                    tickBox_editMode.Checked = false;
                    Set_Data_Table();
                }
            }
        }
        // Add item to invoice
        private void btn_addItem_Click(object sender, EventArgs e)
        {
            // Open AddItem form
            using ( var addnew = new FM_AddItem())
            {
                // check Accept was clicked
                var result = addnew.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string newItem = addnew.returnString;
                    // Add item to Description
                    if ((tb_InvoiceDescription.Text.EndsWith(Environment.NewLine)) || tb_InvoiceDescription.Text.Length == 0)
                    {
                        tb_InvoiceDescription.Text += newItem;
                    }
                    else { tb_InvoiceDescription.Text += Environment.NewLine + newItem; }
                }
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Canceled");
                }
            }
        }

        private void tb_InvoiceDescription_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            string[] splitDescription = tb_InvoiceDescription.Text.Replace(System.Environment.NewLine, "\n").Split('\n');
            double grTotal = 0; // declaire grand total variable
            foreach (string s in splitDescription)
            {
                try
                {
                    string total = s.Split('@')[1].Split('=')[1].TrimStart(' ');
                    double gTotal;
                    Double.TryParse(total.TrimStart('£'), out gTotal);

                    grTotal = grTotal + gTotal;
                }
                catch (IndexOutOfRangeException) { i++; if (i > 1) { MessageBox.Show("Array Index of " + i, "InvoiceAmount"); } }
            }
            tb_invoiceAmount.Text = grTotal.ToString("C");
        }

        private void btn_editItem_Click(object sender, EventArgs e)
        {
            using (var addnew = new FM_EditItem(tb_InvoiceDescription.Text))
            {
                // check Accept was clicked
                var result = addnew.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string newItem = addnew.returnString;
                    // Add item to Description
                    tb_InvoiceDescription.Text = newItem; 
                }
                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Canceled");
                }
            }
        }
    }
}
