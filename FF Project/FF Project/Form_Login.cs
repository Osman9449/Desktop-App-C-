using FF_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_App
{
    public partial class Form_Login : Form
    {
        DbConnector connector = new DbConnector();
        public Form_Login()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName= textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (connector.DoesUserNameExist(userName))
            {
               string storedPassword = connector.GetStoredPassword(userName);
                if (storedPassword.Equals(password)) {
                    Form_Management form_Management = new Form_Management();
                    form_Management.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password isn't correct ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This username isn't registered ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
