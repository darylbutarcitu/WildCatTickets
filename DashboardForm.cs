using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace WildCatTickets
{
    public partial class DashboardForm : KryptonForm
    {
        private string loggedInUser;

        public DashboardForm(string username)
        {
            InitializeComponent();
            loggedInUser = username;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadForm(new ProfileForm(loggedInUser));
        }

        private void LoadForm(Form form)
        {
            kryptonPanelContainer.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            kryptonPanelContainer.Controls.Add(form);
            form.Show();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new ProfileForm(loggedInUser));
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new BrowseForm(loggedInUser));
        }

        private void myTicketsBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new LoginForm());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
