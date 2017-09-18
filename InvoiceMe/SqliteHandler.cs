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

        // Check if any entries in a table with a filter
        public bool ClientHasInvoiceCheck(string myConnString, string myTable, string clientID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(myConnString))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT count(*) as username FROM[" + myTable + "] WHERE[ClientID] = :clientID;";
                cmd.Parameters.Add("clientID", DbType.Int32).Value = clientID;
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                if ( count > 0 ) { return true; } else { return false; }
            }
        }
        //END of FILTER CHECK

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

        } // END OF CHECK LOGIN

        public bool CheckAlreadyUser(string myConnString, string myTable, string user, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(myConnString))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT count(*) as username FROM [" + myTable + "] WHERE [username] = :username;";
                cmd.Parameters.Add("username", DbType.String).Value = user;
                Int64 count = Convert.ToInt64(cmd.ExecuteScalar());
                conn.Close();
                if (count == 1) { return true; } else { return false; }
            }

        }

        public bool TableEmpty(string myConnString, string myTable)
        {
            using (SQLiteConnection conn = new SQLiteConnection(myConnString))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT count(*) FROM [" + myTable + "];";
                Int64 count = Convert.ToInt64(cmd.ExecuteScalar());
                conn.Close();
                if (count <= 0) { return true; } else { return false; }
            }
        }

        public void InsertNewUser(string myConnString, string myTable, string name, string pass)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(myConnString))
                {
                    SQLiteCommand sqCommand = conn.CreateCommand();
                    sqCommand.CommandText = "INSERT INTO " + myTable + // command to Insert to given table
                                            "(username,password,rank)" +
                                            "VALUES( :name , :pass , :rank)";
                    sqCommand.Parameters.Add("name", DbType.String).Value = name;
                    sqCommand.Parameters.Add("pass", DbType.String).Value = pass;
                    sqCommand.Parameters.Add("rank", DbType.Int32).Value = 1;

                    conn.Open();
                    sqCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Added Owner " + name + " Successfully", myTable);
                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show("ErrorCode: " + sqlex.ErrorCode + "\n" + sqlex.Message, myTable);
            }
        }

        public List<string> UsersInfo(string myConnString, string myTable, string user, string password)
        {
            List<string> userData = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection(myConnString))
            {
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM [" + myTable + "] WHERE [username] = :username AND [password] = :password;";
                cmd.Parameters.Add("username", DbType.String).Value = user;
                cmd.Parameters.Add("password", DbType.String).Value = password;

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            try
                            {
                                userData.Add(reader.GetString(i));
                            }
                            catch (InvalidCastException)
                            {
                                userData.Add(reader.GetInt32(i).ToString());
                            }
                        }
                    }
                }
                conn.Close();
            }
            return userData;
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
                                            "(ClientName,AddressLine1,AddressLine2,Postcode,City,Telephone,Mobile,Email)" + 
                                            "VALUES( :name , :addr1 , :addr2 , :pcode , :city , :telephone , :mobile , :email )";
                    sqCommand.Parameters.Add("name", DbType.String).Value = name;
                    sqCommand.Parameters.Add("addr1", DbType.String).Value = addr1;
                    sqCommand.Parameters.Add("addr2", DbType.String).Value = addr2;
                    sqCommand.Parameters.Add("pcode", DbType.String).Value = pcode;
                    sqCommand.Parameters.Add("city", DbType.String).Value = city;
                    sqCommand.Parameters.Add("telephone", DbType.String).Value = telephone;
                    sqCommand.Parameters.Add("mobile", DbType.String).Value = mobile;
                    sqCommand.Parameters.Add("email", DbType.String).Value = email;

                    conn.Open();
                    sqCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Added Successfully", myTable);
                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show("ErrorCode: " + sqlex.ErrorCode + "\n" + sqlex.Message, myTable);
            }
        } // END OF INSERT NEW CLIENT DATA

        // adds row to invoice database 
        public void InsertNewInvoiceData(string myConnString, string myTable, string ClientID, string Amount, 
                                        string Description, string ProducedDate, 
                                        bool Received, string ReceivedDate, 
                                        bool Paid, string PaidDate)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(myConnString))
                {
                    SQLiteCommand sqCommand = conn.CreateCommand();
                    sqCommand.CommandText = "INSERT INTO " + myTable + // command to Insert to given table
                                            "(ClientID,InvoiceAmount,InvoiceDescription,ProducedDate,Received,ReceivedDate,Paid,PaidDate)" +
                                            "VALUES( :id , :amount , :description , :produced , :received , :receiveddate , :paid , :paiddate  )";
                    sqCommand.Parameters.Add("id", DbType.Int32).Value = ClientID;
                    sqCommand.Parameters.Add("amount", DbType.Double).Value = Amount;
                    sqCommand.Parameters.Add("description", DbType.String).Value = Description;
                    sqCommand.Parameters.Add("produced", DbType.String).Value = ProducedDate;
                    sqCommand.Parameters.Add("received", DbType.String).Value = Received;
                    sqCommand.Parameters.Add("receiveddate", DbType.String).Value = ReceivedDate;
                    sqCommand.Parameters.Add("paid", DbType.String).Value = Paid;
                    sqCommand.Parameters.Add("paiddate", DbType.String).Value = PaidDate;

                    conn.Open();
                    sqCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Added Successfully", myTable);
                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show("ErrorCode: " + sqlex.ErrorCode + "\n" + sqlex.Message, myTable);
            }
        } // END OF INSERT NEW INVOICE DATA

        public DataTable FilterDataTable(string myConnString, string myTable, string filter)
        {
            SQLiteConnection sqConnection = new SQLiteConnection(myConnString);
            sqConnection.Open();

            SQLiteCommand sqCommand = (SQLiteCommand)sqConnection.CreateCommand();
            sqCommand.CommandText = "SELECT * FROM [" + myTable + "] WHERE [ClientID] = :id;";
            sqCommand.Parameters.Add("id", DbType.Int32).Value = filter;

            SQLiteDataReader dataReader = sqCommand.ExecuteReader();
            DataTable dt = new DataTable(myTable);
            dt.Load(dataReader);
            return dt;
        } // END OF CHECK LOGIN

        // returns a list of a column ( used to fill combo boxes )
        public List<string> columnReturnData(string myConnString, string myTable, string column)
        {
            List<string> columnData = new List<string>();
            using (SQLiteConnection conn = new SQLiteConnection(myConnString))
            {
                SQLiteCommand sqcommand = conn.CreateCommand();
                sqcommand.CommandText = "SELECT " + column + " FROM [" + myTable + "]";
                conn.Open();

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

        // Remove a row
        public void RemoveRow(string myConnString, string myTable,string columntitle, string row)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(myConnString))
                {
                    SQLiteCommand sqCommand = conn.CreateCommand();
                    sqCommand.CommandText = "DELETE FROM " + myTable + " WHERE " + columntitle + " = :row;";
                    //sqCommand.Parameters.AddWithValue("column", columntitle);
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
            MessageBox.Show("Deletion Successful", myTable);
        }
        // END OF REMOVE ROW

        //edit current selected row (combobox selection)
        public void UpdateChangesClientTable(string myConnString, string myTable, int ClientID, string name, string addr1, string addr2,
                                            string pcode, string city, string telephone, string mobile, string email)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(myConnString))
                {
                    SQLiteCommand sqCommand = conn.CreateCommand();
                    sqCommand.CommandText = "update " + myTable +" set ClientName = :name , AddressLine1 = :addr1 , AddressLine2 = :addr2 "
                                            + ", Postcode = :pcode, City = :city, Telephone = :telephone, Mobile = :mobile, Email = :email "
                                            + "where ClientID = :clientID";
                    sqCommand.Parameters.Add("clientID", DbType.Int16).Value = ClientID;
                    sqCommand.Parameters.Add("name", DbType.String).Value = name;
                    sqCommand.Parameters.Add("addr1", DbType.String).Value = addr1;
                    sqCommand.Parameters.Add("addr2", DbType.String).Value = addr2;
                    sqCommand.Parameters.Add("pcode", DbType.String).Value = pcode;
                    sqCommand.Parameters.Add("city", DbType.String).Value = city;
                    sqCommand.Parameters.Add("telephone", DbType.String).Value = telephone;
                    sqCommand.Parameters.Add("mobile", DbType.String).Value = mobile;
                    sqCommand.Parameters.Add("email", DbType.String).Value = email;

                    conn.Open();
                    sqCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Update Successfully", myTable);
                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show("ErrorCode: " + sqlex.ErrorCode + "\n" + sqlex.Message, myTable);
            }
        }  // END OF UPDATE CHANGES TO CLIENT TABLE


        //edit current selected row (combobox selection)
        public void UpdateChangesInvoiceTable(string myConnString, string myTable, int InvoiceID, string ClientID, string Amount,
                                                string Description, string ProducedDate,
                                                bool Received, string ReceivedDate,
                                                bool Paid, string PaidDate)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(myConnString))
                {
                    SQLiteCommand sqCommand = conn.CreateCommand();
                    sqCommand.CommandText = "update " + myTable + " set ClientID = :id , InvoiceAmount = :amount , InvoiceDescription = :description "
                                            + ", ProducedDate = :produced, Received = :received, ReceivedDate = :receiveddate "
                                            + ", Paid = :paid, PaidDate = :paiddate "
                                            + "where InvoiceID = :invoiceID";
                    sqCommand.Parameters.Add("invoiceID", DbType.Int32).Value = InvoiceID;
                    sqCommand.Parameters.Add("id", DbType.Int32).Value = ClientID;
                    sqCommand.Parameters.Add("amount", DbType.Double).Value = Amount;
                    sqCommand.Parameters.Add("description", DbType.String).Value = Description;
                    sqCommand.Parameters.Add("produced", DbType.String).Value = ProducedDate;
                    sqCommand.Parameters.Add("received", DbType.String).Value = Received;
                    sqCommand.Parameters.Add("receiveddate", DbType.String).Value = ReceivedDate;
                    sqCommand.Parameters.Add("paid", DbType.String).Value = Paid;
                    sqCommand.Parameters.Add("paiddate", DbType.String).Value = PaidDate;

                    conn.Open();
                    sqCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Update Successfully", myTable);
                }
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show("ErrorCode: " + sqlex.ErrorCode + "\n" + sqlex.Message, myTable);
            }
        }  // END OF UPDATE CHANGES TO INVOICE TABLE
    }
}
