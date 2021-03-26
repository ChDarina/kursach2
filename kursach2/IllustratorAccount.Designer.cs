namespace kursach2
{
    partial class IllustratorAccount
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
            this.IllustratorName = new System.Windows.Forms.Label();
            this.IllustratorEMail = new System.Windows.Forms.Label();
            this.checkportfolio = new System.Windows.Forms.Button();
            this.Makeorderbutton = new System.Windows.Forms.Button();
            this.tagsListBox = new System.Windows.Forms.ListBox();
            this.socialmedia = new System.Windows.Forms.Button();
            this.PhoneNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTags = new System.Windows.Forms.Button();
            this.AddTag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IllustratorName
            // 
            this.IllustratorName.AutoSize = true;
            this.IllustratorName.Location = new System.Drawing.Point(12, 9);
            this.IllustratorName.Name = "IllustratorName";
            this.IllustratorName.Size = new System.Drawing.Size(131, 17);
            this.IllustratorName.TabIndex = 0;
            this.IllustratorName.Text = "Имя пользователя";
            // 
            // IllustratorEMail
            // 
            this.IllustratorEMail.AutoSize = true;
            this.IllustratorEMail.Location = new System.Drawing.Point(12, 26);
            this.IllustratorEMail.Name = "IllustratorEMail";
            this.IllustratorEMail.Size = new System.Drawing.Size(138, 17);
            this.IllustratorEMail.TabIndex = 0;
            this.IllustratorEMail.Text = "Электронная почта";
            // 
            // checkportfolio
            // 
            this.checkportfolio.Location = new System.Drawing.Point(331, 9);
            this.checkportfolio.Name = "checkportfolio";
            this.checkportfolio.Size = new System.Drawing.Size(130, 51);
            this.checkportfolio.TabIndex = 2;
            this.checkportfolio.Text = "Просмотреть портфолио";
            this.checkportfolio.UseVisualStyleBackColor = true;
            this.checkportfolio.Click += new System.EventHandler(this.checkportfolio_Click);
            // 
            // Makeorderbutton
            // 
            this.Makeorderbutton.Location = new System.Drawing.Point(467, 9);
            this.Makeorderbutton.Name = "Makeorderbutton";
            this.Makeorderbutton.Size = new System.Drawing.Size(130, 51);
            this.Makeorderbutton.TabIndex = 3;
            this.Makeorderbutton.Text = "Сделать заказ";
            this.Makeorderbutton.UseVisualStyleBackColor = true;
            this.Makeorderbutton.Click += new System.EventHandler(this.Makeorderbutton_Click);
            // 
            // tagsListBox
            // 
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.HorizontalScrollbar = true;
            this.tagsListBox.ItemHeight = 16;
            this.tagsListBox.Location = new System.Drawing.Point(12, 93);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.ScrollAlwaysVisible = true;
            this.tagsListBox.Size = new System.Drawing.Size(585, 132);
            this.tagsListBox.TabIndex = 0;
            // 
            // socialmedia
            // 
            this.socialmedia.Location = new System.Drawing.Point(195, 9);
            this.socialmedia.Name = "socialmedia";
            this.socialmedia.Size = new System.Drawing.Size(130, 51);
            this.socialmedia.TabIndex = 1;
            this.socialmedia.Text = "Социальные сети";
            this.socialmedia.UseVisualStyleBackColor = true;
            // 
            // PhoneNum
            // 
            this.PhoneNum.AutoSize = true;
            this.PhoneNum.Location = new System.Drawing.Point(12, 43);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(121, 17);
            this.PhoneNum.TabIndex = 0;
            this.PhoneNum.Text = "Номер телефона";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Тэги";
            // 
            // AddTags
            // 
            this.AddTags.Location = new System.Drawing.Point(446, 70);
            this.AddTags.Name = "AddTags";
            this.AddTags.Size = new System.Drawing.Size(151, 26);
            this.AddTags.TabIndex = 5;
            this.AddTags.Text = "Добавить тэг";
            this.AddTags.UseVisualStyleBackColor = true;
            this.AddTags.Click += new System.EventHandler(this.AddTags_Click);
            // 
            // AddTag
            // 
            this.AddTag.Location = new System.Drawing.Point(195, 72);
            this.AddTag.Name = "AddTag";
            this.AddTag.Size = new System.Drawing.Size(253, 22);
            this.AddTag.TabIndex = 4;
            // 
            // IllustratorAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 237);
            this.Controls.Add(this.tagsListBox);
            this.Controls.Add(this.AddTags);
            this.Controls.Add(this.AddTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.socialmedia);
            this.Controls.Add(this.Makeorderbutton);
            this.Controls.Add(this.checkportfolio);
            this.Controls.Add(this.IllustratorEMail);
            this.Controls.Add(this.IllustratorName);
            this.Name = "IllustratorAccount";
            this.Text = "Аккаунт иллюстратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IllustratorName;
        private System.Windows.Forms.Label IllustratorEMail;
        private System.Windows.Forms.Button checkportfolio;
        private System.Windows.Forms.Button Makeorderbutton;
        private System.Windows.Forms.ListBox tagsListBox;
        private System.Windows.Forms.Button socialmedia;
        private System.Windows.Forms.Label PhoneNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddTags;
        private System.Windows.Forms.TextBox AddTag;
    }
}