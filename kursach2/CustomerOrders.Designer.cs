namespace kursach2
{
    partial class CustomerOrders
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
            this.orders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // orders
            // 
            this.orders.FormattingEnabled = true;
            this.orders.HorizontalScrollbar = true;
            this.orders.ItemHeight = 16;
            this.orders.Location = new System.Drawing.Point(12, 14);
            this.orders.Name = "orders";
            this.orders.ScrollAlwaysVisible = true;
            this.orders.Size = new System.Drawing.Size(585, 276);
            this.orders.TabIndex = 5;
            this.orders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.orders_MouseDoubleClick);
            // 
            // CustomerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 302);
            this.Controls.Add(this.orders);
            this.Name = "CustomerOrders";
            this.Text = "Заказы покупателя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerOrders_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox orders;
    }
}