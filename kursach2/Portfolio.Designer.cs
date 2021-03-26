namespace kursach2
{
    partial class Portfolio
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
            this.PortfolioBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PortfolioBox
            // 
            this.PortfolioBox.FormattingEnabled = true;
            this.PortfolioBox.ItemHeight = 16;
            this.PortfolioBox.Location = new System.Drawing.Point(12, 13);
            this.PortfolioBox.Name = "PortfolioBox";
            this.PortfolioBox.Size = new System.Drawing.Size(491, 372);
            this.PortfolioBox.TabIndex = 0;
            // 
            // Portfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 392);
            this.Controls.Add(this.PortfolioBox);
            this.Name = "Portfolio";
            this.Text = "Портфолио";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PortfolioBox;
    }
}