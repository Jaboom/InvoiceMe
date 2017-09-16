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
    public partial class FM_AddItem : Form
    {
        public string returnString { get; set; }

        public FM_AddItem()
        {
            InitializeComponent();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (CheckInputs() == false) { return; }
            string formatedString;
            decimal price; decimal.TryParse(tb_price.Text, out price);
            decimal total = nud_unit.Value * price;
            formatedString = nud_unit.Value + " " + cb_Description.Text + " @ " 
                            + price.ToString("C") + " = " + total.ToString("C");
            
            this.returnString = formatedString;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool CheckInputs()
        {
            if ( nud_unit.Value < 1 ) { MessageBox.Show("Units Must be a Positive Number"); return false; }
            if ( cb_Description.Text == "" ) { MessageBox.Show("Must have a discription"); return false; }
            if ( tb_price.Text == "") { MessageBox.Show("Must have a Value"); return false; }

            return true;
        }

        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only numbers and one '.' allowed
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }
    }
}
