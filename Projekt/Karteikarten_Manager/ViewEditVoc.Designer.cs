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
            this.metroTextBoxOutput = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxVocInput = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonAddVoc = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButtonBack
            // 
            this.metroButtonBack.Location = new System.Drawing.Point(20, 278);
            this.metroButtonBack.Name = "metroButtonBack";
            this.metroButtonBack.Size = new System.Drawing.Size(381, 23);
            this.metroButtonBack.TabIndex = 11;
            this.metroButtonBack.Text = "Zurück zum Menü";
            // 
            // labelSprache1
            // 
            this.labelSprache1.AutoSize = true;
            this.labelSprache1.Location = new System.Drawing.Point(17, 72);
            this.labelSprache1.Name = "labelSprache1";
            this.labelSprache1.Size = new System.Drawing.Size(77, 17);
            this.labelSprache1.TabIndex = 15;
            this.labelSprache1.Text = "Sprache 1:";
            // 
            // labelSprache2
            // 
            this.labelSprache2.AutoSize = true;
            this.labelSprache2.Location = new System.Drawing.Point(17, 137);
            this.labelSprache2.Name = "labelSprache2";
            this.labelSprache2.Size = new System.Drawing.Size(77, 17);
            this.labelSprache2.TabIndex = 14;
            this.labelSprache2.Text = "Sprache 2:";
            // 
            // metroTextBoxOutput
            // 
            this.metroTextBoxOutput.Location = new System.Drawing.Point(20, 157);
            this.metroTextBoxOutput.Name = "metroTextBoxOutput";
            this.metroTextBoxOutput.Size = new System.Drawing.Size(381, 23);
            this.metroTextBoxOutput.TabIndex = 13;
            // 
            // metroTextBoxVocInput
            // 
            this.metroTextBoxVocInput.Location = new System.Drawing.Point(20, 92);
            this.metroTextBoxVocInput.Name = "metroTextBoxVocInput";
            this.metroTextBoxVocInput.Size = new System.Drawing.Size(381, 23);
            this.metroTextBoxVocInput.TabIndex = 12;
            // 
            // metroButtonAddVoc
            // 
            this.metroButtonAddVoc.Location = new System.Drawing.Point(20, 196);
            this.metroButtonAddVoc.Name = "metroButtonAddVoc";
            this.metroButtonAddVoc.Size = new System.Drawing.Size(381, 63);
            this.metroButtonAddVoc.TabIndex = 16;
            this.metroButtonAddVoc.Text = "Hinzufügen";
            // 
            // ViewEditVoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 316);
            this.Controls.Add(this.metroButtonAddVoc);
            this.Controls.Add(this.labelSprache1);
            this.Controls.Add(this.labelSprache2);
            this.Controls.Add(this.metroTextBoxOutput);
            this.Controls.Add(this.metroTextBoxVocInput);
            this.Controls.Add(this.metroButtonBack);
            this.Name = "ViewEditVoc";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Vokabeln hinzufügen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewEditVoc_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonBack;
        private System.Windows.Forms.Label labelSprache1;
        private System.Windows.Forms.Label labelSprache2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxOutput;
        private MetroFramework.Controls.MetroTextBox metroTextBoxVocInput;
        private MetroFramework.Controls.MetroButton metroButtonAddVoc;
    }
}