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

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = ITP_RMSS.Properties.Resources.multiple25Hover;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = null;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = ITP_RMSS.Properties.Resources.cashierHover;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = null;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = ITP_RMSS.Properties.Resources.clerksHover;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = null;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = ITP_RMSS.Properties.Resources.deliveryHover;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = null;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = ITP_RMSS.Properties.Resources.list93Hover;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = null;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = ITP_RMSS.Properties.Resources.electionHover;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = null;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Image = ITP_RMSS.Properties.Resources.sell2Hover;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Image = null;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.Image = ITP_RMSS.Properties.Resources.shopping71Hover;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = null;
        }
    }
}
