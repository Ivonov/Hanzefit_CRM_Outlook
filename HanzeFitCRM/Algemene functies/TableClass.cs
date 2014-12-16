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
        private DataGridViewButtonColumn EditBtn = null;
        private DataGridViewButtonColumn DeleteBtn = null;

        #region constructor
            /// <summary>
            /// Hier word het object aangemaakt en word de referencie van de desbetreffende DataGridView doorgegeven.
            /// </summary>
            /// <param name="thisDataGrid">De referencie naar de desbetreffende DataGridView</param>
            public TableClass(System.Windows.Forms.DataGridView thisDataGrid)
            {
                this.thisDataGrid = thisDataGrid;
            }
        #endregion
        
        #region tablecheck //Hier word gekeken welke table gemaakt moet worden
            /// <summary>
            /// Aan de hand van de String word bekeken voor welk overzicht het tabel word opgesteld.
            /// Nader worden andere methodes aangeroept, die verantwoordelijk zijn voor het oproepen en
            /// weg zetten van de gegevens
            /// </summary>
            /// <param name="tableType"></param>
            public void setTable(String tableType)
            {
                switch (tableType)
                {
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
        #endregion
        
        #region getters //Hier worden de gegevens uit de database gehaald
            /// <summary>
            /// Deze methode roept de database aan en vraagt de kolomnamen van de desbetreffende tabel aan.
            /// Deze kolom titels worden terug gestuurd naar de buttonclick van de desbetreffende overzicht knop.
            /// </summary>
            /// <param name="query">Is een string opgesteld als een MySQL commando</param>
            private void getColumnNames(String query)
            {
                columnList = new List<String>();
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
                    finally
                    {
                        myConnection.Close();
                    }
                }
            }

            /// <summary>
            /// Deze methode is verantwoordelijk voor het ophalen en terugsturen van de data
            /// van de desbetreffende tabel.
            /// </summary>
            /// <param name="query">Dit is de query die word uitvoerd om de data te verschaffen</param>
            private void getDataforDataGridView(String query)
            {
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
                    finally
                    {
                        myConnection.Close();
                    }
                }
            }
        #endregion

        #region setters //Hier worden de gegevens van de database in de DataGridView gezet
            /// <summary>
            /// Hier worden de gegevens in de desbetreffende DataGridView gezet 
            /// </summary>
            private void setCollumsDataGridView()
            {
                thisDataGrid.ColumnCount = columnList.Count();
                for (int i = 0; i < columnList.Count(); ++i)
                {
                    thisDataGrid.Columns[i].Name = columnList[i].ToString();
                }
            }

            /// <summary>
            /// Hier worden alle data/regels toegevoegd aan de behoorde DataGridView
            /// </summary>
            private void setDataForDataGridView()
            {
                String buttonname;
                for (int i = 0; i < DataforDataGridView.Count; ++i)
                {
                    thisDataGrid.Rows.Add(DataforDataGridView[i].ToArray());

                    buttonname = DataforDataGridView[i][0];
                    MessageBox.Show(buttonname);

                    addEditButtons(buttonname, "Wijzigen");
                    addEditButtons(buttonname, "Verwijderen");
                }
                thisDataGrid.CellClick += new DataGridViewCellEventHandler(myDataGridView_CellContentClick);
            }
        #endregion

        #region buttons //Hier word de buttoncolumn gedefineerd
            /// <summary>
            /// Deze methode zorgt door het toevoegen van de knoppen in de desbetreffende overzicht
            /// </summary>
            private void addEditButtons(String buttonname, String buttonType)
            {
                if (thisDataGrid[thisDataGrid.ColumnCount - 1, 0].Value.ToString() != "Verwijderen") // Hier worden de buttoncolomn voor de buttons aangemaakt
                {
                    if (buttonType == "Wijzigen")
                    {
                        EditBtn = new DataGridViewButtonColumn();
                        thisDataGrid.Columns.Add(EditBtn);
                    }
                    else if (buttonType == "Verwijderen")
                    {
                        DeleteBtn = new DataGridViewButtonColumn();
                        thisDataGrid.Columns.Add(DeleteBtn);
                    }
                }

                if (buttonType == "Wijzigen") // Hier worden de knoppen zelf toevoegen aan de buttoncolomn
                {
                    EditBtn.Text = buttonType; //Lable
                    EditBtn.Name = buttonname; //Ref
                    EditBtn.UseColumnTextForButtonValue = true;
                }
                else if (buttonType == "Verwijderen")
                {
                    DeleteBtn.Text = buttonType; //Lable
                    DeleteBtn.Name = buttonname; //Ref
                    DeleteBtn.UseColumnTextForButtonValue = true;
                }
            }
        #endregion
        
        #region events //Hier worden de functies van de buttons gedefineerd
            /// <summary>
            /// Wanneer de hypelink word geklikt word er gecontroleerd welke colomn word geklikt.
            /// In dit geval word er op twee columns gecontroleerd, waaronder edit en delete, 
            /// welke voor zich spreken wat ze doen
            /// </summary>
            /// <param name="sender">Is het object die de handler aanspreekt</param>
            /// <param name="e">Is het DataGridView onhoud, waaronder de row en column click</param>
            private void myDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (thisDataGrid[e.ColumnIndex, 0].Value.ToString() == "Verwijderen") // Dit zou de laatste column van de overzicht (delete)
                {
                    deleteRowInDatabase(thisDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                else if (thisDataGrid[e.ColumnIndex, 0].Value.ToString() == "Wijzigen") // Dit zou de een na laatste column van de overzicht (wijzigen)  (e.ColumnIndex == thisDataGrid.ColumnCount - 2)
                {
                    editRowInDatabase(thisDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
                //else
                //{
                //    MessageBox.Show("#--Dit klopt niet helemaal met het klikken xD"); // Ter controle -----------------------------------------------------------!
                //}
            }

            /// <summary>
            /// Hier word de row uit de database verwijderd, de row word gezocht via de vierlettercode.
            /// </summary>
            /// <param name="vierLetterCode">Dit is de primaire key die word gebruikt om de juiste regel te vinden en nader te verwijderen</param>
            private void deleteRowInDatabase(String vierLetterCode)
            {
                //Hier komt code
                MessageBox.Show("#--> De row van " + vierLetterCode + " is geslecteerd, om verwijderd te worden."); //Ter controle -----------------------------!
            }

            /// <summary>
            /// Hier word de regel die geselecteerd is gewijzigd, door eerst een ander form aan te maken en daar de wijziging mogelijkheden te bieden.
            /// </summary>
            /// <param name="vierLetterCode">Dit is de primaire key die word gebruikt om de juiste regel te vinden en nader te wijzigen</param>
            private void editRowInDatabase(String vierLetterCode)
            {
                //Hier komt code
                MessageBox.Show("#--> De row van " + vierLetterCode + " is geslecteerd, om gewijzigd te worden."); //Ter controle -------------------------------!
            }
            
            /// <summary>
            /// Deze event word getriggert wanneer de enter toets word ingedrukt, indien enter is ingedruk word er een controle gedaan op
            /// de waarde in de zoek functie en word deze opgezoek in de database.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            public void myTextBoxOverzicht_Enter(object sender, EventArgs e) { MessageBox.Show("Enter is ingedrukt."); }
        #endregion
    }
}