using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurProject
{
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }

        private void homeform_Click(object sender, EventArgs e)
        {
            home hm = new home();
            this.Hide();
            hm.ShowDialog();
        }

        private void usersform_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            this.Hide();
            user.ShowDialog();
        }
    }
}
