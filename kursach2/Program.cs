using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach2
{        
    public class Account
    {
        public int id { get; private set; }
        public string login { get; private set; }
        public string password { get; private set; }
        public string email { get; private set; }
        public long num { get; private set; }
        public string type { get; private set; }
        public Account(int id, string login, string password, string email, long num, string type)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.email = email;
            this.num = num;
            this.type = type;
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInSignUp());
        }
    }
}
