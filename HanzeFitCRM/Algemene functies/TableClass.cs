using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Collections;

namespace HanzeFitCRM
{
    /// <summary>
    /// Deze klasse is verantwoordelijk voor de functionaliteit van de overzichten.
    /// Per overzicht die word aangemaakt word er een TableClass aangemaakt.
    /// </summary>
    class TableClass {
        private System.Windows.Forms.DataGridView thisDataGrid;
        private List<String> columnList;
        private Hashtable DataforDataGridView;
        private List<String> rowData;
        private String query = null;
        private List<String> dataList = new List<String>();

        /// <summary>
        /// Hier word het object aangemaakt en word de referencie van de desbetreffende DataGridView doorgegeven.
        /// </summary>
        /// <param name="thisDataGrid">De referencie naar de desbetreffende DataGridView</param>
        public TableClass(System.Windows.Forms.DataGridView thisDataGrid) 
        { 
            this.thisDataGrid = thisDataGrid; 
        }

        /// <summary>
        /// Aan de hand van de String word bekeken voor welk overzicht het tabel word opgesteld.
        /// Nader worden andere methodes aangeroept, die verantwoordelijk zijn voor het oproepen en
        /// weg zetten van de gegevens
        /// </summary>
        /// <param name="tableType"></param>
        /// <param name="thisDataGrid"></param>
        public void setTable(String tableType)
        {            
            switch (tableType) {
                case "Klant":
                    query = "DESCRIBE `Klanten overzicht`";
                    getColumnNames(query);
                    query = "SELECT * FROM `klanten overzicht`";
                    getDataforDataGridView(query);
                    break;
                case "Dienst":
                    query = "DESCRIBE `Diensten`";
                    getColumnNames(query);
                    query = "SELECT * FROM `dienst overzicht`";
                    getDataforDataGridView(query);
                    break;
                case "Gebruiker":
                    query = "DESCRIBE `Gebruiker`";
                    getColumnNames(query);
                    query = "SELECT * FROM `gebruiker overzicht`";
                    getDataforDataGridView(query);
                    break;
                case "Statistiek":
                    query = "DESCRIBE `Statistieken`";
                    getColumnNames(query);
                    query = "SELECT * FROM Klanten overzicht";
                    getDataforDataGridView(query);
                    break;
                case "Afspraak":
                    query = "DESCRIBE `Afspraken`";
                    getColumnNames(query);
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
        private void getColumnNames(String query)
        {
            columnList = new List<String>();
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
                        columnList.Add(result.GetString(0)); // Doet het, moet eerst wel in een String[] gegooit worden
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
                }
            }
        }

        /// <summary>
        /// Deze methode is verantwoordelijk voor het ophalen en terugsturen van de data
        /// van de desbetreffende tabel.
        /// </summary>
        /// <param name="query">Dit is de query die word uitvoerd om de data te verschaffen</param>
        /// <returns name ="DataforDataGridView"> dit is een list van alle data die nader word weergegeven in een DataGridView</returns>
        private void getDataforDataGridView(String query) {
            DataforDataGridView = new Hashtable();
            rowData = new List<String>();

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

                    int counter = 0;
                    while (result.Read())
                    {
                        for (int i = 0; i < columnList.Count; i++)
                        {
                            DataforDataGridView.Add(columnList[counter], result.GetString(i));
                        }
                        ++counter;
                    }
                } 
                catch (System.Data.SqlClient.SqlException sqlException)
                {
                    MessageBox.Show("Connection has faild due to: " + sqlException.Message);
                }
            }
        }

        /// <summary>
        /// Hier worden de gegevens in de desbetreffende DataGridView gezet 
        /// </summary>
        /// <param name="thisDataGrid">De referencie naar de desbetreffende DataGridView.</param>
        private void setCollumsDataGridView(System.Windows.Forms.DataGridView thisDataGrid)
        {
        }

        /// <summary>
        /// Hier worden alle data/regels toegevoegd aan de behoorde DataGridView
        /// </summary>
        private void setDataForDataGridView() { 
            
        }
    }
}
