namespace kursach2
{
    partial class CustomerAccount
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
            this.CustomerName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PhoneNum = new System.Windows.Forms.Label();
            this.SocialMediabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(9, 9);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(131, 17);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.Text = "Имя пользователя";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(9, 26);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(138, 17);
            this.Email.TabIndex = 1;
            this.Email.Text = "Электронная почта";
            // 
            // PhoneNum
            // 
            this.PhoneNum.AutoSize = true;
            this.PhoneNum.Location = new System.Drawing.Point(9, 43);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(121, 17);
            this.PhoneNum.TabIndex = 2;
            this.PhoneNum.Text = "Номер телефона";
            // 
            // SocialMediabutton
            // 
            this.SocialMediabutton.Location = new System.Drawing.Point(186, 9);
            this.SocialMediabutton.Name = "SocialMediabutton";
            this.SocialMediabutton.Size = new System.Drawing.Size(181, 51);
            this.SocialMediabutton.TabIndex = 3;
            this.SocialMediabutton.Text = "Социальные сети";
            this.SocialMediabutton.UseVisualStyleBackColor = true;
            this.SocialMediabutton.Click += new System.EventHandler(this.SocialMediabutton_Click);
            // 
            // CustomerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 71);
            this.Controls.Add(this.SocialMediabutton);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.CustomerName);
            this.Name = "CustomerAccount";
            this.Text = "Аккаунт покупателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label PhoneNum;
        private System.Windows.Forms.Button SocialMediabutton;
    }
}