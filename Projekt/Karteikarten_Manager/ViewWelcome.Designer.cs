namespace Karteikarten_Manager
{
    partial class ViewWelcome
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
            this.metroButtonImport = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonStart = new MetroFramework.Controls.MetroButton();
            this.metroComboBoxSelection = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButtonImport
            // 
            this.metroButtonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonImport.Location = new System.Drawing.Point(119, 384);
            this.metroButtonImport.Name = "metroButtonImport";
            this.metroButtonImport.Size = new System.Drawing.Size(209, 23);
            this.metroButtonImport.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonImport.TabIndex = 0;
            this.metroButtonImport.Text = "Importieren";
            this.metroButtonImport.Click += new System.EventHandler(this.MetroButtonImport_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButtonDelete.Location = new System.Drawing.Point(23, 384);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(90, 23);
            this.metroButtonDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonDelete.TabIndex = 2;
            this.metroButtonDelete.Text = "Löschen";
            // 
            // metroButtonStart
            // 
            this.metroButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonStart.Location = new System.Drawing.Point(23, 413);
            this.metroButtonStart.Name = "metroButtonStart";
            this.metroButtonStart.Size = new System.Drawing.Size(305, 23);
            this.metroButtonStart.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButtonStart.TabIndex = 3;
            this.metroButtonStart.Text = "Starten";
            // 
            // metroComboBoxSelection
            // 
            this.metroComboBoxSelection.FormattingEnabled = true;
            this.metroComboBoxSelection.ItemHeight = 24;
            this.metroComboBoxSelection.Location = new System.Drawing.Point(23, 348);
            this.metroComboBoxSelection.Name = "metroComboBoxSelection";
            this.metroComboBoxSelection.Size = new System.Drawing.Size(305, 30);
            this.metroComboBoxSelection.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 320);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(158, 20);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Vokabelbestand wählen:";
            // 
            // ViewWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBoxSelection);
            this.Controls.Add(this.metroButtonStart);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroButtonImport);
            this.MaximizeBox = false;
            this.Name = "ViewWelcome";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Wilkommen";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonImport;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroButton metroButtonStart;
        private MetroFramework.Controls.MetroComboBox metroComboBoxSelection;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}