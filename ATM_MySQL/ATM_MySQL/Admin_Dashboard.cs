using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_MySQL
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            // Update date label
            date_label.Text = DateTime.Now.ToString("dd MMMM yyyy");
            // Update day label
            day_label.Text = DateTime.Now.ToString("dddd");

            panel_admin.SendToBack();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            New_Admin na = new New_Admin();
            na.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout your Account", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Login_form login = new Login_form();
                login.Show();
                this.Hide();
            }
        }

        private void panel_admin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accounts ac = new Accounts();
            ac.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Transactions_View tv = new Transactions_View();
            tv.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deposite_Admin da = new Deposite_Admin();
            da.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetCash_Admin ga = new GetCash_Admin();
            ga.Show();
            this.Hide();
        }
    }
}
