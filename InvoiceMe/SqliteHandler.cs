using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;
using System.Data;

// forgien key needs inputting

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
