namespace Karteikarten_Manager
{
    partial class ViewImport
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
            this.metroButtonOpenDialog = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxPath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.groupBoxImport = new System.Windows.Forms.GroupBox();
            this.groupBoxSafe = new System.Windows.Forms.GroupBox();
            this.metroButtonImport = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxS2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxS1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialogCSV = new System.Windows.Forms.OpenFileDialog();
            this.metroButtonBack = new MetroFramework.Controls.MetroButton();
            this.groupBoxImport.SuspendLayout();
            this.groupBoxSafe.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButtonOpenDialog
            // 
            this.metroButtonOpenDialog.Location = new System.Drawing.Point(12, 29);
            this.metroButtonOpenDialog.Name = "metroButtonOpenDialog";
            this.metroButtonOpenDialog.Size = new System.Drawing.Size(310, 23);
            this.metroButtonOpenDialog.TabIndex = 0;
            this.metroButtonOpenDialog.Text = "Datei öffnen";
            this.metroButtonOpenDialog.Click += new System.EventHandler(this.MetroButtonOpenDialog_Click);
            // 
            // metroTextBoxPath
            // 
            this.metroTextBoxPath.Location = new System.Drawing.Point(73, 58);
            this.metroTextBoxPath.Name = "metroTextBoxPath";
            this.metroTextBoxPath.ReadOnly = true;
            this.metroTextBoxPath.Size = new System.Drawing.Size(249, 23);
            this.metroTextBoxPath.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Pfad:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Name:";
            // 
            // metroTextBoxName
            // 
            this.metroTextBoxName.Location = new System.Drawing.Point(96, 29);
            this.metroTextBoxName.Name = "metroTextBoxName";
            this.metroTextBoxName.Size = new System.Drawing.Size(224, 23);
            this.metroTextBoxName.TabIndex = 3;
            // 
            // groupBoxImport
            // 
            this.groupBoxImport.Controls.Add(this.metroTextBoxPath);
            this.groupBoxImport.Controls.Add(this.metroButtonOpenDialog);
            this.groupBoxImport.Controls.Add(this.metroLabel1);
            this.groupBoxImport.Location = new System.Drawing.Point(13, 94);
            this.groupBoxImport.Name = "groupBoxImport";
            this.groupBoxImport.Size = new System.Drawing.Size(331, 100);
            this.groupBoxImport.TabIndex = 5;
            this.groupBoxImport.TabStop = false;
            this.groupBoxImport.Text = "CSV-Datei öffnen";
            // 
            // groupBoxSafe
            // 
            this.groupBoxSafe.Controls.Add(this.metroButtonImport);
            this.groupBoxSafe.Controls.Add(this.metroTextBoxS2);
            this.groupBoxSafe.Controls.Add(this.metroLabel4);
            this.groupBoxSafe.Controls.Add(this.metroTextBoxS1);
            this.groupBoxSafe.Controls.Add(this.metroLabel3);
            this.groupBoxSafe.Controls.Add(this.metroTextBoxName);
            this.groupBoxSafe.Controls.Add(this.metroLabel2);
            this.groupBoxSafe.Location = new System.Drawing.Point(13, 200);
            this.groupBoxSafe.Name = "groupBoxSafe";
            this.groupBoxSafe.Size = new System.Drawing.Size(331, 153);
            this.groupBoxSafe.TabIndex = 6;
            this.groupBoxSafe.TabStop = false;
            this.groupBoxSafe.Text = "Intern Speichern";
            // 
            // metroButtonImport
            // 
            this.metroButtonImport.Location = new System.Drawing.Point(12, 117);
            this.metroButtonImport.Name = "metroButtonImport";
            this.metroButtonImport.Size = new System.Drawing.Size(308, 23);
            this.metroButtonImport.TabIndex = 9;
            this.metroButtonImport.Text = "Importieren";
            this.metroButtonImport.Click += new System.EventHandler(this.MetroButtonImport_Click);
            // 
            // metroTextBoxS2
            // 
            this.metroTextBoxS2.Location = new System.Drawing.Point(110, 86);
            this.metroTextBoxS2.Name = "metroTextBoxS2";
            this.metroTextBoxS2.Size = new System.Drawing.Size(210, 23);
            this.metroTextBoxS2.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 89);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 20);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Sprache 2:";
            // 
            // metroTextBoxS1
            // 
            this.metroTextBoxS1.Location = new System.Drawing.Point(110, 59);
            this.metroTextBoxS1.Name = "metroTextBoxS1";
            this.metroTextBoxS1.Size = new System.Drawing.Size(210, 23);
            this.metroTextBoxS1.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Sprache 1:";
            // 
            // openFileDialogCSV
            // 
            this.openFileDialogCSV.FileName = "Vokabeln";
            this.openFileDialogCSV.Filter = "CSV Files|*.csv";
            // 
            // metroButtonBack
            // 
            this.metroButtonBack.Location = new System.Drawing.Point(13, 360);
            this.metroButtonBack.Name = "metroButtonBack";
            this.metroButtonBack.Size = new System.Drawing.Size(331, 23);
            this.metroButtonBack.TabIndex = 10;
            this.metroButtonBack.Text = "Zurück zur Auswahl";
            this.metroButtonBack.Click += new System.EventHandler(this.MetroButtonBack_Click);
            // 
            // ViewImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 395);
            this.Controls.Add(this.metroButtonBack);
            this.Controls.Add(this.groupBoxSafe);
            this.Controls.Add(this.groupBoxImport);
            this.MaximizeBox = false;
            this.Name = "ViewImport";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Importieren";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewImport_FormClosing);
            this.groupBoxImport.ResumeLayout(false);
            this.groupBoxImport.PerformLayout();
            this.groupBoxSafe.ResumeLayout(false);
            this.groupBoxSafe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonOpenDialog;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPath;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private System.Windows.Forms.GroupBox groupBoxImport;
        private System.Windows.Forms.GroupBox groupBoxSafe;
        private System.Windows.Forms.OpenFileDialog openFileDialogCSV;
        private MetroFramework.Controls.MetroTextBox metroTextBoxS1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxS2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButtonImport;
        private MetroFramework.Controls.MetroButton metroButtonBack;
    }
}