﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace HanzeFitCRM
{
    public partial class ThisAddIn
    {
        //private MyUserControl myUserControl1;
        //private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Klanten_overzicht klant = new Klanten_overzicht();
            klant.ShowDialog();
            //myUserControl1 = new MyUserControl();
            //myCustomTaskPane = this.CustomTaskPanes.Add(myUserControl1, "My Task Pane");
            //myCustomTaskPane.Visible = true;
        }
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }
        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}