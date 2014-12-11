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
        private List<String> dataList = new List<String>();

        /**
         * Deze methode ontvangt een String die aangeeft welke overzicht
         * moet worden weergegeven.
         * De attributen van deze overzicht worden hier opgevraagt en doorgegeven,
         * om nader deze in te voegen in een table.
         */
        public void setTable(String tableType, System.Windows.Forms.DataGridView thisDataGrid)
        {
            switch (tableType) {
                case "Klant":
                    query = "DESCRIBE `Klanten overzicht`";
                    getCollumNames(query);
                    query = "SELECT * FROM `klanten overzicht`";
                    getDataforDataGridView(query);
                    break;
                case "Dienst":
                    query = "DESCRIBE `Diensten`";
                    getCollumNames(query);
                    query = "SELECT * FROM `dienst overzicht`";
                    getDataforDataGridView(query);
                    break;
                case "Gebruiker":
                    query = "DESCRIBE `Gebruiker`";
                    getCollumNames(query);
                    query = "SELECT * FROM `gebruiker overzicht`";
                    getDataforDataGridView(query);
                    break;
                case "Statistiek":
                    query = "DESCRIBE `Statistieken`";
                    getCollumNames(query);
                    query = "SELECT * FROM Klanten overzicht";
                    getDataforDataGridView(query);
                    break;
                case "Afspraak":
                    query = "DESCRIBE `Afspraken`";
                    getCollumNames(query);
                    query = "SELECT * FROM `afspraak overzicht`";
                    getDataforDataGridView(query);
                    break;
            }
        }

        /// <summary>
        /// Deze methode roept de database aan en vraagt de kolomnamen van de desbetreffende tabel aan.
        /// Deze kolom titels worden terug gestuurd naar de buttonclick van de desbetreffende overzicht knop.
        /// </summary>
        /// <param name="query">Is een string opgesteld als een MySQL commando</param>
        /// <returns name="collumList">Dit is een lijst van alle kolom titels</returns>
        private List<String> getCollumNames(String query)
        {
            List<String> collumList = new List<String>();
            if (query != null) {
                MySqlConnection myConnection = new MySqlConnection("user id=root; Server=localhost; Persist Security info=true; database=outlook;");
                MySqlDataReader result = null;
                try
                {
                    myConnection.Open();

                    MessageBox.Show(query);

                    MySqlCommand myCommand = new MySqlCommand(query, myConnection);

                    result = myCommand.ExecuteReader();

                    while (result.Read())
                    {
                        collumList.Add(result.GetString(0)); // Doet het, moet eerst wel in een String[] gegooit worden
                    }

                    /*
                    StringBuilder builder = new StringBuilder(); // dit is alleen voor het testen aanwezig
                    foreach (String lol in collumList)
                    {
                        // Append each int to the StringBuilder overload.
                        builder.Append(lol).Append(" | ");
                    }

                    MessageBox.Show("#--Result toString: " + builder.ToString());
                     */
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
            return collumList;
        }

        /// <summary>
        /// Deze methode is verantwoordelijk voor het ophalen en terugsturen van de data
        /// van de desbetreffende tabel.
        /// </summary>
        /// <param name="query">Dit is de query die word uitvoerd om de data te verschaffen</param>
        /// <returns name ="DataforDataGridView"> dit is een list van alle data die nader word weergegeven in een DataGridView</returns>
        private List<String> getDataforDataGridView(String query, int columnCount) {
            List<String> DataforDataGridView = new List<String>();

            if (query != null)
            {
                MySqlConnection myConnection = new MySqlConnection("user id=root; Server=localhost; Persist Security info=true; database=outlook;");
                MySqlDataReader result = null;
                try
                {
                    myConnection.Open();

                    MessageBox.Show(query);

                    MySqlCommand myCommand = new MySqlCommand(query, myConnection);

                    result = myCommand.ExecuteReader();

                    while (result.Read())
                    {
                        for (int i = 0; i < columnCount; i++ ) {
                            DataforDataGridView.Add(result.GetString(i));
                        }
                    }
                } 
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    MessageBox.Show("Connection has faild due to: " + sqlException.Message);
                }
            }
            return DataforDataGridView;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thisDataGrid"></param>
        private void setCollumsDataGridView(System.Windows.Forms.DataGridView thisDataGrid)
        {
            thisDataGrid.ColumnCount = 3;
            thisDataGrid.Columns[0].Name = "Product ID";
            thisDataGrid.Columns[1].Name = "Product Name";
            thisDataGrid.Columns[2].Name = "Product Price";
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
