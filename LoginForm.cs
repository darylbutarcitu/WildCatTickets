using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace WildCatTickets
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           this.Size = new Size(665, 345);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = idNumberTbx.Text;
            string password = passwordTbx.Text;

            if (username == "24-5865-705" && password == "1234") // Dummy login check
            {
                DashboardForm dashboard = new DashboardForm(username);
                this.Hide();
                dashboard.ShowDialog(); 
                this.Show();
                idNumberTbx.Text = "";
                passwordTbx.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void idNumberTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void passwordTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
