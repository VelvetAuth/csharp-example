using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auth_example
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            label1.Text = "username: " + Form1.vAuthApp.user_data.username.ToString();
            label2.Text = "email: " + Form1.vAuthApp.user_data.email.ToString();
            label3.Text = "expiry: " + Form1.vAuthApp.user_data.expires.ToString();
            label4.Text = "rank: " + Form1.vAuthApp.user_data.rank.ToString();
        }
    }
}
