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
            this.textBoxVocInput = new System.Windows.Forms.TextBox();
            this.labelVocOutput = new System.Windows.Forms.Label();
            this.buttonMultiFunc = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panelVoc = new System.Windows.Forms.Panel();
            this.panelVoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxVocInput
            // 
            this.textBoxVocInput.Location = new System.Drawing.Point(12, 201);
            this.textBoxVocInput.Name = "textBoxVocInput";
            this.textBoxVocInput.Size = new System.Drawing.Size(225, 22);
            this.textBoxVocInput.TabIndex = 0;
            // 
            // labelVocOutput
            // 
            this.labelVocOutput.AutoSize = true;
            this.labelVocOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVocOutput.Location = new System.Drawing.Point(75, 79);
            this.labelVocOutput.Name = "labelVocOutput";
            this.labelVocOutput.Size = new System.Drawing.Size(148, 32);
            this.labelVocOutput.TabIndex = 1;
            this.labelVocOutput.Text = "Hanswurst";
            // 
            // buttonMultiFunc
            // 
            this.buttonMultiFunc.Location = new System.Drawing.Point(243, 201);
            this.buttonMultiFunc.Name = "buttonMultiFunc";
            this.buttonMultiFunc.Size = new System.Drawing.Size(75, 42);
            this.buttonMultiFunc.TabIndex = 2;
            this.buttonMultiFunc.Text = "Check";
            this.buttonMultiFunc.UseVisualStyleBackColor = true;
            this.buttonMultiFunc.Click += new System.EventHandler(this.ButtonMultiFunc_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 226);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(199, 17);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Right. Voc. moved to Kasten 2";
            // 
            // panelVoc
            // 
            this.panelVoc.BackColor = System.Drawing.Color.White;
            this.panelVoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelVoc.Controls.Add(this.labelVocOutput);
            this.panelVoc.Location = new System.Drawing.Point(12, 12);
            this.panelVoc.Name = "panelVoc";
            this.panelVoc.Size = new System.Drawing.Size(306, 183);
            this.panelVoc.TabIndex = 4;
            // 
            // ViewCardManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 249);
            this.Controls.Add(this.panelVoc);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonMultiFunc);
            this.Controls.Add(this.textBoxVocInput);
            this.Name = "ViewCardManager";
            this.ShowIcon = false;
            this.panelVoc.ResumeLayout(false);
            this.panelVoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVocInput;
        private System.Windows.Forms.Label labelVocOutput;
        private System.Windows.Forms.Button buttonMultiFunc;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panelVoc;
    }
}

