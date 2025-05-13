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
    public partial class New_Admin : Form
    {
        public New_Admin()
        {
            InitializeComponent();
        }

        Functions_RelatedBalance frb = new Functions_RelatedBalance();
        Functions_DB fd = new Functions_DB();

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_admin.Text == "" || pass_admin.Text == "")
            {
                MessageBox.Show("Enter Admin ID or Password");
            }
            else
            {
                int admin_id = int.Parse(id_admin.Text);
                string admin_pass = pass_admin.Text;

                bool result = frb.AddNewAdmin(admin_id, admin_pass);

                if (result)
                {
                    MessageBox.Show("New Admin added successfully.");
                    this.id_admin.Text = "";
                    this.pass_admin.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to add new admin.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (id_admin.Text == "")
            {
                MessageBox.Show("Enter Admin ID");
            }
            else
            {
                int admin_id = int.Parse(id_admin.Text);

                bool result = frb.DeleteAdmin(admin_id);

                if (result)
                {
                    MessageBox.Show("Admin deleted successfully.");
                    this.id_admin.Text = "";
                    this.pass_admin.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to add new admin.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fd.LoadData(dataGridView_admin, "admin_Login");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard ad = new Admin_Dashboard();
            ad.Show();
            this.Hide();
        }
    }
}
