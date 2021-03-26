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
    public partial class LoadWorkForm : Form
    {
        List<int> order_id = new List<int>();
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
                    while (reader.Read())
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
                for (int i = 0; i < custom_id.Count; i++)
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
        public LoadWorkForm()
        {
            InitializeComponent();
            ItemsUpdate();
        }

        private void Order_CheckedChanged(object sender, EventArgs e)
        {
            orders.Enabled = true;

        }

        private void Portfolio_CheckedChanged(object sender, EventArgs e)
        {
            orders.Enabled = false;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Иллюстрации VALUES (@Код_иллюстратора, @Наименование, @Дата_загрузки, @Приватность, @Сокрытие)";
                command.Parameters.Add("@Код_иллюстратора", SqlDbType.Int);
                command.Parameters.Add("@Наименование", SqlDbType.NVarChar, 255);
                command.Parameters.Add("@Дата_загрузки", SqlDbType.DateTime);
                command.Parameters.Add("@Приватность", SqlDbType.Bit);
                command.Parameters.Add("@Сокрытие", SqlDbType.Bit);
                int illustrator_id = Search.currentaccount.id;
                DateTime curdate = new DateTime();
                curdate = DateTime.Now;
                string name = IllustrationName.Text;
                bool priv = Private.Checked;
                command.Parameters["@Код_иллюстратора"].Value = illustrator_id;
                command.Parameters["@Наименование"].Value = name;
                command.Parameters["@Дата_загрузки"].Value = curdate;
                command.Parameters["@Приватность"].Value = priv;
                command.Parameters["@Сокрытие"].Value = 0;
                command.ExecuteNonQuery();
                if(Order.Checked)
                {
                    int need_id = order_id[orders.SelectedIndex];
                    string sqlExpression = "SELECT IDENT_CURRENT('Иллюстрации') AS [IDENT_CURRENT]";
                    SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = commandread.ExecuteReader();
                    reader.Read();
                    int id = Int32.Parse(reader.GetValue(0).ToString());
                    reader.Close();
                    sqlExpression = "UPDATE Заказы SET Код_иллюстрации = " + id + " WHERE Код_заказа = " + need_id;
                    commandread = new SqlCommand(sqlExpression, connection);
                    commandread.ExecuteNonQuery();
                }
                this.Close();
            }

        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
