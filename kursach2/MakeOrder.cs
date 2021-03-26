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
    public partial class MakeOrder : Form
    {
        public MakeOrder()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Заказы VALUES (@Код_иллюстратора, @Код_покупателя, @Код_иллюстрации, @Комментарий_к_заказу, @Отзыв, @Статус_заказа, @Цена, @Дата_заказа)";
                command.Parameters.Add("@Код_иллюстратора", SqlDbType.Int);
                command.Parameters.Add("@Код_покупателя", SqlDbType.Int);
                command.Parameters.Add("@Код_иллюстрации", SqlDbType.Int);
                command.Parameters.Add("@Комментарий_к_заказу", SqlDbType.NVarChar);
                command.Parameters.Add("@Отзыв", SqlDbType.NVarChar);
                command.Parameters.Add("@Статус_заказа", SqlDbType.NVarChar, 255);
                command.Parameters.Add("@Цена", SqlDbType.Int);
                command.Parameters.Add("@Дата_заказа", SqlDbType.DateTime);
                int cus_id = Search.currentaccount.id;
                int ill_id = Search.illustratoraccount.id;
                string comment = textBox1.Text;
                string status = "В ожидании подтверждения";
                DateTime curdate = new DateTime();
                curdate = DateTime.Now;
                command.Parameters["@Код_иллюстратора"].Value = ill_id;
                command.Parameters["@Код_покупателя"].Value = cus_id;
                command.Parameters["@Код_иллюстрации"].Value = DBNull.Value;
                command.Parameters["@Комментарий_к_заказу"].Value = comment;
                command.Parameters["@Отзыв"].Value = DBNull.Value;
                command.Parameters["@Статус_заказа"].Value = status;
                command.Parameters["@Цена"].Value = DBNull.Value;
                command.Parameters["@Дата_заказа"].Value = curdate;
                command.ExecuteNonQuery();
            }
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
