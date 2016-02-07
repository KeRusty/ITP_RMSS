using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP_RMSS.View
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to go back?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Dashboard d = new Dashboard();
                d.Show();
                this.Close();
            }
            else
            {
                Staff i = new Staff();
                i.Show();
                this.Close();
            }
        }

        private void ExtButton_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result2 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Staff i = new Staff();
                i.Show();
                this.Close();
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}
