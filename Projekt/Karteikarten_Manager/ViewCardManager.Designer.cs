﻿namespace Karteikarten_Manager
{
    partial class ViewCardManager
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
            this.metroButtonCheck = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxVocInput = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelStatus = new MetroFramework.Controls.MetroLabel();
            this.metroButtonBackToMenu = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxOutput = new MetroFramework.Controls.MetroTextBox();
            this.labelSprache2 = new System.Windows.Forms.Label();
            this.labelSprache1 = new System.Windows.Forms.Label();
            this.GroupBoxCheckStatus = new System.Windows.Forms.GroupBox();
            this.labelKastenText = new System.Windows.Forms.Label();
            this.labelKasten = new System.Windows.Forms.Label();
            this.metroButtonPreBox = new MetroFramework.Controls.MetroButton();
            this.metroButtonNextBox = new MetroFramework.Controls.MetroButton();
            this.labelBestand = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            this.panelFinishedVoc = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GroupBoxCheckStatus.SuspendLayout();
            this.panelFinishedVoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButtonCheck
            // 
            this.metroButtonCheck.Location = new System.Drawing.Point(400, 187);
            this.metroButtonCheck.Name = "metroButtonCheck";
            this.metroButtonCheck.Size = new System.Drawing.Size(187, 78);
            this.metroButtonCheck.TabIndex = 5;
            this.metroButtonCheck.Text = "Check";
            this.metroButtonCheck.Click += new System.EventHandler(this.MetroButtonCheck_Click);
            // 
            // metroTextBoxVocInput
            // 
            this.metroTextBoxVocInput.Location = new System.Drawing.Point(18, 127);
            this.metroTextBoxVocInput.Name = "metroTextBoxVocInput";
            this.metroTextBoxVocInput.Size = new System.Drawing.Size(280, 23);
            this.metroTextBoxVocInput.TabIndex = 2;
            // 
            // metroLabelStatus
            // 
            this.metroLabelStatus.AutoSize = true;
            this.metroLabelStatus.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelStatus.Location = new System.Drawing.Point(8, 28);
            this.metroLabelStatus.Name = "metroLabelStatus";
            this.metroLabelStatus.Size = new System.Drawing.Size(49, 17);
            this.metroLabelStatus.TabIndex = 7;
            this.metroLabelStatus.Text = "Richtig!";
            // 
            // metroButtonBackToMenu
            // 
            this.metroButtonBackToMenu.Location = new System.Drawing.Point(18, 329);
            this.metroButtonBackToMenu.Name = "metroButtonBackToMenu";
            this.metroButtonBackToMenu.Size = new System.Drawing.Size(569, 23);
            this.metroButtonBackToMenu.TabIndex = 8;
            this.metroButtonBackToMenu.Text = "Zurück zum Menü";
            this.metroButtonBackToMenu.Click += new System.EventHandler(this.MetroButtonBackToMenu_Click);
            // 
            // metroTextBoxOutput
            // 
            this.metroTextBoxOutput.Location = new System.Drawing.Point(307, 127);
            this.metroTextBoxOutput.Name = "metroTextBoxOutput";
            this.metroTextBoxOutput.ReadOnly = true;
            this.metroTextBoxOutput.Size = new System.Drawing.Size(280, 23);
            this.metroTextBoxOutput.TabIndex = 9;
            // 
            // labelSprache2
            // 
            this.labelSprache2.AutoSize = true;
            this.labelSprache2.Location = new System.Drawing.Point(308, 107);
            this.labelSprache2.Name = "labelSprache2";
            this.labelSprache2.Size = new System.Drawing.Size(89, 17);
            this.labelSprache2.TabIndex = 10;
            this.labelSprache2.Text = "<Sprache2:>";
            // 
            // labelSprache1
            // 
            this.labelSprache1.AutoSize = true;
            this.labelSprache1.Location = new System.Drawing.Point(15, 107);
            this.labelSprache1.Name = "labelSprache1";
            this.labelSprache1.Size = new System.Drawing.Size(89, 17);
            this.labelSprache1.TabIndex = 11;
            this.labelSprache1.Text = "<Sprache1>:";
            // 
            // GroupBoxCheckStatus
            // 
            this.GroupBoxCheckStatus.Controls.Add(this.metroLabelStatus);
            this.GroupBoxCheckStatus.Location = new System.Drawing.Point(18, 195);
            this.GroupBoxCheckStatus.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxCheckStatus.Name = "GroupBoxCheckStatus";
            this.GroupBoxCheckStatus.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxCheckStatus.Size = new System.Drawing.Size(375, 69);
            this.GroupBoxCheckStatus.TabIndex = 16;
            this.GroupBoxCheckStatus.TabStop = false;
            this.GroupBoxCheckStatus.Text = "Status";
            // 
            // labelKastenText
            // 
            this.labelKastenText.AutoSize = true;
            this.labelKastenText.Location = new System.Drawing.Point(503, 71);
            this.labelKastenText.Name = "labelKastenText";
            this.labelKastenText.Size = new System.Drawing.Size(60, 17);
            this.labelKastenText.TabIndex = 17;
            this.labelKastenText.Text = "Kasten: ";
            // 
            // labelKasten
            // 
            this.labelKasten.AutoSize = true;
            this.labelKasten.Location = new System.Drawing.Point(569, 71);
            this.labelKasten.Name = "labelKasten";
            this.labelKasten.Size = new System.Drawing.Size(16, 17);
            this.labelKasten.TabIndex = 18;
            this.labelKasten.Text = "1";
            // 
            // metroButtonPreBox
            // 
            this.metroButtonPreBox.Location = new System.Drawing.Point(18, 271);
            this.metroButtonPreBox.Name = "metroButtonPreBox";
            this.metroButtonPreBox.Size = new System.Drawing.Size(280, 52);
            this.metroButtonPreBox.TabIndex = 19;
            this.metroButtonPreBox.Text = "<- Vorheriger Kasten";
            this.metroButtonPreBox.Click += new System.EventHandler(this.MetroButtonPreBox_Click);
            // 
            // metroButtonNextBox
            // 
            this.metroButtonNextBox.Location = new System.Drawing.Point(307, 271);
            this.metroButtonNextBox.Name = "metroButtonNextBox";
            this.metroButtonNextBox.Size = new System.Drawing.Size(280, 52);
            this.metroButtonNextBox.TabIndex = 20;
            this.metroButtonNextBox.Text = "Nächster Kasten ->";
            this.metroButtonNextBox.Click += new System.EventHandler(this.MetroButtonNextBox_Click);
            // 
            // labelBestand
            // 
            this.labelBestand.AutoSize = true;
            this.labelBestand.Location = new System.Drawing.Point(135, 71);
            this.labelBestand.Name = "labelBestand";
            this.labelBestand.Size = new System.Drawing.Size(118, 17);
            this.labelBestand.TabIndex = 22;
            this.labelBestand.Text = "<Bestandsname>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vokabelbestand:";
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Gray;
            this.panelLine.Location = new System.Drawing.Point(-8, 91);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(632, 10);
            this.panelLine.TabIndex = 23;
            // 
            // panelFinishedVoc
            // 
            this.panelFinishedVoc.AutoScroll = true;
            this.panelFinishedVoc.Controls.Add(this.listBox1);
            this.panelFinishedVoc.Location = new System.Drawing.Point(18, 107);
            this.panelFinishedVoc.Name = "panelFinishedVoc";
            this.panelFinishedVoc.Size = new System.Drawing.Size(569, 158);
            this.panelFinishedVoc.TabIndex = 24;
            this.panelFinishedVoc.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(149, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 148);
            this.listBox1.TabIndex = 0;
            // 
            // ViewCardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 361);
            this.Controls.Add(this.panelFinishedVoc);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.labelBestand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroButtonNextBox);
            this.Controls.Add(this.metroButtonPreBox);
            this.Controls.Add(this.labelKasten);
            this.Controls.Add(this.labelKastenText);
            this.Controls.Add(this.GroupBoxCheckStatus);
            this.Controls.Add(this.labelSprache1);
            this.Controls.Add(this.labelSprache2);
            this.Controls.Add(this.metroTextBoxOutput);
            this.Controls.Add(this.metroButtonBackToMenu);
            this.Controls.Add(this.metroTextBoxVocInput);
            this.Controls.Add(this.metroButtonCheck);
            this.Name = "ViewCardManager";
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Vokabelabfrage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewCardManager_FormClosing);
            this.GroupBoxCheckStatus.ResumeLayout(false);
            this.GroupBoxCheckStatus.PerformLayout();
            this.panelFinishedVoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonCheck;
        private MetroFramework.Controls.MetroTextBox metroTextBoxVocInput;
        private MetroFramework.Controls.MetroLabel metroLabelStatus;
        private MetroFramework.Controls.MetroButton metroButtonBackToMenu;
        private MetroFramework.Controls.MetroTextBox metroTextBoxOutput;
        private System.Windows.Forms.Label labelSprache2;
        private System.Windows.Forms.Label labelSprache1;
        private System.Windows.Forms.GroupBox GroupBoxCheckStatus;
        private System.Windows.Forms.Label labelKastenText;
        private System.Windows.Forms.Label labelKasten;
        private MetroFramework.Controls.MetroButton metroButtonPreBox;
        private MetroFramework.Controls.MetroButton metroButtonNextBox;
        private System.Windows.Forms.Label labelBestand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Panel panelFinishedVoc;
        private System.Windows.Forms.ListBox listBox1;
    }
}

