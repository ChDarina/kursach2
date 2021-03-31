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
    public partial class LogInForm : Form
    {
        Account acc = null;
        LogInSignUp form;
        public LogInForm(LogInSignUp form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            form.Show();
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (acc == null)
                form.Show();
        }

        private Account LogInDatabase()
        {
            acc = null;
            string login = InsertLogin.Text;
            string password = InsertPassword.Text;
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                if (CustomerChoice.Checked)
                {
                    if (login!="" && password!="")
                    {
                        string sqlExpression = "SELECT * FROM Покупатель WHERE Логин_покупателя = '" + login + "' AND Пароль_покупателя = '" + password + "'";
                        SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = commandread.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            long num = 0;
                            if (reader.GetValue(4) == DBNull.Value) num = 0;
                            else num = reader.GetInt64(4);
                            acc = new Account(reader.GetInt32(0), reader.GetString(2), reader.GetString(3), reader.GetString(1), num, "Покупатель");
                        }
                        else
                        {
                            MessageBox.Show("Неправильный логин или пароль!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            InsertLogin.Clear();
                            InsertPassword.Clear();
                        }
                    }
                    else if(login == "" && password == "")
                        MessageBox.Show("Вы не ввели пароль и логин!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if(login == "")
                        MessageBox.Show("Вы не ввели логин!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if(password == "")
                        MessageBox.Show("Вы не ввели пароль!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (IllustratorChoice.Checked)
                {
                    if (login != "" && password != "")
                    {
                        string sqlExpression = "SELECT * FROM Иллюстратор WHERE Логин_иллюстратора = '" + login + "' AND Пароль_иллюстратора = '" + password + "'";
                        SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = commandread.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            long num = 0;
                            if (reader.GetValue(4) == DBNull.Value) num = 0;
                            else num = reader.GetInt64(4);
                            acc = new Account(reader.GetInt32(0), reader.GetString(2), reader.GetString(3), reader.GetString(1), num, "Иллюстратор");
                        }
                        else
                        {
                            MessageBox.Show("Неправильный логин или пароль!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            InsertLogin.Clear();
                            InsertPassword.Clear();
                        }
                    }
                    else if (login == "" && password == "")
                        MessageBox.Show("Вы не ввели пароль и логин!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (login == "")
                        MessageBox.Show("Вы не ввели логин!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (password == "")
                        MessageBox.Show("Вы не ввели пароль!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            return acc;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            acc = LogInDatabase();
            if (acc != null)
            {
                Search search = new Search(acc, form);
                search.Show();
                this.Close();
            }
        }
    }
}
