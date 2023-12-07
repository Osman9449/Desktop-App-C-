namespace Desktop_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Form_Register form_Register = new Form_Register();
            form_Register.ShowDialog();
            this.Hide();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog();
            this.Hide();
        }
    }
}
