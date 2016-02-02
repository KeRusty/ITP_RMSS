using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITP_RMSS.View;

namespace ITP_RMSS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButtons.YesNo);
            if (result2 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Dashboard d2 = new Dashboard();
                d2.Show();
                this.Close();
            }
        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to go back?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Login l = new Login();
                l.Show();
                this.Close();
            }
            else
            {
                Dashboard d = new Dashboard();
                d.Show();
                this.Close();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            i.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Financial f = new Financial();
            f.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Delivery d = new Delivery();
            d.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Orders o = new Orders();
            o.Show();
            this.Close();
        }
    }
}
