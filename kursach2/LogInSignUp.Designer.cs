namespace kursach2
{
    partial class LogInSignUp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignUp = new System.Windows.Forms.Button();
            this.LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUp
            // 
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUp.Location = new System.Drawing.Point(12, 71);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(258, 53);
            this.SignUp.TabIndex = 2;
            this.SignUp.Text = "Зарегистрироваться";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // LogIn
            // 
            this.LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogIn.Location = new System.Drawing.Point(12, 12);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(258, 53);
            this.LogIn.TabIndex = 1;
            this.LogIn.Text = "Войти";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // LogInSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 136);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.SignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogInSignUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button LogIn;
    }
}

