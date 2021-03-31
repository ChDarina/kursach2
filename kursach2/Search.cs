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
    public partial class Search : Form
    {
        bool curacc = false;
        LogInSignUp form;
        public static Account currentaccount = null;
        public static Account illustratoraccount = null;
        public Search(Account account, LogInSignUp form)
        {
            InitializeComponent();
            currentaccount = account;
            if (currentaccount.type == "Покупатель") LoadWork.Visible = false;
            this.form = form;
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                string sqlExpression = "SELECT * FROM Техника_исполнения";
                SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = commandread.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        comboBoxSearch.Items.Add(reader.GetString(1));
                    }
                }
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> commands = new List<string>();
            string search = comboBoxSearch.Text;
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int num=-1;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                string sqlExpression = "SELECT * FROM Техника_исполнения WHERE Название_техники_исполнения = '" + search + "'";
                SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = commandread.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    num = reader.GetInt32(0);
                    reader.Close();
                }
                if (num != -1)
                {
                    sqlExpression = "SELECT * FROM Техники_исполнения_иллюстратора WHERE Код_техники_исполнения = " + num;
                    SqlCommand anothercommand = new SqlCommand(sqlExpression, connection);
                    SqlDataReader anotherreader = anothercommand.ExecuteReader();
                    if (anotherreader.HasRows)
                    {
                        while (anotherreader.Read())
                        {
                            commands.Add(sqlExpression = "SELECT * FROM Иллюстратор WHERE Код_иллюстратора = " + anotherreader.GetInt32(1));
                        }
                    }
                    anotherreader.Close();
                    for (int i = 0; i < commands.Count; i++)
                    {
                        string s = commands[i];
                        SqlCommand newcommand = new SqlCommand(s, connection);
                        SqlDataReader newreader = newcommand.ExecuteReader();
                        newreader.Read();
                        listBox1.Items.Add(newreader.GetString(2));
                        newreader.Close();
                    }
                }
            }
        }

        private void аккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            curacc = true;
            if(currentaccount.type == "Покупатель")
            {
                CustomerAccount acc = new CustomerAccount(curacc);
                acc.Show();
            }
            if (currentaccount.type == "Иллюстратор")
            {
                IllustratorAccount acc = new IllustratorAccount(curacc);
                acc.Show();
            }
        }

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }

        private void моиЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentaccount.type == "Покупатель")
            {
                CustomerOrders ord = new CustomerOrders();
                ord.Show();
            }
            if (currentaccount.type == "Иллюстратор")
            {
                IllustratorOrders ord = new IllustratorOrders();
                ord.Show();
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            curacc = false;
            if (listBox1.SelectedItem != null)
            {
                string curill = listBox1.SelectedItem.ToString();
                string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    string sqlExpression = "SELECT * FROM Иллюстратор WHERE Логин_иллюстратора = '" + curill + "'";
                    SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = commandread.ExecuteReader();
                    reader.Read();
                    long num = 0;
                    if (reader.GetValue(4) == DBNull.Value) num = 0;
                    else num = reader.GetInt64(4);
                    illustratoraccount = new Account(reader.GetInt32(0), reader.GetString(2), reader.GetString(3), reader.GetString(1), num, "Иллюстратор");
                }
                if (currentaccount.id == illustratoraccount.id && currentaccount.type == illustratoraccount.type) curacc = true;
                IllustratorAccount acc = new IllustratorAccount(curacc);
                acc.Show();
            }
        }

        private void LoadWork_Click(object sender, EventArgs e)
        {
            LoadWorkForm form = new LoadWorkForm();
            form.Show();
        }
    }
}
