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
            this.metroPanelVoc = new MetroFramework.Controls.MetroPanel();
            this.metroLabelVoc = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxVocInput = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelStatus = new MetroFramework.Controls.MetroLabel();
            this.metroButtonBackToMenu = new MetroFramework.Controls.MetroButton();
            this.metroPanelVoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButtonCheck
            // 
            this.metroButtonCheck.Location = new System.Drawing.Point(142, 407);
            this.metroButtonCheck.Name = "metroButtonCheck";
            this.metroButtonCheck.Size = new System.Drawing.Size(235, 23);
            this.metroButtonCheck.TabIndex = 5;
            this.metroButtonCheck.Text = "Check";
            // 
            // metroPanelVoc
            // 
            this.metroPanelVoc.BackColor = System.Drawing.Color.White;
            this.metroPanelVoc.Controls.Add(this.metroLabelVoc);
            this.metroPanelVoc.HorizontalScrollbarBarColor = true;
            this.metroPanelVoc.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelVoc.HorizontalScrollbarSize = 10;
            this.metroPanelVoc.Location = new System.Drawing.Point(23, 70);
            this.metroPanelVoc.Name = "metroPanelVoc";
            this.metroPanelVoc.Size = new System.Drawing.Size(354, 302);
            this.metroPanelVoc.TabIndex = 6;
            this.metroPanelVoc.VerticalScrollbarBarColor = true;
            this.metroPanelVoc.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelVoc.VerticalScrollbarSize = 10;
            // 
            // metroLabelVoc
            // 
            this.metroLabelVoc.AutoSize = true;
            this.metroLabelVoc.Location = new System.Drawing.Point(147, 143);
            this.metroLabelVoc.Name = "metroLabelVoc";
            this.metroLabelVoc.Size = new System.Drawing.Size(40, 20);
            this.metroLabelVoc.TabIndex = 7;
            this.metroLabelVoc.Text = "Haus";
            // 
            // metroTextBoxVocInput
            // 
            this.metroTextBoxVocInput.Location = new System.Drawing.Point(23, 378);
            this.metroTextBoxVocInput.Name = "metroTextBoxVocInput";
            this.metroTextBoxVocInput.Size = new System.Drawing.Size(354, 23);
            this.metroTextBoxVocInput.TabIndex = 2;
            // 
            // metroLabelStatus
            // 
            this.metroLabelStatus.AutoSize = true;
            this.metroLabelStatus.Location = new System.Drawing.Point(23, 447);
            this.metroLabelStatus.Name = "metroLabelStatus";
            this.metroLabelStatus.Size = new System.Drawing.Size(54, 20);
            this.metroLabelStatus.TabIndex = 7;
            this.metroLabelStatus.Text = "Richtig!";
            // 
            // metroButtonBackToMenu
            // 
            this.metroButtonBackToMenu.Location = new System.Drawing.Point(23, 407);
            this.metroButtonBackToMenu.Name = "metroButtonBackToMenu";
            this.metroButtonBackToMenu.Size = new System.Drawing.Size(113, 23);
            this.metroButtonBackToMenu.TabIndex = 8;
            this.metroButtonBackToMenu.Text = "Zurück zum Menü";
            // 
            // ViewCardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 500);
            this.Controls.Add(this.metroButtonBackToMenu);
            this.Controls.Add(this.metroLabelStatus);
            this.Controls.Add(this.metroTextBoxVocInput);
            this.Controls.Add(this.metroPanelVoc);
            this.Controls.Add(this.metroButtonCheck);
            this.Name = "ViewCardManager";
            this.ShowIcon = false;
            this.Text = "Abfragemodus";
            this.metroPanelVoc.ResumeLayout(false);
            this.metroPanelVoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonCheck;
        private MetroFramework.Controls.MetroPanel metroPanelVoc;
        private MetroFramework.Controls.MetroLabel metroLabelVoc;
        private MetroFramework.Controls.MetroTextBox metroTextBoxVocInput;
        private MetroFramework.Controls.MetroLabel metroLabelStatus;
        private MetroFramework.Controls.MetroButton metroButtonBackToMenu;
    }
}

