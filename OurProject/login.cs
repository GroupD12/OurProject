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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                hidebtn.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void hidebtn_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                showbtn.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
