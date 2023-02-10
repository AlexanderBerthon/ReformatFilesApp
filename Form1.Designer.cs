namespace ReformatFilesApp {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.PathTextbox = new System.Windows.Forms.TextBox();
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PathTextbox
            // 
            this.PathTextbox.Enabled = false;
            this.PathTextbox.HideSelection = false;
            this.PathTextbox.Location = new System.Drawing.Point(65, 85);
            this.PathTextbox.Multiline = true;
            this.PathTextbox.Name = "PathTextbox";
            this.PathTextbox.ReadOnly = true;
            this.PathTextbox.Size = new System.Drawing.Size(198, 177);
            this.PathTextbox.TabIndex = 0;
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Location = new System.Drawing.Point(112, 56);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(106, 23);
            this.FileSelectButton.TabIndex = 1;
            this.FileSelectButton.Text = "Select Location";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(124, 268);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(98, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(133, 15);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Lowercase File Ext";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 303);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.FileSelectButton);
            this.Controls.Add(this.PathTextbox);
            this.Name = "Form1";
            this.Text = "LC_Ext";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PathTextbox;
        private Button FileSelectButton;
        private Button ConvertButton;
        private Label TitleLabel;
    }
}