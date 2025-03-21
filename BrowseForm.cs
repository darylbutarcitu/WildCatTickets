using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;

namespace WildCatTickets
{
    public partial class BrowseForm: KryptonForm
    {
        public BrowseForm(string username)
        {
            InitializeComponent();
        }

        private void BrowseForm_Load(object sender, EventArgs e)
        {

        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {
            seatplanBox.Visible = true;
        }
    }
}
