namespace kursach2
{
    partial class LogInForm
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
            this.InsertLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InsertPassword = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.IllustratorChoice = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerChoice = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите логин";
            // 
            // InsertLogin
            // 
            this.InsertLogin.Location = new System.Drawing.Point(12, 33);
            this.InsertLogin.Name = "InsertLogin";
            this.InsertLogin.Size = new System.Drawing.Size(258, 22);
            this.InsertLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите пароль";
            // 
            // InsertPassword
            // 
            this.InsertPassword.Location = new System.Drawing.Point(13, 78);
            this.InsertPassword.Name = "InsertPassword";
            this.InsertPassword.Size = new System.Drawing.Size(257, 22);
            this.InsertPassword.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(146, 177);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(124, 28);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(12, 177);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(124, 28);
            this.OK.TabIndex = 5;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // IllustratorChoice
            // 
            this.IllustratorChoice.AutoSize = true;
            this.IllustratorChoice.Location = new System.Drawing.Point(12, 150);
            this.IllustratorChoice.Name = "IllustratorChoice";
            this.IllustratorChoice.Size = new System.Drawing.Size(118, 21);
            this.IllustratorChoice.TabIndex = 4;
            this.IllustratorChoice.Text = "Иллюстратор";
            this.IllustratorChoice.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Войти как...";
            // 
            // CustomerChoice
            // 
            this.CustomerChoice.AutoSize = true;
            this.CustomerChoice.Checked = true;
            this.CustomerChoice.Location = new System.Drawing.Point(12, 123);
            this.CustomerChoice.Name = "CustomerChoice";
            this.CustomerChoice.Size = new System.Drawing.Size(107, 21);
            this.CustomerChoice.TabIndex = 3;
            this.CustomerChoice.TabStop = true;
            this.CustomerChoice.Text = "Покупатель";
            this.CustomerChoice.UseVisualStyleBackColor = true;
            // 
            // LogInForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(282, 216);
            this.Controls.Add(this.IllustratorChoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerChoice);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.InsertPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogInForm";
            this.Text = "Войти";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogInForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InsertLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InsertPassword;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.RadioButton IllustratorChoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton CustomerChoice;
    }
}