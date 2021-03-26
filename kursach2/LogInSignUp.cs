using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach2
{
    public partial class LogInSignUp : Form
    {
        public LogInSignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SignUpForm sign = new SignUpForm(this);
            sign.Show();
            Hide();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            LogInForm log = new LogInForm(this);
            log.Show();
            Hide();
        }
    }
}
