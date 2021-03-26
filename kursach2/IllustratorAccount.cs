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
    public partial class IllustratorAccount : Form
    {
        bool current_acc;
        
        public void Update()
        {
            tagsListBox.Items.Clear();
            List<int> id_tags = new List<int>();
            if (current_acc)
            {
                IllustratorName.Text = Search.currentaccount.login;
                IllustratorEMail.Text = Search.currentaccount.email;
                PhoneNum.Text = Search.currentaccount.num.ToString();
                Makeorderbutton.Hide();
            }
            else
            {
                IllustratorName.Text = Search.illustratoraccount.login;
                IllustratorEMail.Text = Search.illustratoraccount.email;
                PhoneNum.Text = Search.illustratoraccount.num.ToString();
                AddTags.Hide();
                AddTag.Hide();
            }
            if (Search.currentaccount.type == "Иллюстратор") Makeorderbutton.Enabled = false;
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                string sqlExpression;
                if (current_acc)
                    sqlExpression = "SELECT * FROM Техники_исполнения_иллюстратора WHERE Код_иллюстратора = " + Search.currentaccount.id;
                else
                    sqlExpression = "SELECT * FROM Техники_исполнения_иллюстратора WHERE Код_иллюстратора = " + Search.illustratoraccount.id;
                SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = commandread.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id_tags.Add(reader.GetInt32(0));
                    }
                }
                reader.Close();
                if (id_tags.Count > 0)
                {
                    for (int i = 0; i < id_tags.Count; i++)
                    {
                        sqlExpression = "SELECT * FROM Техника_исполнения WHERE Код_техники_исполнения = " + id_tags[i];
                        commandread = new SqlCommand(sqlExpression, connection);
                        reader = commandread.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            tagsListBox.Items.Add(reader.GetString(1));
                        }
                        reader.Close();
                    }
                }
            }
        }
        public IllustratorAccount(bool curacc)
        {
            InitializeComponent();
            current_acc = curacc;
            Update();
        }

        private void Makeorderbutton_Click(object sender, EventArgs e)
        {
            MakeOrder ord = new MakeOrder();
            ord.Show();
        }

        private void checkportfolio_Click(object sender, EventArgs e)
        {
            Portfolio port = new Portfolio(current_acc);
            port.Show();
        }

        private void AddTags_Click(object sender, EventArgs e)
        {
            if(current_acc)
            {
            string new_tag = AddTag.Text;
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    string sqlExpression = "SELECT Код_техники_исполнения FROM Техника_исполнения WHERE Название_техники_исполнения = '" + new_tag + "' ";
                    SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = commandread.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int id = reader.GetInt32(0);
                        reader.Close();
                        sqlExpression = "SELECT * FROM Техники_исполнения_иллюстратора WHERE Код_техники_исполнения = " + id + "AND Код_иллюстратора = " + Search.currentaccount.id;
                        commandread = new SqlCommand(sqlExpression, connection);
                        reader = commandread.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            reader.Close();
                            command.CommandText = @"INSERT INTO Техники_исполнения_иллюстратора VALUES (@Код_техники_исполнения, @Код_иллюстратора)";
                            command.Parameters.Add("@Код_техники_исполнения", SqlDbType.Int);
                            command.Parameters.Add("@Код_иллюстратора", SqlDbType.Int);
                            command.Parameters["@Код_техники_исполнения"].Value = id;
                            command.Parameters["@Код_иллюстратора"].Value = Search.currentaccount.id;
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        reader.Close();
                        command.CommandText = @"INSERT INTO Техника_исполнения VALUES (@Название_техники_исполнения)";
                        command.Parameters.Add("@Название_техники_исполнения", SqlDbType.NVarChar, 255);
                        command.Parameters["@Название_техники_исполнения"].Value = new_tag;
                        command.ExecuteNonQuery();
                        sqlExpression = "SELECT IDENT_CURRENT('Техника_исполнения') AS [IDENT_CURRENT]";
                        commandread = new SqlCommand(sqlExpression, connection);
                        reader = commandread.ExecuteReader();
                        reader.Read();
                        int id = Int32.Parse(reader.GetValue(0).ToString());
                        reader.Close();
                        command.CommandText = @"INSERT INTO Техники_исполнения_иллюстратора VALUES (@Код_техники_исполнения, @Код_иллюстратора)";
                        command.Parameters.Add("@Код_техники_исполнения", SqlDbType.Int);
                        command.Parameters.Add("@Код_иллюстратора", SqlDbType.Int);
                        command.Parameters["@Код_техники_исполнения"].Value = id;
                        command.Parameters["@Код_иллюстратора"].Value = Search.currentaccount.id;
                        command.ExecuteNonQuery();
                    }
                }
                Update();
            }
        }

        private void socialmedia_Click(object sender, EventArgs e)
        {
            SocialMedia s = new SocialMedia(current_acc);
            s.Show();
        }
    }
}
