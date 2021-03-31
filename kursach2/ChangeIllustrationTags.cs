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
    public partial class ChangeIllustrationTags : Form
    {
        public void Update()
        {
            tagsListBox.Items.Clear();
            List<int> id_tags = new List<int>();
            string connectionString = @"Data Source=LAPTOP-96NT0MPR;Initial Catalog=kursach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                string sqlExpression = "SELECT * FROM Техники_исполнения_иллюстратора WHERE Код_иллюстратора = " + Search.currentaccount.id;
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
        public ChangeIllustrationTags()
        {
            InitializeComponent();
        }

        private void AddTags_Click(object sender, EventArgs e)
        {

        }
    }
}
