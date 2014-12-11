using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace HanzeFitCRM
{
    public partial class Hanzefit_CRM
    {
        private void Hanzefit_CRM_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void buttonOverzichtKlanten_Click(object sender, RibbonControlEventArgs e)
        {
            TableClass table = new TableClass();
            table.setTable("Klant");
        }
    }
}
