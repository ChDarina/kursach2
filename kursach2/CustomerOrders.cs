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
    public partial class CustomerOrders : Form
    {
        ChangeCustomerOrder ord = null;
        List<int> order_id = new List<int>();
        public void ItemsUpdate()
        {
            orders.Items.Clear();
            List<int> illust_id = new List<int>();
            List<string> s = new List<string>();
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                int num = Search.currentaccount.id;
                string sqlExpression = "SELECT * FROM Заказы WHERE Код_иллюстратора = " + num;
                SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = commandread.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string temps = "";
                        for (int i = 4; i < 8; i++)
                        {
                            if (reader.GetValue(i) != null)
                                temps += reader.GetValue(i).ToString() + " ";
                        }
                        s.Add(temps);
                        order_id.Add(reader.GetInt32(0));
                        illust_id.Add(reader.GetInt32(1));
                    }
                }
                reader.Close();
                for (int i = 0; i < illust_id.Count; i++)
                {
                    sqlExpression = "SELECT * FROM Иллюстратор WHERE Код_иллюстратора = " + illust_id[i];
                    commandread = new SqlCommand(sqlExpression, connection);
                    reader = commandread.ExecuteReader();
                    reader.Read();
                    string temp = reader.GetString(2);
                    orders.Items.Add(temp + " " + s[i]);
                    reader.Close();
                }
            }
        }
        public CustomerOrders()
        {
            InitializeComponent();
            ItemsUpdate();
        }

        private void orders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (orders.SelectedItem != null)
            {
                int need_id = order_id[orders.SelectedIndex];
                ord = new ChangeCustomerOrder(need_id, this);
                ord.Show();
            }
        }

        private void CustomerOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ord!=null) ord.Close();
        }
    }
}
