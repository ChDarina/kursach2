using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach2
{
    public partial class ChangeIllustratorOrder : Form
    {
        static int id;
        IllustratorOrders prev_form;
        public ChangeIllustratorOrder(int id_order, IllustratorOrders form)
        {
            prev_form = form;
            id = id_order;
            InitializeComponent();
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                string sqlExpression = "SELECT * FROM Заказы WHERE Код_заказа = " + id;
                SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = commandread.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    CommentBox.Text = reader.GetString(4);
                    StatusBox.Text = reader.GetString(6);
                    if (reader.GetValue(7) != null) PriceBox.Text = reader.GetValue(7).ToString();
                }
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string comment = CommentBox.Text;
            int price = Int32.Parse(PriceBox.Text);
            string status = StatusBox.Text;
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                string sqlExpression = "UPDATE Заказы SET Комментарий_к_заказу = '" + comment + "', Цена = " + price + ", Статус_заказа = '" + status + "' WHERE Код_заказа = " + id;
                SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                commandread.ExecuteNonQuery();
            }
            prev_form.ItemsUpdate();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
