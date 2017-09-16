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
    

    public partial class FM_EditItem : Form 
    {
        private string currentItems;
        private List<string> itemList;


        public string returnString { get; set; }

        public FM_EditItem(string _currentItems)
        {
            InitializeComponent();
            currentItems = _currentItems;
            itemList = currentItems.Replace(System.Environment.NewLine, "\n").Split('\n').ToList<string>();
            SetItemToEdit();
            SetFields();
        }
        // 1 'Jobs' @ 3.15 = 3.15
        private void SetItemToEdit()
        {
            List<string> itemLineNumberList = new List<string>();

            for (int i = 0; i < itemList.Count; i++)
            {
                itemLineNumberList.Add(Convert.ToString(i + 1));
            }
            cb_itemLineNo.DataSource = itemLineNumberList;

        }

        private void SetFields()
        {
            string s = itemList[cb_itemLineNo.SelectedIndex];
            if (s != "")
            {
                nud_unit.Value = Convert.ToInt32(s.Split('@')[0].Substring(0, s.IndexOf(" ")));
                cb_Description.Text = s.Split('@')[0].Substring(s.IndexOf(" ") + 1);
                tb_price.Text = s.Split('@')[1].Split('=')[0].TrimStart(' ').TrimStart('£');
            }
            else
            {
                nud_unit.Value = 0;
                cb_Description.Text = "";
                tb_price.Text = "";
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (CheckInputs() == false) { return; }
            string returnS = "";
            decimal price; decimal.TryParse(tb_price.Text, out price);
            decimal total = nud_unit.Value * price;
            itemList[cb_itemLineNo.SelectedIndex] = nud_unit.Value + " " + cb_Description.Text + " @ "
                                                + price.ToString("C") + " = " + total.ToString("C");
            for (int i = 0; i < itemList.Count; i++)
            {
                if (i < (itemList.Count-1) )
                {
                    returnS += itemList[i] + Environment.NewLine;
                }else
                {
                    returnS += itemList[i];
                }
            }
            
            this.returnString = returnS;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string returnS = "";
            for (int i = 0; i < itemList.Count; i++)
            {
                if (i != cb_itemLineNo.SelectedIndex)
                {
                    if (i < (itemList.Count - 1))
                    {
                        returnS += itemList[i] + Environment.NewLine;
                    }
                    else
                    {
                        returnS += itemList[i];
                    }
                }
            }
            string message = "You are about to remove item : " + cb_Description.Text;
            string caption = "Item Removing";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                this.returnString = returnS;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }else { return; }
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

        private void cb_itemLineNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFields();
        }
    }
}
