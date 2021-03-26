namespace kursach2
{
    partial class SocialMedia
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
            this.SocialMediaBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SocialMediaBox
            // 
            this.SocialMediaBox.FormattingEnabled = true;
            this.SocialMediaBox.ItemHeight = 16;
            this.SocialMediaBox.Location = new System.Drawing.Point(13, 13);
            this.SocialMediaBox.Name = "SocialMediaBox";
            this.SocialMediaBox.Size = new System.Drawing.Size(299, 228);
            this.SocialMediaBox.TabIndex = 0;
            // 
            // SocialMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 253);
            this.Controls.Add(this.SocialMediaBox);
            this.Name = "SocialMedia";
            this.Text = "Социальные сети";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SocialMediaBox;
    }
}