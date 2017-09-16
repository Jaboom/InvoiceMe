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
    public partial class FM_ClientManager : Form
    {
        SqliteHandler sql = new SqliteHandler();

        public FM_ClientManager()
        {
            InitializeComponent();
        }

        private void FM_ClientManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            FM_MainMenu mainmenu = new FM_MainMenu();
            mainmenu.Show();
        }
        // chanage form state when edit mode is active
        private void tickBox_editMode_CheckedChanged(object sender, EventArgs e)
        {
            // NOT editmode
            if ( tickBox_editMode.Checked == false )
            {
                tickBox_editMode.BackColor = Color.White;  // white edit button (indicate not active)
                cb_clientselection.Visible = false; cb_clientselection.DataSource = null; // hide combo box and set Data to null ( this is edit mode feature only )
                pnl_edit.BorderStyle = BorderStyle.Fixed3D;  // sink edit panel
                btn_save.Text = "Save"; btn_save.BackColor = Color.PaleTurquoise;  // change text button text and colour
                lb_clientTitle.Text = "New Client";  // change title of form
                btn_delete.Enabled = false; btn_delete.BackColor = Color.Gray; btn_delete.FlatStyle = FlatStyle.Standard;  // change delete button state and style
                Clear_fields();  // clear all fields ready for new client entry
            }
            else  // IS editmode
            {
                tickBox_editMode.BackColor = Color.Red;  // red edit button ( indicate editmode is active
                cb_clientselection.Visible = true;  // show combo box 
                cb_clientselection.DataSource = sql.columnReturnData(FM_LoginScreen.conString, "ClientTable", "ClientID"); // set combo box data source
                if (cb_clientselection.Text == "") { MessageBox.Show("yep"); } // SOMETHING AROUND HERE!!! 
                pnl_edit.BorderStyle = BorderStyle.FixedSingle; // unsink edit pannel
                btn_save.Text = "Save Changes"; btn_save.BackColor = Color.Tomato;  // change "save button" style
                lb_clientTitle.Text = "Edit Client";  // change title of form 
                btn_delete.Enabled = true; btn_delete.BackColor = Color.Red; btn_delete.FlatStyle = FlatStyle.Popup;  // change delete button state and style
            }
        }
        // save new entry (complete) // else = edit current selected enry ( to be complete )
        private void btn_save_Click(object sender, EventArgs e)
        {
            if ( tickBox_editMode.Checked == false)
            {
                if (tb_clientName.Text == "") { MessageBox.Show("Clients Name can not be empty"); return; }
                //normal save mode ( more error checking required - also option on button save yes / no
                string message = "You are about to add a new Client: " + tb_clientName.Text;
                string caption = "ClientTable";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    sql.InsertNewClientData(FM_LoginScreen.conString, "ClientTable", tb_clientName.Text
                                            , tb_addressL1.Text, tb_addressL2.Text, tb_postcode.Text, tb_city.Text, 
                                            tb_telephone.Text, tb_mobile.Text, tb_email.Text);

                    // set fields back to blank
                    Clear_fields();
                }
                      

            }else
            {
                //editing a row in the database ( to be complete )
                if (tickBox_editMode.Checked)
                {
                    string message = "You are about to save your changes to Client: " + tb_clientName.Text;
                    string caption = "ClientTable";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        sql.UpdateChangesClientTable(FM_LoginScreen.conString, "ClientTable", Convert.ToInt32(cb_clientselection.Text)
                                                    , tb_clientName.Text, tb_addressL1.Text, tb_addressL2.Text, tb_postcode.Text
                                                    , tb_city.Text, tb_telephone.Text, tb_mobile.Text, tb_email.Text);

                        tickBox_editMode.Checked = false;
                    }
                }

            }
        }
        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //Client has invoice ?
            bool hasinvoice = sql.ClientHasInvoiceCheck(FM_LoginScreen.conString, "InvoiceTable", cb_clientselection.Text);
            if (hasinvoice == true)
            {
                MessageBox.Show("Unable to delete client!\n" + tb_clientName.Text + " has invoices present", "SQL Conflict");
                return;
            }            

            //delete a row in client database
            if (tickBox_editMode.Checked)
            {
                string message = "You are about to delete Client: " + tb_clientName.Text;
                string caption = "ClientTable";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if ( result == DialogResult.Yes)
                {
                    sql.RemoveRow(FM_LoginScreen.conString, "ClientTable", "ClientID" ,cb_clientselection.Text);
                    
                    tickBox_editMode.Checked = false;
                }           
            }
        }

        // what happens when combo box is changed
        private void cb_clientselection_SelectedIndexChanged(object  sender, EventArgs e)
        {
            if (tickBox_editMode.Checked)
            {
                Set_fields();
            }
        }
        // set fields with current selected client in combo box ( make sure combo box Text is an int )
        private void Set_fields()
        {
            TextBox[] o_fields = { tb_clientName, tb_addressL1, tb_addressL2, tb_postcode, tb_city, tb_telephone, tb_mobile, tb_email };
            List<string> l_fields = sql.FillForm(FM_LoginScreen.conString, "ClientTable", cb_clientselection.Text);
            for (int i = 0; i < (o_fields.Length); i++)
            {
                o_fields[i].Text = l_fields[i+1];
            }
            lb_clientID.Text = l_fields[0];
            if (l_fields[l_fields.Count - 1] == "null") { lb_latepayments.Text = "0"; }
            else { lb_latepayments.Text = l_fields[l_fields.Count - 1]; }            
        }
        // clears fields ( use this when edit mode is turn off or a new entry has been made )
        private void Clear_fields()
        {
            tb_clientName.Text = tb_addressL1.Text = tb_addressL2.Text = tb_postcode.Text = tb_city.Text =
            tb_telephone.Text = tb_mobile.Text = tb_email.Text = "";
            lb_clientID.Text = lb_latepayments.Text = "...";
        }

    }
}
