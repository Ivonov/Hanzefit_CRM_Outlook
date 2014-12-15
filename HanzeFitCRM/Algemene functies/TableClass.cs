using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Collections;
using System.Drawing;

namespace HanzeFitCRM
{
    /// <summary>
    /// Deze klasse is verantwoordelijk voor de functionaliteit van de overzichten.
    /// Per overzicht die word aangemaakt word er een TableClass aangemaakt.
    /// </summary>
    class TableClass {
        private System.Windows.Forms.DataGridView thisDataGrid;
        private List<String> columnList;
        private Dictionary<int, List<String>> DataforDataGridView;
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
            setCollumsDataGridView();
            setDataForDataGridView();
        }

        /// <summary>
        /// Deze methode roept de database aan en vraagt de kolomnamen van de desbetreffende tabel aan.
        /// Deze kolom titels worden terug gestuurd naar de buttonclick van de desbetreffende overzicht knop.
        /// </summary>
        /// <param name="query">Is een string opgesteld als een MySQL commando</param>
        private void getColumnNames(String query)
        {
            columnList = new List<String>();
            if (query != null) {
                MySqlConnection myConnection = new MySqlConnection("user id=root; Server=localhost; Persist Security info=true; database=outlook;");
                MySqlDataReader result = null;
                try
                {
                    myConnection.Open();

                    MessageBox.Show(query); // ter controle -------------------------------------------------------------------------------------------------!

                    MySqlCommand myCommand = new MySqlCommand(query, myConnection);

                    result = myCommand.ExecuteReader();

                    while (result.Read())
                    {
                        columnList.Add(result.GetString(0)); // Doet het, moet eerst wel in een String[] gegooit worden
                    }

                    /*
                    StringBuilder builder = new StringBuilder(); // ter controle ----------------------------------------------------------------------------!
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
        private void getDataforDataGridView(String query) {
            DataforDataGridView = new Dictionary<int, List<String>>();
            rowData = new List<String>();

            if (query != null)
            {
                MySqlConnection myConnection = new MySqlConnection("user id=root; Server=localhost; Persist Security info=true; database=outlook;");
                MySqlDataReader result = null;
                try
                {
                    myConnection.Open();

                    MessageBox.Show(query); // ter controle -------------------------------------------------------------------------------------------------!

                    MySqlCommand myCommand = new MySqlCommand(query, myConnection);

                    result = myCommand.ExecuteReader();

                    int counter = 0;
                    while (result.Read())
                    {
                        for (int i = 0; i < columnList.Count; ++i)
                        {
                            if (counter != 0 && i > 0) { result.Read(); }
                            rowData.Add(result.GetString(i));
                            //DataforDataGridView.Add(counter, result.GetString(i));
                        }
                        DataforDataGridView.Add(counter, rowData.ToList<String>());
                        rowData.Clear();
                        ++counter;
                    }
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
        /// Hier worden de gegevens in de desbetreffende DataGridView gezet 
        /// </summary>
        private void setCollumsDataGridView()
        {
            thisDataGrid.ColumnCount = columnList.Count();
            for (int i = 0; i < columnList.Count(); ++i ) {
                thisDataGrid.Columns[i].Name = columnList[i].ToString();
            }
        }

        /// <summary>
        /// Hier worden alle data/regels toegevoegd aan de behoorde DataGridView
        /// </summary>
        private void setDataForDataGridView() {
            String buttonname;
            DataGridViewLinkColumn btn = null; 
            for (int i = 0; i < DataforDataGridView.Count; ++i)
            {
                thisDataGrid.Rows.Add(DataforDataGridView[i].ToArray());

                buttonname = DataforDataGridView[i][0];
                MessageBox.Show(buttonname);

                if (btn == null) 
                {
                    btn = new DataGridViewLinkColumn();
                    thisDataGrid.Columns.Add(btn);
                    btn.HeaderText = ""; // Dit is de title boven in de column
                }
                btn.Text = buttonname; // Dit is de lable van de button
                btn.Name = buttonname; // Dit is de referencie naar de button
                btn.LinkColor = Color.Blue;
                btn.LinkBehavior = LinkBehavior.SystemDefault;
                btn.UseColumnTextForLinkValue = true;
                
            }
        }

        /// <summary>
        /// Wanneer de hypelink word geklikt word er gecontroleerd welke colomn word geklikt.
        /// In dit geval word er op twee columns gecontroleerd, waaronder edit en delete, 
        /// welke voor zich spreken wat ze doen
        /// </summary>
        /// <param name="sender">Is het object die de handler aanspreekt</param>
        /// <param name="e">Is het DataGridView onhoud, waaronder de row en column click</param>
        private void myDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == thisDataGrid.ColumnCount-1) // Dit zou de laatste column van de overzicht (delete)
            {
                String test = thisDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if (e.ColumnIndex == thisDataGrid.ColumnCount - 2) // Dit zou de een na laatste column van de overzicht (wijzigen)
            {

            }
            else 
            {
                MessageBox.Show("#--Dit klopt niet helemaal xD"); // Ter controle ---------------------------------------------------------------------!
            }
        }

        /// <summary>
        /// Hier word de row uit de database verwijderd, de row word gezocht via de vierlettercode.
        /// </summary>
        /// <param name="vierLetterCode">Dit is de primaire key die word gebruikt om de juiste regel te vinden en nader te verwijderen</param>
        private void deleteRowInDatabase(String vierLetterCode) 
        { 
            //Hier komt code
            MessageBox.Show("#--> De row van " + vierLetterCode + " is geslecteerd, om verwijderd te worden." );
        }

        /// <summary>
        /// Hier word de regel die geselecteerd is gewijzigd, door eerst een ander form aan te maken en daar de wijziging mogelijkheden te bieden.
        /// </summary>
        /// <param name="vierLetterCode">Dit is de primaire key die word gebruikt om de juiste regel te vinden en nader te wijzigen</param>
        private void editRowInDatabase(String vierLetterCode) 
        { 
            //Hier komt code
            MessageBox.Show("#--> De row van " + vierLetterCode + " is geslecteerd, om gewijzigd te worden.");
        }
    }
}