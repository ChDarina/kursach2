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
        public CustomerAccount(bool curacc)
        {
            InitializeComponent();
            if(curacc)
            {
                CustomerName.Text = Search.currentaccount.login;
                Email.Text = Search.currentaccount.email;
                PhoneNum.Text = Search.currentaccount.num.ToString();
            }
        }

        private void SocialMediabutton_Click(object sender, EventArgs e)
        {

        }
    }
}
