using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace HanzeFitCRM
{
    class TableClass {
        private String query = null;

        /**
         * Deze methode ontvangt een String die aangeeft welke overzicht
         * moet worden weergegeven.
         * De attributen van deze overzicht worden hier opgevraagt en doorgegeven,
         * om nader deze in te voegen in een table.
         */
        public void setTable(String tableType) { 
            switch (tableType) {
                case "Klant":
                    query = "DESCRIBE `Klantenoverzicht`";
                    getCollumNames(query);
                    query = "SELECT * FROM `klantenoverzicht`";
                    fillTableInformation(query);
                    break;
                case "Dienst":
                    query = "SHOW COLUMNS FROM `Diensten`";
                    getCollumNames(query);
                    query = "SELECT * FROM `dienstoverzicht`";
                    fillTableInformation(query);
                    break;
                case "Gebruiker":
                    query = "SHOW COLUMNS FROM `Gebruiker`";
                    getCollumNames(query);
                    query = "SELECT * FROM `gebruikeroverzicht`";
                    fillTableInformation(query);
                    break;
                case "Statistiek":
                    query = "SHOW COLUMNS FROM `Statistieken`";
                    getCollumNames(query);
                    query = "SELECT * FROM Klantenoverzicht";
                    fillTableInformation(query);
                    break;
                case "Afspraak":
                    query = "SHOW COLUMNS FROM `Afspraken`";
                    getCollumNames(query);
                    query = "SELECT * FROM `afspraakoverzicht`";
                    fillTableInformation(query);
                    break;
            }
        }

        /**
         * In deze methode worden de attributen opgevraagd uit de database.
         */
        private void getCollumNames(String query) {
            if (query != null) {
                MySqlConnection myConnection = new MySqlConnection("user id=root; Server=localhost; Persist Security info=true; database=outlook;");
                List<String> test = new List<String>();
                MySqlDataReader result = null;
                try
                {
                    myConnection.Open();

                    MessageBox.Show(query);

                    MySqlCommand myCommand = new MySqlCommand(query, myConnection);

                    result = myCommand.ExecuteReader();

                    while (result.Read())
                    {
                        test.Add(result.GetString(0)); // Doet het, moet eerst wel in een String[] gegooit worden
                    }

                    StringBuilder builder = new StringBuilder();
                    foreach (String lol in test)
                    {
                        // Append each int to the StringBuilder overload.
                        builder.Append(lol).Append(" | ");
                    }

                    MessageBox.Show("#--Result toString: " + builder.ToString());
                }
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    MessageBox.Show("Connection has faild due to: " + sqlException.Message);
                }
                finally {
                    myConnection.Close();
                    fillTableCollumNames(result);
                }
            }
        }

        private void fillTableCollumNames(MySqlDataReader result) { 
            if(result != null){
                //MessageBox.Show("#--Result toString: " + result.GetValue(0).ToString()); //TODO moet nog vervangen worden door een table object ect
            }
        }
        private void fillTableInformation(String query)
        {
            if (query != null)
            {
                //TODO
            }
        }
    }
}
