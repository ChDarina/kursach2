namespace kursach2
{
    partial class SignUpForm
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
            this.InsertEMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InsertPassword = new System.Windows.Forms.TextBox();
            this.CustomerChoice = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.InsertNickname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IllustratorChoice = new System.Windows.Forms.RadioButton();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.InsertPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите электронную почту";
            // 
            // InsertEMail
            // 
            this.InsertEMail.Location = new System.Drawing.Point(12, 34);
            this.InsertEMail.Name = "InsertEMail";
            this.InsertEMail.Size = new System.Drawing.Size(254, 22);
            this.InsertEMail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите пароль";
            // 
            // InsertPassword
            // 
            this.InsertPassword.Location = new System.Drawing.Point(12, 124);
            this.InsertPassword.Name = "InsertPassword";
            this.InsertPassword.Size = new System.Drawing.Size(254, 22);
            this.InsertPassword.TabIndex = 3;
            // 
            // CustomerChoice
            // 
            this.CustomerChoice.AutoSize = true;
            this.CustomerChoice.Checked = true;
            this.CustomerChoice.Location = new System.Drawing.Point(16, 214);
            this.CustomerChoice.Name = "CustomerChoice";
            this.CustomerChoice.Size = new System.Drawing.Size(107, 21);
            this.CustomerChoice.TabIndex = 5;
            this.CustomerChoice.TabStop = true;
            this.CustomerChoice.Text = "Покупатель";
            this.CustomerChoice.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите логин";
            // 
            // InsertNickname
            // 
            this.InsertNickname.Location = new System.Drawing.Point(12, 79);
            this.InsertNickname.Name = "InsertNickname";
            this.InsertNickname.Size = new System.Drawing.Size(254, 22);
            this.InsertNickname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Зарегистрироваться как...";
            // 
            // IllustratorChoice
            // 
            this.IllustratorChoice.AutoSize = true;
            this.IllustratorChoice.Location = new System.Drawing.Point(16, 241);
            this.IllustratorChoice.Name = "IllustratorChoice";
            this.IllustratorChoice.Size = new System.Drawing.Size(118, 21);
            this.IllustratorChoice.TabIndex = 6;
            this.IllustratorChoice.TabStop = true;
            this.IllustratorChoice.Text = "Иллюстратор";
            this.IllustratorChoice.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(142, 266);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(124, 28);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 266);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(124, 28);
            this.OK.TabIndex = 7;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Введите номер телефона";
            // 
            // InsertPhone
            // 
            this.InsertPhone.Location = new System.Drawing.Point(12, 169);
            this.InsertPhone.Name = "InsertPhone";
            this.InsertPhone.Size = new System.Drawing.Size(254, 22);
            this.InsertPhone.TabIndex = 4;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 306);
            this.Controls.Add(this.InsertPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.IllustratorChoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InsertNickname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerChoice);
            this.Controls.Add(this.InsertPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertEMail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SignUpForm";
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InsertEMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InsertPassword;
        private System.Windows.Forms.RadioButton CustomerChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InsertNickname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton IllustratorChoice;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InsertPhone;
    }
}