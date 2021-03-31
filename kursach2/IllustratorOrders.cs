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
    public partial class IllustratorOrders : Form
    {
        List<int> order_id = new List<int>();
        ChangeIllustratorOrder ord = null;
        public void ItemsUpdate()
        {
            orders.Items.Clear();
            List<string> s = new List<string>();
            List<int> custom_id = new List<int>();
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
                    while(reader.Read())
                    {
                        string temps = "";
                        for (int i = 4; i < 8; i++)
                        {
                            if (reader.GetValue(i) != null)
                                temps += reader.GetValue(i).ToString() + " ";
                        }
                        s.Add(temps);
                        custom_id.Add(reader.GetInt32(2));
                        order_id.Add(reader.GetInt32(0));
                    }
                }
                reader.Close();
                for(int i = 0; i < custom_id.Count; i++)
                {
                    sqlExpression = "SELECT * FROM Покупатель WHERE Код_покупателя = " + custom_id[i];
                    commandread = new SqlCommand(sqlExpression, connection);
                    reader = commandread.ExecuteReader();
                    reader.Read();
                    string temp = reader.GetString(2);
                    orders.Items.Add(temp + " " + s[i]);
                    reader.Close();
                }       
            }
        }
        public IllustratorOrders()
        {
            InitializeComponent();
            ItemsUpdate();
        }

        private void orders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (orders.SelectedItem != null)
            {
                int need_id = order_id[orders.SelectedIndex];
                ord = new ChangeIllustratorOrder(need_id, this);
                ord.Show();
            }
        }

        private void IllustratorOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ord != null) ord.Close();
        }
    }
}
