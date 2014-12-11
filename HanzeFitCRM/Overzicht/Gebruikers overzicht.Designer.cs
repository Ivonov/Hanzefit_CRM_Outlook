namespace HanzeFitCRM
{
    partial class Gebruikers_overzicht
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
            this.groupBoxGebruikersOverzicht = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGebruikerToevoegen = new System.Windows.Forms.Button();
            this.groupBoxGebruikersOverzicht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGebruikersOverzicht
            // 
            this.groupBoxGebruikersOverzicht.Controls.Add(this.dataGridView1);
            this.groupBoxGebruikersOverzicht.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGebruikersOverzicht.Name = "groupBoxGebruikersOverzicht";
            this.groupBoxGebruikersOverzicht.Size = new System.Drawing.Size(836, 359);
            this.groupBoxGebruikersOverzicht.TabIndex = 0;
            this.groupBoxGebruikersOverzicht.TabStop = false;
            this.groupBoxGebruikersOverzicht.Text = "Gebruikers:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGebruikerToevoegen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 41);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // buttonGebruikerToevoegen
            // 
            this.buttonGebruikerToevoegen.Location = new System.Drawing.Point(773, 12);
            this.buttonGebruikerToevoegen.Name = "buttonGebruikerToevoegen";
            this.buttonGebruikerToevoegen.Size = new System.Drawing.Size(75, 23);
            this.buttonGebruikerToevoegen.TabIndex = 0;
            this.buttonGebruikerToevoegen.Text = "Toevoegen";
            this.buttonGebruikerToevoegen.UseVisualStyleBackColor = true;
            // 
            // Gebruikers_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxGebruikersOverzicht);
            this.Name = "Gebruikers_overzicht";
            this.Text = "Gebruikers overzicht";
            this.groupBoxGebruikersOverzicht.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGebruikersOverzicht;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGebruikerToevoegen;
    }
}