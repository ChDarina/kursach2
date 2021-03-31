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
    public partial class ChangeSocialMedia : Form
    {
        SocialMedia prev_form;
        bool change;
        string thislink = "";
        string thislinkname = "";
        int thiscode = -1;
        public ChangeSocialMedia(bool change_orig, string link = "", int code=-1, string namelink = "", SocialMedia form = null)
        {
            InitializeComponent();
            prev_form = form;
            change = change_orig;
            thislink = link;
            thislinkname = namelink;
            thiscode = code;
            if (change)
            {
                SocialMediaName.Text = namelink;
                SocialMediaRef.Text = link;
                SocialMediaName.Enabled = false;
            }           
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (SocialMediaName.Text != "" && SocialMediaRef.Text != "")
            {
                thislink = SocialMediaRef.Text;
                thislinkname = SocialMediaName.Text;
                if (change)
                {
                    string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        string sqlExpression;
                        if (Search.currentaccount.type == "Иллюстратор") sqlExpression = "UPDATE Соцсети_иллюстратора SET Ссылка_на_соцсеть_иллюстратора = '" + thislink + "' WHERE Код_соцсети = " + thiscode + "AND Код_иллюстратора = " + Search.currentaccount.id;
                        else sqlExpression = "UPDATE Соцсети_покупателя SET Ссылка_на_соцсеть_покупателя = '" + thislink + "' WHERE Код_соцсети = " + thiscode + "AND Код_покупателя = " + Search.currentaccount.id;
                        SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                        commandread.ExecuteNonQuery();
                    }
                }
                else
                {
                    string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        string sqlExpression = "SELECT * FROM Соцсети WHERE Название_соцсети = '" + SocialMediaName.Text + "'";
                        SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = commandread.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            thiscode = reader.GetInt32(0);
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();
                            command = new SqlCommand();
                            command.Connection = connection;
                            command.CommandText = @"INSERT INTO Соцсети VALUES (@Название_соцсети)";
                            command.Parameters.Add("@Название_соцсети", SqlDbType.NVarChar, 255);
                            command.Parameters["@Название_соцсети"].Value = thislinkname;
                            command.ExecuteNonQuery();
                            sqlExpression = "SELECT IDENT_CURRENT('Соцсети') AS [IDENT_CURRENT]";
                            commandread = new SqlCommand(sqlExpression, connection);
                            reader = commandread.ExecuteReader();
                            reader.Read();
                            thiscode = reader.GetInt32(0);
                            reader.Close();
                        }
                        command = new SqlCommand();
                        command.Connection = connection;
                        if (Search.currentaccount.type == "Иллюстратор")
                        {
                            command.CommandText = @"INSERT INTO Соцсети_Иллюстратора VALUES (@Код_иллюстратора, @Код_соцсети, @Ссылка_на_соцсеть_иллюстратора)";
                            command.Parameters.Add("@Код_иллюстратора", SqlDbType.Int);
                            command.Parameters.Add("@Код_соцсети", SqlDbType.Int);
                            command.Parameters.Add("@Ссылка_на_соцсеть_иллюстратора", SqlDbType.NVarChar, 255);
                            command.Parameters["@Код_иллюстратора"].Value = Search.currentaccount.id;
                            command.Parameters["@Код_соцсети"].Value = thiscode;
                            command.Parameters["@Ссылка_на_соцсеть_иллюстратора"].Value = thislink;
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            command.CommandText = @"INSERT INTO Соцсети_Покупателя VALUES (@Код_покупателя, @Код_соцсети, @Ссылка_на_соцсеть_покупателя)";
                            command.Parameters.Add("@Код_покупателя", SqlDbType.Int);
                            command.Parameters.Add("@Код_соцсети", SqlDbType.Int);
                            command.Parameters.Add("@Ссылка_на_соцсеть_покупателя", SqlDbType.NVarChar, 255);
                            command.Parameters["@Код_покупателя"].Value = Search.currentaccount.id;
                            command.Parameters["@Код_соцсети"].Value = thiscode;
                            command.Parameters["@Ссылка_на_соцсеть_покупателя"].Value = thislink;
                            command.ExecuteNonQuery();
                        }
                    }
                }
                prev_form.Update();
                Close();
            }
            else MessageBox.Show("Попытка пустого ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
