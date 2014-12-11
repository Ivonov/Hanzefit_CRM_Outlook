namespace HanzeFitCRM
{
    partial class Diensten_overzicht
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
            this.groupBoxDienstGroepen = new System.Windows.Forms.GroupBox();
            this.groupBoxDienstenOverzicht = new System.Windows.Forms.GroupBox();
            this.groupBoxDiensten = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxDienstToevoegen = new System.Windows.Forms.GroupBox();
            this.buttonDienstToevoegen = new System.Windows.Forms.Button();
            this.groupBoxDienstenOverzicht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxDienstToevoegen.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDienstGroepen
            // 
            this.groupBoxDienstGroepen.Location = new System.Drawing.Point(13, 13);
            this.groupBoxDienstGroepen.Name = "groupBoxDienstGroepen";
            this.groupBoxDienstGroepen.Size = new System.Drawing.Size(120, 163);
            this.groupBoxDienstGroepen.TabIndex = 0;
            this.groupBoxDienstGroepen.TabStop = false;
            this.groupBoxDienstGroepen.Text = "Dienst groepen:";
            // 
            // groupBoxDienstenOverzicht
            // 
            this.groupBoxDienstenOverzicht.Controls.Add(this.dataGridView1);
            this.groupBoxDienstenOverzicht.Location = new System.Drawing.Point(140, 13);
            this.groupBoxDienstenOverzicht.Name = "groupBoxDienstenOverzicht";
            this.groupBoxDienstenOverzicht.Size = new System.Drawing.Size(708, 393);
            this.groupBoxDienstenOverzicht.TabIndex = 1;
            this.groupBoxDienstenOverzicht.TabStop = false;
            this.groupBoxDienstenOverzicht.Text = "Diensten:";
            // 
            // groupBoxDiensten
            // 
            this.groupBoxDiensten.Location = new System.Drawing.Point(14, 182);
            this.groupBoxDiensten.Name = "groupBoxDiensten";
            this.groupBoxDiensten.Size = new System.Drawing.Size(120, 163);
            this.groupBoxDiensten.TabIndex = 1;
            this.groupBoxDiensten.TabStop = false;
            this.groupBoxDiensten.Text = "Diensten:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxDienstToevoegen
            // 
            this.groupBoxDienstToevoegen.Controls.Add(this.buttonDienstToevoegen);
            this.groupBoxDienstToevoegen.Location = new System.Drawing.Point(14, 352);
            this.groupBoxDienstToevoegen.Name = "groupBoxDienstToevoegen";
            this.groupBoxDienstToevoegen.Size = new System.Drawing.Size(123, 54);
            this.groupBoxDienstToevoegen.TabIndex = 2;
            this.groupBoxDienstToevoegen.TabStop = false;
            this.groupBoxDienstToevoegen.Text = "Dienst toevoegen:";
            // 
            // buttonDienstToevoegen
            // 
            this.buttonDienstToevoegen.AutoSize = true;
            this.buttonDienstToevoegen.Location = new System.Drawing.Point(6, 19);
            this.buttonDienstToevoegen.Name = "buttonDienstToevoegen";
            this.buttonDienstToevoegen.Size = new System.Drawing.Size(111, 29);
            this.buttonDienstToevoegen.TabIndex = 0;
            this.buttonDienstToevoegen.Text = "Toevoegen";
            this.buttonDienstToevoegen.UseVisualStyleBackColor = true;
            // 
            // Diensten_overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 418);
            this.Controls.Add(this.groupBoxDienstToevoegen);
            this.Controls.Add(this.groupBoxDiensten);
            this.Controls.Add(this.groupBoxDienstenOverzicht);
            this.Controls.Add(this.groupBoxDienstGroepen);
            this.Name = "Diensten_overzicht";
            this.Text = "Diensten overzicht";
            this.groupBoxDienstenOverzicht.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxDienstToevoegen.ResumeLayout(false);
            this.groupBoxDienstToevoegen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDienstGroepen;
        private System.Windows.Forms.GroupBox groupBoxDienstenOverzicht;
        private System.Windows.Forms.GroupBox groupBoxDiensten;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxDienstToevoegen;
        private System.Windows.Forms.Button buttonDienstToevoegen;
    }
}