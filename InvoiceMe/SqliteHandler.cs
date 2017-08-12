using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;

// forgien key needs inputting
// Error index 1

namespace InvoiceMe
{
    class SqliteHandler
    {
        public void SetDBpassword(string myConnString, string password = null)
        {
            if (password == null)
            {
                SQLiteConnection sqConnection = new SQLiteConnection(myConnString);
                sqConnection.Open();
                sqConnection.ChangePassword(String.Empty);
                sqConnection.Close();
            }
            else
            {
                SQLiteConnection sqConnection = new SQLiteConnection(myConnString);
                sqConnection.Open();
                sqConnection.ChangePassword(password);
                sqConnection.Close();
            }
        }

        public bool CheckLogin(string myConnString, string myTable, string user, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(myConnString))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT count(*) as username FROM [" + myTable + "] WHERE [username] = @username AND [password] = @password;";
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", password);
                Int64 count = Convert.ToInt64(cmd.ExecuteScalar());
                conn.Close();
                if (count == 1) { return true; } else { return false; }
            }

        }
        // retrive whole data table
        public DataTable DataTable(string myConnString, string myTable)
        {
            SQLiteConnection sqConnection = new SQLiteConnection(myConnString);
            sqConnection.Open();

            SQLiteCommand sqCommand = (SQLiteCommand)sqConnection.CreateCommand();
            sqCommand.CommandText = "SELECT * FROM [" + myTable + "];";

            SQLiteDataReader dataReader = sqCommand.ExecuteReader();
            DataTable dt = new DataTable(myTable);
            dt.Load(dataReader);
            return dt;
        }
        // adds row to client database ( needs some checks like blank fields etc ) 
        // maybe change to overload function with expandable tables and fields
        public void InsertNewClientData(string myConnString, string myTable, string name, string addr1, string addr2, string pcode, 
            string city, string telephone, string mobile, string email)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(myConnString))
                {
                    SQLiteCommand sqCommand = conn.CreateCommand();
                    sqCommand.CommandText = "INSERT INTO " + myTable + // command to Insert to given table
                    "(ClientName,AddressLine1,AddressLine2,Postcode,City,Telephone,Mobile,Email)" + //given fields for inserting ( currently only set to client table)
                    "VALUES('" + name + "','" + addr1 + "','" + addr2 + "','" + pcode +  // variables taken from form
                    "','" + city + "','" + telephone + "','" + mobile + "','" + email + "')"; // variables take from form (not split by ',' )
                    conn.Open();
                    Debug.WriteLine(sqCommand.CommandText);
                    sqCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show( "Added Successfully",myTable);
                }
            }
            catch
            {
                MessageBox.Show( "Error: " + 1 + "x" + 1.ToString("x") + "/nPlease Report this");
            }
        }
        

        public void ReadMyData(string myConnString, string myTable)
        {
            SQLiteConnection sqConnection = new SQLiteConnection(myConnString);
            SQLiteCommand sqCommand = (SQLiteCommand)sqConnection.CreateCommand();
            sqCommand.CommandText = "SELECT * FROM [" + myTable + "];";
            sqConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();
            try
            {
                // Always call Read before accessing data.
                while (sqReader.Read())
                {
                    Debug.WriteLine(sqReader.GetInt32(0).ToString() + " " +
                    sqReader.GetString(1) + " " + sqReader.GetString(2));                   
                }
            }
            finally
            {
                // always call Close when done reading.
                sqReader.Close();

                // Close the connection when done with it.
                sqConnection.Close();
            }
        }


    }
}
