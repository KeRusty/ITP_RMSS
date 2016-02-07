using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ITP_RMSS.View;

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
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                MessageBox.Show("UserID Field is empty, Please Check!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserID.Focus();
                return;
            }

            try
            {
                AppDataTableAdapters.loginTableAdapter login = new AppDataTableAdapters.loginTableAdapter();
                AppData.loginDataTable dt = login.login(txtUserID.Text, txtPass.Text);
                if (dt.Rows.Count > 0)
                {                    
                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Access Denied", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPass.Focus();
                
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin.PerformClick();

        }
    }
}
