namespace HanzeFitCRM
{
    partial class Hanzefit_CRM : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Hanzefit_CRM()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hanzefit_CRM));
            this.HanzefitCRMTab = this.Factory.CreateRibbonTab();
            this.groupOverzichten = this.Factory.CreateRibbonGroup();
            this.groupDownloaden = this.Factory.CreateRibbonGroup();
            this.buttonOverzichtKlanten = this.Factory.CreateRibbonButton();
            this.buttonOverzichtDiensten = this.Factory.CreateRibbonButton();
            this.buttonOverzichtGebruikers = this.Factory.CreateRibbonButton();
            this.buttonOverzichtStatistieken = this.Factory.CreateRibbonButton();
            this.buttonDownloadNieuwsBrieven = this.Factory.CreateRibbonButton();
            this.buttonOverzichtAfspraken = this.Factory.CreateRibbonButton();
            this.HanzefitCRMTab.SuspendLayout();
            this.groupOverzichten.SuspendLayout();
            this.groupDownloaden.SuspendLayout();
            // 
            // HanzefitCRMTab
            // 
            this.HanzefitCRMTab.Groups.Add(this.groupOverzichten);
            this.HanzefitCRMTab.Groups.Add(this.groupDownloaden);
            this.HanzefitCRMTab.Label = "Hanzefit CRM";
            this.HanzefitCRMTab.Name = "HanzefitCRMTab";
            // 
            // groupOverzichten
            // 
            this.groupOverzichten.Items.Add(this.buttonOverzichtKlanten);
            this.groupOverzichten.Items.Add(this.buttonOverzichtDiensten);
            this.groupOverzichten.Items.Add(this.buttonOverzichtGebruikers);
            this.groupOverzichten.Items.Add(this.buttonOverzichtStatistieken);
            this.groupOverzichten.Items.Add(this.buttonOverzichtAfspraken);
            this.groupOverzichten.Label = "Overzichten";
            this.groupOverzichten.Name = "groupOverzichten";
            // 
            // groupDownloaden
            // 
            this.groupDownloaden.Items.Add(this.buttonDownloadNieuwsBrieven);
            this.groupDownloaden.Label = "Downloaden";
            this.groupDownloaden.Name = "groupDownloaden";
            // 
            // buttonOverzichtKlanten
            // 
            this.buttonOverzichtKlanten.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonOverzichtKlanten.Description = "Dit is het overzicht waar alle klanten die een dienst hebben afgenomen worden wee" +
    "rgegeven.";
            this.buttonOverzichtKlanten.Label = "Klanten";
            this.buttonOverzichtKlanten.Name = "buttonOverzichtKlanten";
            this.buttonOverzichtKlanten.ShowImage = true;
            this.buttonOverzichtKlanten.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonOverzichtKlanten_Click);
            // 
            // buttonOverzichtDiensten
            // 
            this.buttonOverzichtDiensten.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonOverzichtDiensten.Description = "Dit zijn alle diensten die worden of waren gegeven door de Hanzefit";
            this.buttonOverzichtDiensten.Label = "Diensten";
            this.buttonOverzichtDiensten.Name = "buttonOverzichtDiensten";
            this.buttonOverzichtDiensten.ShowImage = true;
            // 
            // buttonOverzichtGebruikers
            // 
            this.buttonOverzichtGebruikers.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonOverzichtGebruikers.Description = "Dit zijn alle gebruikers van het CRM bestand, deze kunnen alleen voor de administ" +
    "ator worden gewijzigd of worden toegevoegd.";
            this.buttonOverzichtGebruikers.Label = "Gebruikers";
            this.buttonOverzichtGebruikers.Name = "buttonOverzichtGebruikers";
            this.buttonOverzichtGebruikers.ShowImage = true;
            // 
            // buttonOverzichtStatistieken
            // 
            this.buttonOverzichtStatistieken.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonOverzichtStatistieken.Description = "In dit overzicht worden de statitieken per diensten/dienstgroep weergegeven.";
            this.buttonOverzichtStatistieken.Label = "Statistieken";
            this.buttonOverzichtStatistieken.Name = "buttonOverzichtStatistieken";
            this.buttonOverzichtStatistieken.ShowImage = true;
            // 
            // buttonDownloadNieuwsBrieven
            // 
            this.buttonDownloadNieuwsBrieven.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonDownloadNieuwsBrieven.Label = "Nieuws brieven";
            this.buttonDownloadNieuwsBrieven.Name = "buttonDownloadNieuwsBrieven";
            this.buttonDownloadNieuwsBrieven.ShowImage = true;
            // 
            // buttonOverzichtAfspraken
            // 
            this.buttonOverzichtAfspraken.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonOverzichtAfspraken.Description = "Dit zijn alle afspraken die zijn gepland voor alle diensten die worden geleverd d" +
    "oor of via de HanzeFit.";
            this.buttonOverzichtAfspraken.Label = "Afspraken";
            this.buttonOverzichtAfspraken.Name = "buttonOverzichtAfspraken";
            this.buttonOverzichtAfspraken.ShowImage = true;
            // 
            // Hanzefit_CRM
            // 
            this.Name = "Hanzefit_CRM";
            this.RibbonType = resources.GetString("$this.RibbonType");
            this.Tabs.Add(this.HanzefitCRMTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Hanzefit_CRM_Load);
            this.HanzefitCRMTab.ResumeLayout(false);
            this.HanzefitCRMTab.PerformLayout();
            this.groupOverzichten.ResumeLayout(false);
            this.groupOverzichten.PerformLayout();
            this.groupDownloaden.ResumeLayout(false);
            this.groupDownloaden.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab HanzefitCRMTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupOverzichten;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonOverzichtKlanten;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonOverzichtDiensten;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonOverzichtGebruikers;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonOverzichtStatistieken;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupDownloaden;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonDownloadNieuwsBrieven;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonOverzichtAfspraken;
    }

    partial class ThisRibbonCollection
    {
        internal Hanzefit_CRM Hanzefit_CRM
        {
            get { return this.GetRibbon<Hanzefit_CRM>(); }
        }
    }
}
