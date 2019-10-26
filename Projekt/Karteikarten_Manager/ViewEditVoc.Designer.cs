namespace Karteikarten_Manager
{
    partial class ViewEditVoc
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
            this.metroButtonBack = new MetroFramework.Controls.MetroButton();
            this.labelSprache1 = new System.Windows.Forms.Label();
            this.labelSprache2 = new System.Windows.Forms.Label();
            this.metroTextBoxVocInputS2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxVocInputS1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonAddVoc = new MetroFramework.Controls.MetroButton();
            this.listBoxVoc = new System.Windows.Forms.ListBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonChangeVoc = new MetroFramework.Controls.MetroButton();
            this.labelSprache1_1 = new System.Windows.Forms.Label();
            this.metroTextBoxEditVoc2 = new MetroFramework.Controls.MetroTextBox();
            this.labelSprache2_1 = new System.Windows.Forms.Label();
            this.metroTextBoxEditVoc1 = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButtonChangeLanguage = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelVoc = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButtonBack
            // 
            this.metroButtonBack.Location = new System.Drawing.Point(23, 441);
            this.metroButtonBack.Name = "metroButtonBack";
            this.metroButtonBack.Size = new System.Drawing.Size(611, 23);
            this.metroButtonBack.TabIndex = 11;
            this.metroButtonBack.Text = "Zurück zum Menü";
            this.metroButtonBack.Click += new System.EventHandler(this.MetroButtonBack_Click);
            // 
            // labelSprache1
            // 
            this.labelSprache1.AutoSize = true;
            this.labelSprache1.Location = new System.Drawing.Point(3, 14);
            this.labelSprache1.Name = "labelSprache1";
            this.labelSprache1.Size = new System.Drawing.Size(93, 17);
            this.labelSprache1.TabIndex = 15;
            this.labelSprache1.Text = "<Sprache 1:>";
            // 
            // labelSprache2
            // 
            this.labelSprache2.AutoSize = true;
            this.labelSprache2.Location = new System.Drawing.Point(3, 60);
            this.labelSprache2.Name = "labelSprache2";
            this.labelSprache2.Size = new System.Drawing.Size(93, 17);
            this.labelSprache2.TabIndex = 14;
            this.labelSprache2.Text = "<Sprache 2:>";
            // 
            // metroTextBoxVocInputS2
            // 
            this.metroTextBoxVocInputS2.Location = new System.Drawing.Point(3, 80);
            this.metroTextBoxVocInputS2.Name = "metroTextBoxVocInputS2";
            this.metroTextBoxVocInputS2.Size = new System.Drawing.Size(343, 23);
            this.metroTextBoxVocInputS2.TabIndex = 13;
            // 
            // metroTextBoxVocInputS1
            // 
            this.metroTextBoxVocInputS1.Location = new System.Drawing.Point(3, 34);
            this.metroTextBoxVocInputS1.Name = "metroTextBoxVocInputS1";
            this.metroTextBoxVocInputS1.Size = new System.Drawing.Size(343, 23);
            this.metroTextBoxVocInputS1.TabIndex = 12;
            // 
            // metroButtonAddVoc
            // 
            this.metroButtonAddVoc.Location = new System.Drawing.Point(3, 121);
            this.metroButtonAddVoc.Name = "metroButtonAddVoc";
            this.metroButtonAddVoc.Size = new System.Drawing.Size(343, 32);
            this.metroButtonAddVoc.TabIndex = 16;
            this.metroButtonAddVoc.Text = "Hinzufügen";
            this.metroButtonAddVoc.Click += new System.EventHandler(this.MetroButtonAddVoc_Click);
            // 
            // listBoxVoc
            // 
            this.listBoxVoc.FormattingEnabled = true;
            this.listBoxVoc.ItemHeight = 16;
            this.listBoxVoc.Location = new System.Drawing.Point(23, 79);
            this.listBoxVoc.Name = "listBoxVoc";
            this.listBoxVoc.Size = new System.Drawing.Size(236, 324);
            this.listBoxVoc.TabIndex = 17;
            this.listBoxVoc.SelectedIndexChanged += new System.EventHandler(this.ListBoxVoc_SelectedIndexChanged);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(6, 21);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(357, 324);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabControl1.TabIndex = 18;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButtonAddVoc);
            this.metroTabPage1.Controls.Add(this.labelSprache1);
            this.metroTabPage1.Controls.Add(this.metroTextBoxVocInputS2);
            this.metroTabPage1.Controls.Add(this.labelSprache2);
            this.metroTabPage1.Controls.Add(this.metroTextBoxVocInputS1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(349, 281);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Hinzufügen";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButtonDelVoc);
            this.metroTabPage2.Controls.Add(this.metroButtonChangeVoc);
            this.metroTabPage2.Controls.Add(this.labelSprache1_1);
            this.metroTabPage2.Controls.Add(this.metroTextBoxEditVoc2);
            this.metroTabPage2.Controls.Add(this.labelSprache2_1);
            this.metroTabPage2.Controls.Add(this.metroTextBoxEditVoc1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(349, 281);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Bearbeiten";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroButtonChangeVoc
            // 
            this.metroButtonChangeVoc.Location = new System.Drawing.Point(3, 122);
            this.metroButtonChangeVoc.Name = "metroButtonChangeVoc";
            this.metroButtonChangeVoc.Size = new System.Drawing.Size(343, 32);
            this.metroButtonChangeVoc.TabIndex = 21;
            this.metroButtonChangeVoc.Text = "Ändern";
            this.metroButtonChangeVoc.Click += new System.EventHandler(this.MetroButtonChangeVoc_Click);
            // 
            // labelSprache1_1
            // 
            this.labelSprache1_1.AutoSize = true;
            this.labelSprache1_1.Location = new System.Drawing.Point(3, 15);
            this.labelSprache1_1.Name = "labelSprache1_1";
            this.labelSprache1_1.Size = new System.Drawing.Size(93, 17);
            this.labelSprache1_1.TabIndex = 20;
            this.labelSprache1_1.Text = "<Sprache 1:>";
            // 
            // metroTextBoxEditVoc2
            // 
            this.metroTextBoxEditVoc2.Location = new System.Drawing.Point(3, 81);
            this.metroTextBoxEditVoc2.Name = "metroTextBoxEditVoc2";
            this.metroTextBoxEditVoc2.Size = new System.Drawing.Size(343, 23);
            this.metroTextBoxEditVoc2.TabIndex = 18;
            // 
            // labelSprache2_1
            // 
            this.labelSprache2_1.AutoSize = true;
            this.labelSprache2_1.Location = new System.Drawing.Point(3, 61);
            this.labelSprache2_1.Name = "labelSprache2_1";
            this.labelSprache2_1.Size = new System.Drawing.Size(93, 17);
            this.labelSprache2_1.TabIndex = 19;
            this.labelSprache2_1.Text = "<Sprache 2:>";
            // 
            // metroTextBoxEditVoc1
            // 
            this.metroTextBoxEditVoc1.Location = new System.Drawing.Point(3, 35);
            this.metroTextBoxEditVoc1.Name = "metroTextBoxEditVoc1";
            this.metroTextBoxEditVoc1.Size = new System.Drawing.Size(343, 23);
            this.metroTextBoxEditVoc1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroTabControl1);
            this.groupBox1.Location = new System.Drawing.Point(265, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 359);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // metroButtonChangeLanguage
            // 
            this.metroButtonChangeLanguage.Location = new System.Drawing.Point(23, 412);
            this.metroButtonChangeLanguage.Name = "metroButtonChangeLanguage";
            this.metroButtonChangeLanguage.Size = new System.Drawing.Size(236, 23);
            this.metroButtonChangeLanguage.TabIndex = 20;
            this.metroButtonChangeLanguage.Text = "Anzeigesprache wechseln";
            this.metroButtonChangeLanguage.Click += new System.EventHandler(this.MetroButtonChangeLanguage_Click);
            // 
            // metroButtonDelVoc
            // 
            this.metroButtonDelVoc.Location = new System.Drawing.Point(3, 160);
            this.metroButtonDelVoc.Name = "metroButtonDelVoc";
            this.metroButtonDelVoc.Size = new System.Drawing.Size(343, 32);
            this.metroButtonDelVoc.TabIndex = 21;
            this.metroButtonDelVoc.Text = "Löschen";
            this.metroButtonDelVoc.Click += new System.EventHandler(this.MetroButtonDelVoc_Click);
            // 
            // ViewEditVoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 475);
            this.Controls.Add(this.metroButtonChangeLanguage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxVoc);
            this.Controls.Add(this.metroButtonBack);
            this.Name = "ViewEditVoc";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Vokabeln hinzufügen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewEditVoc_FormClosing);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonBack;
        private System.Windows.Forms.Label labelSprache1;
        private System.Windows.Forms.Label labelSprache2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxVocInputS2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxVocInputS1;
        private MetroFramework.Controls.MetroButton metroButtonAddVoc;
        private System.Windows.Forms.ListBox listBoxVoc;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButtonChangeVoc;
        private System.Windows.Forms.Label labelSprache1_1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEditVoc2;
        private System.Windows.Forms.Label labelSprache2_1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEditVoc1;
        private MetroFramework.Controls.MetroButton metroButtonChangeLanguage;
        private MetroFramework.Controls.MetroButton metroButtonDelVoc;
    }
}