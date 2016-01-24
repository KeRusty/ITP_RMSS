using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITP_RMSS.Util;
using MySql.Data.MySqlClient;

namespace ITP_RMSS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtPass.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Sure You Want To Exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtUserID.Clear();
                txtPass.Clear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
            

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
