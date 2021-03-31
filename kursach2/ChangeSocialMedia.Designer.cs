namespace kursach2
{
    partial class ChangeSocialMedia
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
            this.label1 = new System.Windows.Forms.Label();
            this.SocialMediaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SocialMediaRef = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название социальной сети";
            // 
            // SocialMediaName
            // 
            this.SocialMediaName.Location = new System.Drawing.Point(12, 33);
            this.SocialMediaName.Name = "SocialMediaName";
            this.SocialMediaName.Size = new System.Drawing.Size(185, 22);
            this.SocialMediaName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ссылка на социальную сеть";
            // 
            // SocialMediaRef
            // 
            this.SocialMediaRef.Location = new System.Drawing.Point(12, 78);
            this.SocialMediaRef.Name = "SocialMediaRef";
            this.SocialMediaRef.Size = new System.Drawing.Size(185, 22);
            this.SocialMediaRef.TabIndex = 3;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 107);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(90, 23);
            this.OK.TabIndex = 4;
            this.OK.Text = "ОК";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(107, 107);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(90, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ChangeSocialMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 137);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.SocialMediaRef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SocialMediaName);
            this.Controls.Add(this.label1);
            this.Name = "ChangeSocialMedia";
            this.Text = "ChangeSocialMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SocialMediaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SocialMediaRef;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}