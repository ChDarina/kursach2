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
    public partial class SocialMedia : Form
    {
        ChangeSocialMedia socchange = null;
        List<int> id_soc = new List<int>();
        List<string> links = new List<string>();
        List<string> nameslinks = new List<string>();
        bool cur_acc;
        public void Update()
        {
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SocialMediaBox.Items.Clear();
                id_soc.Clear();
                links.Clear();
                nameslinks.Clear();
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                string sqlExpression = "";
                if (cur_acc)
                {
                    if (Search.currentaccount.type == "Иллюстратор") sqlExpression = "SELECT * FROM Соцсети_иллюстратора WHERE Код_иллюстратора = " + Search.currentaccount.id;
                    else sqlExpression = "SELECT * FROM Соцсети_покупателя WHERE Код_покупателя = " + Search.currentaccount.id;
                }
                else
                    sqlExpression = "SELECT * FROM Соцсети_иллюстратора WHERE Код_иллюстратора = " + Search.illustratoraccount.id;
                SqlCommand commandread = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = commandread.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id_soc.Add(reader.GetInt32(1));
                        links.Add(reader.GetString(2));
                    }
                }
                reader.Close();
                for (int i = 0; i < links.Count; i++)
                {
                    sqlExpression = "SELECT * FROM Соцсети WHERE Код_соцсети = " + id_soc[i];
                    commandread = new SqlCommand(sqlExpression, connection);
                    reader = commandread.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            nameslinks.Add(reader.GetString(1));
                        }
                    }
                    reader.Close();
                }
                for (int i = 0; i < links.Count; i++)
                {
                    SocialMediaBox.Items.Add(nameslinks[i] + " " + links[i]);
                }
            }
        }
        public SocialMedia(bool current_account)
        {
            InitializeComponent();
            cur_acc = current_account;
            Update();
        }

        private void SocialMediaBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string link = "";
            string namelink = "";
            int code = -1;
            if (cur_acc)
            {
                bool change;
                if (SocialMediaBox.SelectedIndex == -1)
                    change = false;
                else
                {
                    change = true;
                    link = links[SocialMediaBox.SelectedIndex];
                    code = id_soc[SocialMediaBox.SelectedIndex];
                    namelink = nameslinks[SocialMediaBox.SelectedIndex];
                }
                ChangeSocialMedia s = new ChangeSocialMedia(change, link, code, namelink, this);
                s.Show();
                Update();
            }
            Update();
        }

        private void SocialMedia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (socchange != null) socchange.Close();
        }
    }
}
