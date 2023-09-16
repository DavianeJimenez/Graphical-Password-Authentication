using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CIS474_Project
{
    internal class SQLStuff
    {
        private String connection;
       // public static String Connection = "datasource=localhost;port=3307;username=root;password=root;database=userinfo";
        public SQLStuff()
        { 
            Connection = "Server=localhost; Port=3306; Uid=root; Pwd = ExamplePassword1!; Database=userinfo";
        }

        public string Connection { get => connection; set => connection = value; }

        public void InsertData(String username, String email, String password, String passimage, int xVal, int yVal)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(Connection);

                String Query = "INSERT INTO UserInfo(  Username, Email, Pass, PassPhoto, xVal, yVal  )" +
                                "VALUES ('" + username + "','" + email + "','" + password + "','" + passimage + "','" + xVal + "','" + yVal + "');";

                MySqlCommand myCommand = new MySqlCommand(Query, myConnection);
                MySqlDataReader myDataReader;

                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();

                while (myDataReader.Read())
                {

                }
                myConnection.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        public bool UniqueUsername(String username)
        {
            bool unique = false;

            try
            {
                MySqlConnection myConnection = new MySqlConnection(Connection);
                String Query = "SELECT Username FROM UserInfo " +
                               "WHERE Username = '" + username + "';";

                MySqlCommand myCommand = new MySqlCommand(Query, myConnection);

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myCommand;
                DataTable myTable = new DataTable();

                myAdapter.Fill(myTable);

                if (myTable.Rows.Count == 0)
                {
                    unique = true;
                }
                else
                {
                    unique = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return unique;
        }

        public bool UniqueEmail(String email)
        {
            bool unique = false;

            try
            {
                MySqlConnection myConnection = new MySqlConnection(Connection);
                String Query = "SELECT Email FROM UserInfo " +
                               "WHERE Email = '" + email + "';";

                MySqlCommand myCommand = new MySqlCommand(Query, myConnection);

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myCommand;
                DataTable myTable = new DataTable();

                myAdapter.Fill(myTable);

                if (myTable.Rows.Count == 0)
                {
                    unique = true;
                }
                else
                {
                    unique = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return unique;
        }

        public bool CheckLogin(String username, String email, String password)
        {
            bool valid = false;

            try
            {
                MySqlConnection myConnection = new MySqlConnection(Connection);
                String Query = "SELECT Username, Email, Pass FROM UserInfo " +
                               "WHERE Username = '" + username + "' AND Email = '" + email + "' AND Pass = '" + password + "';";


                MySqlCommand myCommand = new MySqlCommand(Query, myConnection);

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myCommand;
                DataTable myTable = new DataTable();

                myAdapter.Fill(myTable);

                if (myTable.Rows.Count == 0)
                {
                    valid = false;
                }
                else
                {
                    valid = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return valid;
        }

        public bool CheckPassImage(String imageID, String email)
        {
            bool valid = false;

            try
            {
                MySqlConnection myConnection = new MySqlConnection(Connection);
                String Query = "SELECT PassPhoto FROM UserInfo " +
                               "WHERE Email = '" + email + "' AND PassPhoto = '" + imageID + "';";


                MySqlCommand myCommand = new MySqlCommand(Query, myConnection);

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myCommand;
                DataTable myTable = new DataTable();

                myAdapter.Fill(myTable);

                if (myTable.Rows.Count == 0)
                {
                    valid = false;
                }
                else
                {
                    valid = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return valid;
        }

        public int GetXPoint(String email)
        {
            int xVal = 0;

            try
            {
                MySqlConnection myConnection = new MySqlConnection(Connection);
                String Query = "SELECT xVal FROM UserInfo WHERE Email = '" + email + "';";

                MySqlCommand myCommand = new MySqlCommand(Query, myConnection);

                myConnection.Open();
                
                xVal = (int)myCommand.ExecuteScalar();

                myConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return xVal;
        }
        public int GetYPoint(String email)
        {
            int yVal = 0;

            try
            {
                MySqlConnection myConnection = new MySqlConnection(Connection);
                String Query = "SELECT yVal FROM UserInfo " +
                               "WHERE Email = '" + email + "';";

                MySqlCommand myCommand = new MySqlCommand(Query, myConnection);

                myConnection.Open();

                yVal = (int)myCommand.ExecuteScalar();

                myConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return yVal;
        }
    }
}
