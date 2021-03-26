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
    public partial class CustomerAccount : Form
    {
        bool cur_acc;
        public CustomerAccount(bool curacc)
        {
            InitializeComponent();
            cur_acc = curacc;
            if (curacc)
            {
                CustomerName.Text = Search.currentaccount.login;
                Email.Text = Search.currentaccount.email;
                PhoneNum.Text = Search.currentaccount.num.ToString();
            }
        }

        private void SocialMediabutton_Click(object sender, EventArgs e)
        {
            SocialMedia s = new SocialMedia(cur_acc);
            s.Show();
        }
    }
}
