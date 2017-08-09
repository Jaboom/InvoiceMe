using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace InvoiceMe
{
    public partial class FM_LoginScreen : Form
    {
        SqliteHandler sql = new SqliteHandler();        
        static string dbcommectionstring = @"data source=DB\\Invoice.db;"; // use for none password DB's
        static string passDec = "Password="; static string pass = null; // change pass for choosing DB password

        public static string conString = dbcommectionstring;


        public FM_LoginScreen()
        {
            InitializeComponent();
            if (pass != null) { conString += passDec + pass; } //remove when publish
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            //ReadMyData(dbcommectionstring, "Login");
            bool Login = sql.CheckLogin(conString, "Login", TBuser.Text, TBpassword.Text);
            if (Login == true)
            {
                FM_MainMenu mainmenu = new FM_MainMenu();
                mainmenu.Show();
                this.Owner = mainmenu;
                this.Hide();
            } else { MessageBox.Show("Incorrect Username or Password"); }
        }
    }
}
