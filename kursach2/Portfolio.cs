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
    public partial class Portfolio : Form
    {
        public Portfolio(bool current_acc)
        {
            bool curacc = current_acc;
            InitializeComponent();
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                string sqlExpression;
                if (curacc)
                    sqlExpression = "SELECT * FROM Иллюстрации WHERE Код_иллюстратора = " + Search.currentaccount.id;
                else
                    sqlExpression = "SELECT * FROM Иллюстрации WHERE Код_иллюстратора = " + Search.illustratoraccount.id;
                SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = commandread.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetBoolean(5) == false) if (curacc || reader.GetBoolean(4) == false) PortfolioBox.Items.Add(reader.GetString(2) + " " + reader.GetDateTime(3).ToString());
                    }
                }
                reader.Close();
            }
        }
    }
}
