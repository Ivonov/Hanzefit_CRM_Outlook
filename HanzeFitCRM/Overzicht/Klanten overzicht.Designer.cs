namespace HanzeFitCRM
{
    partial class Klanten_overzicht
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxZoeken = new System.Windows.Forms.GroupBox();
            this.textBoxKlantenOverzicht = new System.Windows.Forms.TextBox();
            this.groupBoxKlantenOverzicht = new System.Windows.Forms.GroupBox();
            this.dataGridViewKlanten = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxZoeken.SuspendLayout();
            this.groupBoxKlantenOverzicht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlanten)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxZoeken
            // 
            this.groupBoxZoeken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxZoeken.Controls.Add(this.textBoxKlantenOverzicht);
            this.groupBoxZoeken.Location = new System.Drawing.Point(13, 13);
            this.groupBoxZoeken.Name = "groupBoxZoeken";
            this.groupBoxZoeken.Size = new System.Drawing.Size(120, 55);
            this.groupBoxZoeken.TabIndex = 0;
            this.groupBoxZoeken.TabStop = false;
            this.groupBoxZoeken.Text = "Zoeken:";
            // 
            // textBoxKlantenOverzicht
            // 
            this.textBoxKlantenOverzicht.Location = new System.Drawing.Point(7, 20);
            this.textBoxKlantenOverzicht.Name = "textBoxKlantenOverzicht";
            this.textBoxKlantenOverzicht.Size = new System.Drawing.Size(107, 20);
            this.textBoxKlantenOverzicht.TabIndex = 0;
            this.textBoxKlantenOverzicht.Enter += new System.EventHandler(AlgemeneFunctiesObject.myTextBoxOverzicht_Enter);
            // 
            // groupBoxKlantenOverzicht
            // 
            this.groupBoxKlantenOverzicht.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxKlantenOverzicht.Controls.Add(this.dataGridViewKlanten);
            this.groupBoxKlantenOverzicht.Location = new System.Drawing.Point(140, 13);
            this.groupBoxKlantenOverzicht.Name = "groupBoxKlantenOverzicht";
            this.groupBoxKlantenOverzicht.Size = new System.Drawing.Size(708, 393);
            this.groupBoxKlantenOverzicht.TabIndex = 1;
            this.groupBoxKlantenOverzicht.TabStop = false;
            this.groupBoxKlantenOverzicht.Text = "Klanten:";
            // 
            // dataGridViewKlanten
            // 
            this.dataGridViewKlanten.AllowUserToAddRows = false;
            this.dataGridViewKlanten.AllowUserToDeleteRows = false;
            this.dataGridViewKlanten.AllowUserToOrderColumns = true;
            this.dataGridViewKlanten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKlanten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlanten.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewKlanten.Name = "dataGridViewKlanten";
            this.dataGridViewKlanten.Size = new System.Drawing.Size(702, 374);
            this.dataGridViewKlanten.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(7, 20);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(107, 64);
            this.checkedListBox1.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox.Controls.Add(this.checkedListBox1);
            this.groupBox.Location = new System.Drawing.Point(13, 74);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(120, 102);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Functies:";
            // 
            // Klanten_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 418);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBoxKlantenOverzicht);
            this.Controls.Add(this.groupBoxZoeken);
            this.Name = "Klanten_overzicht";
            this.Text = "Klanten overzicht";
            this.groupBoxZoeken.ResumeLayout(false);
            this.groupBoxZoeken.PerformLayout();
            this.groupBoxKlantenOverzicht.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlanten)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxZoeken;
        private System.Windows.Forms.GroupBox groupBoxKlantenOverzicht;
        private System.Windows.Forms.DataGridView dataGridViewKlanten;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBoxKlantenOverzicht;

        public System.Windows.Forms.DataGridView getDataGridView()
        {
            return dataGridViewKlanten;
        }
    }
}