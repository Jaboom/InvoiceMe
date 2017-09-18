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
        static string dbcommectionstring = @"data source=DB\\InvoiceTest.db;"; // use for none password DB's
        static string passDec = "Password="; static string pass = null; // change pass for choosing DB password

        private bool loginEmpty;

        public static string conString = dbcommectionstring;
        public static string _userName = "";
        public static int _userRank = 0;
        public static int _userID = 0;

        public FM_LoginScreen()
        {
            InitializeComponent();
            if (pass != null) { conString += passDec + pass; } //remove when publish  
            UpdateForm();
        }

        private void UpdateForm()
        {
            loginEmpty = sql.TableEmpty(conString, "Login");
            if ( loginEmpty)
            {
                BTNlogin.Text = "Create";
                lb_headerLogin.Text = "Create Owner Account";
                tb_comfirmPass.Visible = lb_comfirmPass.Visible = true;
            }else {
                BTNlogin.Text = "Login";
                lb_headerLogin.Text = "Login";
                tb_comfirmPass.Visible = lb_comfirmPass.Visible = false;
            }
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            //ReadMyData(dbcommectionstring, "Login");
            if (loginEmpty)
            {
                if (TBpassword.Text == tb_comfirmPass.Text && TBpassword.Text != "" && TBuser.Text != "")
                {
                    sql.InsertNewUser(conString, "Login", TBuser.Text, TBpassword.Text);
                    UpdateForm();
                }else {
                    if (TBuser.Text == "") MessageBox.Show("User can not be empty", "Login");
                    else if (TBpassword.Text == "") MessageBox.Show("Password can not be empty", "Login");
                    else MessageBox.Show("Passwords do not match", "Login");

                    TBpassword.Text = tb_comfirmPass.Text = "";
                }
            }
            else
            {
                bool Login = sql.CheckLogin(conString, "Login", TBuser.Text, TBpassword.Text);
                if (Login == true)
                {
                    SetUserInfo();
                    FM_MainMenu mainmenu = new FM_MainMenu();
                    mainmenu.Show();
                    this.Owner = mainmenu;
                    this.Hide();
                }
                else { MessageBox.Show("Incorrect Username or Password"); }
            }
        }

        private void SetUserInfo()
        {
            List<string> userInfo = sql.UsersInfo(conString, "Login", TBuser.Text, TBpassword.Text);            
            _userName = userInfo[1] ;
            _userID =  Convert.ToInt32(userInfo[0]);
            _userRank = Convert.ToInt32(userInfo[3]);
        }

    }
}
