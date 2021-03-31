namespace kursach2
{
    partial class ChangeIllustrationTags
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
            this.tagsListBox = new System.Windows.Forms.ListBox();
            this.AddTags = new System.Windows.Forms.Button();
            this.AddTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tagsListBox
            // 
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.HorizontalScrollbar = true;
            this.tagsListBox.ItemHeight = 16;
            this.tagsListBox.Location = new System.Drawing.Point(12, 39);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.ScrollAlwaysVisible = true;
            this.tagsListBox.Size = new System.Drawing.Size(585, 132);
            this.tagsListBox.TabIndex = 6;
            // 
            // AddTags
            // 
            this.AddTags.Location = new System.Drawing.Point(446, 16);
            this.AddTags.Name = "AddTags";
            this.AddTags.Size = new System.Drawing.Size(151, 26);
            this.AddTags.TabIndex = 9;
            this.AddTags.Text = "Добавить тэг";
            this.AddTags.UseVisualStyleBackColor = true;
            this.AddTags.Click += new System.EventHandler(this.AddTags_Click);
            // 
            // AddTag
            // 
            this.AddTag.Location = new System.Drawing.Point(195, 18);
            this.AddTag.Name = "AddTag";
            this.AddTag.Size = new System.Drawing.Size(253, 22);
            this.AddTag.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тэги";
            // 
            // ChangeIllustrationTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 183);
            this.Controls.Add(this.tagsListBox);
            this.Controls.Add(this.AddTags);
            this.Controls.Add(this.AddTag);
            this.Controls.Add(this.label1);
            this.Name = "ChangeIllustrationTags";
            this.Text = "Изменить тэги иллюстрации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tagsListBox;
        private System.Windows.Forms.Button AddTags;
        private System.Windows.Forms.TextBox AddTag;
        private System.Windows.Forms.Label label1;
    }
}