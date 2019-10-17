namespace Karteikarten_Manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelKasten = new System.Windows.Forms.Label();
            this.metroButtonPreBox = new MetroFramework.Controls.MetroButton();
            this.metroButtonNextBox = new MetroFramework.Controls.MetroButton();
            this.labelBestand = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            this.GroupBoxCheckStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButtonCheck
            // 
            this.metroButtonCheck.Location = new System.Drawing.Point(210, 187);
            this.metroButtonCheck.Name = "metroButtonCheck";
            this.metroButtonCheck.Size = new System.Drawing.Size(187, 78);
            this.metroButtonCheck.TabIndex = 5;
            this.metroButtonCheck.Text = "Check";
            // 
            // metroTextBoxVocInput
            // 
            this.metroTextBoxVocInput.Location = new System.Drawing.Point(18, 127);
            this.metroTextBoxVocInput.Name = "metroTextBoxVocInput";
            this.metroTextBoxVocInput.Size = new System.Drawing.Size(187, 23);
            this.metroTextBoxVocInput.TabIndex = 2;
            // 
            // metroLabelStatus
            // 
            this.metroLabelStatus.AutoSize = true;
            this.metroLabelStatus.Location = new System.Drawing.Point(103, 28);
            this.metroLabelStatus.Name = "metroLabelStatus";
            this.metroLabelStatus.Size = new System.Drawing.Size(54, 20);
            this.metroLabelStatus.TabIndex = 7;
            this.metroLabelStatus.Text = "Richtig!";
            // 
            // metroButtonBackToMenu
            // 
            this.metroButtonBackToMenu.Location = new System.Drawing.Point(18, 329);
            this.metroButtonBackToMenu.Name = "metroButtonBackToMenu";
            this.metroButtonBackToMenu.Size = new System.Drawing.Size(379, 23);
            this.metroButtonBackToMenu.TabIndex = 8;
            this.metroButtonBackToMenu.Text = "Zurück zum Menü";
            this.metroButtonBackToMenu.Click += new System.EventHandler(this.MetroButtonBackToMenu_Click);
            // 
            // metroTextBoxOutput
            // 
            this.metroTextBoxOutput.Location = new System.Drawing.Point(212, 127);
            this.metroTextBoxOutput.Name = "metroTextBoxOutput";
            this.metroTextBoxOutput.Size = new System.Drawing.Size(185, 23);
            this.metroTextBoxOutput.TabIndex = 9;
            // 
            // labelSprache2
            // 
            this.labelSprache2.AutoSize = true;
            this.labelSprache2.Location = new System.Drawing.Point(209, 107);
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
            this.GroupBoxCheckStatus.Size = new System.Drawing.Size(185, 69);
            this.GroupBoxCheckStatus.TabIndex = 16;
            this.GroupBoxCheckStatus.TabStop = false;
            this.GroupBoxCheckStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kasten: ";
            // 
            // labelKasten
            // 
            this.labelKasten.AutoSize = true;
            this.labelKasten.Location = new System.Drawing.Point(371, 71);
            this.labelKasten.Name = "labelKasten";
            this.labelKasten.Size = new System.Drawing.Size(16, 17);
            this.labelKasten.TabIndex = 18;
            this.labelKasten.Text = "9";
            // 
            // metroButtonPreBox
            // 
            this.metroButtonPreBox.Location = new System.Drawing.Point(18, 271);
            this.metroButtonPreBox.Name = "metroButtonPreBox";
            this.metroButtonPreBox.Size = new System.Drawing.Size(185, 52);
            this.metroButtonPreBox.TabIndex = 19;
            this.metroButtonPreBox.Text = "<- Vorheriger Kasten";
            // 
            // metroButtonNextBox
            // 
            this.metroButtonNextBox.Location = new System.Drawing.Point(210, 271);
            this.metroButtonNextBox.Name = "metroButtonNextBox";
            this.metroButtonNextBox.Size = new System.Drawing.Size(187, 52);
            this.metroButtonNextBox.TabIndex = 20;
            this.metroButtonNextBox.Text = "Nächster Kasten ->";
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
            this.panelLine.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelLine.Location = new System.Drawing.Point(-8, 91);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(432, 10);
            this.panelLine.TabIndex = 23;
            // 
            // ViewCardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 361);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.labelBestand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroButtonNextBox);
            this.Controls.Add(this.metroButtonPreBox);
            this.Controls.Add(this.labelKasten);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKasten;
        private MetroFramework.Controls.MetroButton metroButtonPreBox;
        private MetroFramework.Controls.MetroButton metroButtonNextBox;
        private System.Windows.Forms.Label labelBestand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelLine;
    }
}

