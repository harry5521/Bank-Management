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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        // Classes and Variables
        Functions_DB user1 = new Functions_DB();
        int Login_user_id;
        string Login_user_pass;


        private void button1_Click(object sender, EventArgs e)
        {
            user1.check_connection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                    int res = user1.Login(Login_user_id, Login_user_pass);

                    if(res == 1)
                    {
                        MessageBox.Show("Login as an Admin");
                        Admin_Dashboard admin = new Admin_Dashboard();
                        admin.Show();
                        this.Hide();

                    } else if(res == 2)
                    {
                        MessageBox.Show("Login as a User");
                        Dashboard_Form dboard = new Dashboard_Form();
                        dboard.Show();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("Enter Valid Id or Password");
                    }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            if (int.TryParse(str, out this.Login_user_id))
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Login_user_pass = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
