using VelvetAuth;

namespace auth_example
{
    public partial class Form1 : Form
    {

        public static api vAuthApp = new api(
            "1.0",//version
            "program key",//program key
            "program enc key",//program enc key
            show_messages: true);

        public Form1()
        {
            vAuthApp.init();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(vAuthApp.login(usernametb.Text, passwordtb.Text))
            {
                this.Hide();
                MessageBox.Show("Successfully logged in");
                main mainfrm = new main();
                mainfrm.ShowDialog();
                this.Close();
            }
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (vAuthApp.register(usernametb.Text, emailtb.Text, passwordtb.Text, licensetb.Text))
            {
                MessageBox.Show("Successfully registered please loggin now");
                
            }
        }

        private void all_in_onebtn_Click(object sender, EventArgs e)
        {
            if (vAuthApp.all_in_one(licensetb.Text))
            {
                this.Hide();
                MessageBox.Show("Successfully logged in");
                main mainfrm = new main();
                mainfrm.ShowDialog();
                this.Close();
            }
        }

        private void upgradebtn_Click(object sender, EventArgs e)
        {
            if (vAuthApp.activate( usernametb.Text,licensetb.Text))
            {
                this.Hide();
                MessageBox.Show("Successfully upgraded please loggin now.");
                main mainfrm = new main();
                mainfrm.ShowDialog();
                this.Close();
            }
        }
    }
}