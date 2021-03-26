namespace kursach2
{
    partial class LoadWorkForm
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
            this.orders = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Portfolio = new System.Windows.Forms.RadioButton();
            this.Order = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.IllustrationName = new System.Windows.Forms.TextBox();
            this.Private = new System.Windows.Forms.CheckBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Загрузить в...";
            // 
            // orders
            // 
            this.orders.Enabled = false;
            this.orders.FormattingEnabled = true;
            this.orders.HorizontalScrollbar = true;
            this.orders.ItemHeight = 16;
            this.orders.Location = new System.Drawing.Point(306, 29);
            this.orders.Name = "orders";
            this.orders.ScrollAlwaysVisible = true;
            this.orders.Size = new System.Drawing.Size(307, 292);
            this.orders.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список заказов";
            // 
            // Portfolio
            // 
            this.Portfolio.AutoSize = true;
            this.Portfolio.Checked = true;
            this.Portfolio.Location = new System.Drawing.Point(12, 33);
            this.Portfolio.Name = "Portfolio";
            this.Portfolio.Size = new System.Drawing.Size(105, 21);
            this.Portfolio.TabIndex = 1;
            this.Portfolio.TabStop = true;
            this.Portfolio.Text = "Портфолио";
            this.Portfolio.UseVisualStyleBackColor = true;
            this.Portfolio.CheckedChanged += new System.EventHandler(this.Portfolio_CheckedChanged);
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Location = new System.Drawing.Point(12, 60);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(68, 21);
            this.Order.TabIndex = 2;
            this.Order.TabStop = true;
            this.Order.Text = "Заказ";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.CheckedChanged += new System.EventHandler(this.Order_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Название иллюстрации:";
            // 
            // IllustrationName
            // 
            this.IllustrationName.Location = new System.Drawing.Point(12, 120);
            this.IllustrationName.Name = "IllustrationName";
            this.IllustrationName.Size = new System.Drawing.Size(281, 22);
            this.IllustrationName.TabIndex = 3;
            // 
            // Private
            // 
            this.Private.AutoSize = true;
            this.Private.Location = new System.Drawing.Point(12, 148);
            this.Private.Name = "Private";
            this.Private.Size = new System.Drawing.Size(115, 21);
            this.Private.TabIndex = 4;
            this.Private.Text = "Приватность";
            this.Private.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 279);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(140, 41);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(153, 279);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(140, 41);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // LoadWorkForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(628, 335);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Private);
            this.Controls.Add(this.IllustrationName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Portfolio);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoadWorkForm";
            this.Text = "Загрузить работу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox orders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Portfolio;
        private System.Windows.Forms.RadioButton Order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IllustrationName;
        private System.Windows.Forms.CheckBox Private;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}