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
    public partial class FM_ClientManager : Form
    {
        public FM_ClientManager()
        {
            InitializeComponent();
        }

        private void FM_ClientManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            FM_MainMenu mainmenu = new FM_MainMenu();
            mainmenu.Show();
        }

        private void tickBox_editMode_CheckedChanged(object sender, EventArgs e)
        {
            if ( tickBox_editMode.Checked == false )
            {
                tickBox_editMode.BackColor = Color.White;
                cb_clientselection.Visible = false;
                pnl_edit.BorderStyle = BorderStyle.Fixed3D;
                btn_save.Text = "Save"; btn_save.BackColor = Color.PaleTurquoise;
                lb_clientTitle.Text = "New Client";
                btn_delete.Enabled = false;
            } else
            {
                tickBox_editMode.BackColor = Color.Red;
                cb_clientselection.Visible = true;
                pnl_edit.BorderStyle = BorderStyle.FixedSingle;
                btn_save.Text = "Save Changes"; btn_save.BackColor = Color.Tomato;
                lb_clientTitle.Text = "Edit Client";
                btn_delete.Enabled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if ( tickBox_editMode.Checked == false)
            {
                //normal save mode


            }else
            {
                //editing a row in the database


            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
