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
        // not in use, this method can be used to set password of DB
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
        } // END OF SET DB PASSWORD

        // used to check user has an account
        public bool CheckLogin(string myConnString, string myTable, string user, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(myConnString))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT count(*) as username FROM [" + myTable + "] WHERE [username] = :username AND [password] = :password;";
                cmd.Parameters.Add("username", DbType.String).Value = user;
                cmd.Parameters.Add("password", DbType.String).Value = password;
                Int64 count = Convert.ToInt64(cmd.ExecuteScalar());
                conn.Close();
                if (count == 1) { return true; } else { return false; }
            }

        }
        // retrive whole data table (used to fill data grids) (possible split to groups depending on how big DB gets)
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
        } // END OF CHECK LOGIN

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
                    "VALUES( :name , :addr1 , :addr2 , :pcode , :city , :telephone , :mobile , :email )"; // variables take from form 
                    sqCommand.Parameters.Add("name", DbType.String).Value = name;
                    sqCommand.Parameters.Add("addr1", DbType.String).Value = addr1;
                    sqCommand.Parameters.Add("addr2", DbType.String).Value = addr2;
                    sqCommand.Parameters.Add("pcode", DbType.String).Value = pcode;
                    sqCommand.Parameters.Add("city", DbType.String).Value = city;
                    sqCommand.Parameters.Add("telephone", DbType.String).Value = telephone;
                    sqCommand.Parameters.Add("mobile", DbType.String).Value = mobile;
                    sqCommand.Parameters.Add("email", DbType.String).Value = email;

                    conn.Open();
                    Debug.WriteLine(sqCommand.CommandText);
                    sqCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Added Successfully", myTable);
                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show("ErrorCode: " + sqlex.ErrorCode + "\n" + sqlex.Message , myTable);
            }
        } // END OF INSERT NEW CLIENT DATA

        // not in use just an example and debug method  ( POSSIBLE REMOVE SOON )
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
                    Debug.WriteLine(sqReader.GetInt32(0).ToString() + " " + sqReader.GetString(1) + " " + sqReader.GetString(2));
                }
            }
            finally
            {
                // always call Close when done reading.
                sqReader.Close();

                // Close the connection when done with it.
                sqConnection.Close();
            }
        } // END OF READ MY DATA


        // returns a list of a column ( used to fill combo boxes )  MODIFY TO ALIGN WITH REST OF SQL FUNCTIONS
        public List<string> columnReturnData(string myConnString, string myTable, string column)
        {
            List<string> columnData = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection(myConnString))
            {
                conn.Open();
                string query = "SELECT " + column + " FROM [" + myTable + "]";
                using (SQLiteCommand sqcommand = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = sqcommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                columnData.Add(reader.GetString(0));
                            }
                            catch (InvalidCastException)
                            {
                                columnData.Add(reader.GetInt32(0).ToString());
                            }

                        }
                    }
                }
            }
            return columnData;
        } // END OF COLUMN RETURN DATA

        // return a list of data from a certain row
        public List<string> FillForm(string myConnString, string myTable, string row)
        {
            List<string> rowData = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection(myConnString))
            {
                SQLiteCommand sqcommand = conn.CreateCommand();
                sqcommand.CommandText = "SELECT * FROM [" + myTable + "]  WHERE[ClientID] = :row";
                sqcommand.Parameters.Add("row", DbType.Int16).Value = row;
                conn.Open();
                using (SQLiteDataReader reader = sqcommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            try
                            {
                                rowData.Add(reader.GetString(i));
                            }
                            catch (InvalidCastException)
                            {
                                try
                                {
                                    rowData.Add(reader.GetInt32(i).ToString());
                                }
                                catch (InvalidCastException) // assumes is string or int isnt found the field is a null
                                {
                                    rowData.Add("null");
                                }
                            }
                        }
                    }
                    conn.Close();
                }
            }
            return rowData;
        } // END OF FILL FORM

        public void RemoveRow(string myConnString, string myTable, string row)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(myConnString))
                {
                    SQLiteCommand sqCommand = conn.CreateCommand();
                    sqCommand.CommandText = "DELETE FROM " + myTable + " WHERE ClientID = :row;";
                    sqCommand.Parameters.Add("row", DbType.Int16).Value = row;
                    conn.Open();
                    sqCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (SQLiteException Sqlex)
            {
                MessageBox.Show(Sqlex.Message);
                return;
            }
        }
        // END OF REMOVE ROW




    }
}
