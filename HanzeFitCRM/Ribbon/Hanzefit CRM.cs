using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;

namespace HanzeFitCRM
{
    public partial class Hanzefit_CRM
    {
        private void Hanzefit_CRM_Load(object sender, RibbonUIEventArgs e)
        {
        }

        /// <summary>
        /// Deze class maakt een een table class en een klantenoverzicht class aan om de klanten gegevens weer te geven
        /// In de table class kunnen gegevens worden opgehaald uit de database en worden aangevult in de DataGridView
        /// De klantenOverzicht class bied een grafishe omgeving om deze gegevens weer te geven.
        /// </summary>
        /// <param name="sender"></param> standaard
        /// <param name="e"></param> standaard
        private void buttonOverzichtKlanten_Click(object sender, RibbonControlEventArgs e)
        {
            Klanten_overzicht klantenOverzicht = new Klanten_overzicht();
            TableClass table = new TableClass(klantenOverzicht.getDataGridView());
            //klantenOverzicht.SetTableClass();
            MessageBox.Show(klantenOverzicht.getDataGridView().ToString());
            table.setTable("Klant");
            klantenOverzicht.ShowDialog();
        }
    }
}
