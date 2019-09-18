namespace Karteikarten_Manager
{
    partial class ViewMenu
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
            this.buttonVocMode = new System.Windows.Forms.Button();
            this.buttonEditMode = new System.Windows.Forms.Button();
            this.buttonBackToWelcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVocMode
            // 
            this.buttonVocMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVocMode.Location = new System.Drawing.Point(23, 84);
            this.buttonVocMode.Name = "buttonVocMode";
            this.buttonVocMode.Size = new System.Drawing.Size(260, 77);
            this.buttonVocMode.TabIndex = 1;
            this.buttonVocMode.Text = "Vokabelabfrage";
            this.buttonVocMode.UseVisualStyleBackColor = true;
            this.buttonVocMode.Click += new System.EventHandler(this.ButtonVocMode_Click);
            // 
            // buttonEditMode
            // 
            this.buttonEditMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditMode.Location = new System.Drawing.Point(23, 167);
            this.buttonEditMode.Name = "buttonEditMode";
            this.buttonEditMode.Size = new System.Drawing.Size(260, 77);
            this.buttonEditMode.TabIndex = 2;
            this.buttonEditMode.Text = "Vokabeln bearbeitungen";
            this.buttonEditMode.UseVisualStyleBackColor = true;
            // 
            // buttonBackToWelcome
            // 
            this.buttonBackToWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToWelcome.Location = new System.Drawing.Point(23, 250);
            this.buttonBackToWelcome.Name = "buttonBackToWelcome";
            this.buttonBackToWelcome.Size = new System.Drawing.Size(260, 77);
            this.buttonBackToWelcome.TabIndex = 3;
            this.buttonBackToWelcome.Text = "Zurück zur Auswahl";
            this.buttonBackToWelcome.UseVisualStyleBackColor = true;
            this.buttonBackToWelcome.Click += new System.EventHandler(this.ButtonBackToWelcome_Click);
            // 
            // ViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 346);
            this.Controls.Add(this.buttonBackToWelcome);
            this.Controls.Add(this.buttonEditMode);
            this.Controls.Add(this.buttonVocMode);
            this.MaximizeBox = false;
            this.Name = "ViewMenu";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Hauptmenü";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonVocMode;
        private System.Windows.Forms.Button buttonEditMode;
        private System.Windows.Forms.Button buttonBackToWelcome;
    }
}