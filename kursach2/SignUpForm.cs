using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach2
{
    public partial class SignUpForm : Form
    {
        LogInSignUp form;
        Account acc = null;
        public SignUpForm(LogInSignUp form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            form.Show();
        }
        private Account SaveFileToDatabase()
        {
            acc = null;
            string email = InsertEMail.Text;
            string login = InsertNickname.Text;
            string password = InsertPassword.Text;
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                if (CustomerChoice.Checked)
                {
                    if (email != "" && login != "" && password != "")
                    {
                        long phone = 0;
                        if (InsertPhone.Text != "") phone = Int64.Parse(InsertPhone.Text);
                        command.CommandText = @"INSERT INTO Покупатель VALUES (@Адрес_электронной_почты_покупателя, @Логин_покупателя, @Пароль_покупателя, @Номер_телефона_покупателя)";
                        command.Parameters.Add("@Адрес_электронной_почты_покупателя", SqlDbType.NVarChar, 255);
                        command.Parameters.Add("@Логин_покупателя", SqlDbType.NVarChar, 255);
                        command.Parameters.Add("@Пароль_покупателя", SqlDbType.NVarChar, 255);
                        command.Parameters.Add("@Номер_телефона_покупателя", SqlDbType.BigInt);
                        command.Parameters["@Адрес_электронной_почты_покупателя"].Value = email;
                        command.Parameters["@Логин_покупателя"].Value = login;
                        command.Parameters["@Пароль_покупателя"].Value = password;
                        if (InsertPhone.Text == "") command.Parameters["@Номер_телефона_покупателя"].Value = DBNull.Value;
                        else command.Parameters["@Номер_телефона_покупателя"].Value = phone;
                        command.ExecuteNonQuery();
                        string sqlExpression = "SELECT TOP 1 [Код_покупателя] FROM Покупатель ORDER BY Код_покупателя DESC";
                        SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = commandread.ExecuteReader();
                        reader.Read();
                        int id = reader.GetInt32(0);
                        acc = new Account(id, login, password, email, phone, "Покупатель");
                    }
                    else
                    {
                        if (email == "")
                            MessageBox.Show("Вы не ввели электронную почту!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (login == "")
                            MessageBox.Show("Вы не ввели логин!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (password == "")
                            MessageBox.Show("Вы не ввели пароль!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (IllustratorChoice.Checked)
                {
                    if (email != "" && login != "" && password != "")
                    {
                        long phone = 0;
                        if (InsertPhone.Text != "") phone = Int64.Parse(InsertPhone.Text);
                        command.CommandText = @"INSERT INTO Иллюстратор VALUES (@Адрес_электронной_почты_иллюстратора, @Логин_иллюстратора, @Пароль_иллюстратора, @Номер_телефона_иллюстратора)";
                        command.Parameters.Add("@Адрес_электронной_почты_иллюстратора", SqlDbType.NVarChar, 255);
                        command.Parameters.Add("@Логин_иллюстратора", SqlDbType.NVarChar, 255);
                        command.Parameters.Add("@Пароль_иллюстратора", SqlDbType.NVarChar, 255);
                        command.Parameters.Add("@Номер_телефона_иллюстратора", SqlDbType.BigInt);
                        command.Parameters["@Адрес_электронной_почты_иллюстратора"].Value = email;
                        command.Parameters["@Логин_иллюстратора"].Value = login;
                        command.Parameters["@Пароль_иллюстратора"].Value = password;
                        if (InsertPhone.Text == "") command.Parameters["@Номер_телефона_иллюстратора"].Value = DBNull.Value;
                        else command.Parameters["@Номер_телефона_иллюстратора"].Value = phone;
                        command.ExecuteNonQuery();
                        string sqlExpression = "SELECT TOP 1 [Код_иллюстратора] FROM Иллюстратор ORDER BY Код_иллюстратора DESC";
                        SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = commandread.ExecuteReader();
                        reader.Read();
                        int id = reader.GetInt32(0);
                        acc = new Account(id, login, password, email, phone, "Иллюстратор");
                    }
                    else
                    {
                        if (email == "")
                            MessageBox.Show("Вы не ввели электронную почту!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (login == "")
                            MessageBox.Show("Вы не ввели логин!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (password == "")
                            MessageBox.Show("Вы не ввели пароль!", "Ошибка при входе в аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return acc;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            acc = SaveFileToDatabase();
            if (acc != null)
            {
                Search search = new Search(acc, form);
                search.Show();
                this.Close();
            }
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (acc == null)
            {
                form.Show();
            }
        }
    }
}
