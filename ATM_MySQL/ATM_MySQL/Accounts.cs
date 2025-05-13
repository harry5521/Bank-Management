using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace ATM_MySQL
{
    public partial class Accounts : Form
    {
        Functions_DB df = new Functions_DB();
        public Accounts()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Load Data Button
            string Tname = comboBox1.SelectedItem.ToString(); // Please Dont click on Load Data button with Empty selection. Select a table in above list then press Load data.
            if(Tname == "")                                   // Remember, If you dont select table name so app will stuck.
            {
                MessageBox.Show("Fill all fields");
            } else
            {
                Functions_DB acc1 = new Functions_DB();
                acc1.LoadData(dataGridView1, Tname);
            }
            

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_Dashboard ad = new Admin_Dashboard();
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // User Details Button
            if (username.Text == "" || useremail.Text == "" || userdet.Text == "" || useridfk.Text == "")
            {
                MessageBox.Show("Fill all fields");
            }
            else
            {
                int detid = int.Parse(userdet.Text);
                int userid_fk = int.Parse(useridfk.Text);
                string user_name = username.Text;
                string user_email = useremail.Text;
                bool res = df.Insert_userDetails(detid, userid_fk,user_name, user_email);

                if (res == true)
                {
                    MessageBox.Show("User Data inserted successfully.");
                    this.username.Text = "";
                    this.useremail.Text = "";
                    this.userdet.Text = "";
                    this.useridfk.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to insert user Data.");
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // User Id / pass Button
            if (userid.Text == "" || userpass.Text == "")
            {
                MessageBox.Show("Fill all fields");
            }
            else
            {
                int userId = int.Parse(userid.Text);
                string userPass = userpass.Text;
                bool res = df.Insert_idpass(userId, userPass);

                if (res == true)
                {
                    MessageBox.Show("User login inserted successfully.");
                    this.userid.Text = "";
                    this.userpass.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to insert user login.");
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // User Account Button
            if (accid.Text == "" || userdetfk.Text == "" || acctype.Text == "" || accdate.Text == "")
            {
                MessageBox.Show("Fill all fields");
            }
            else
            {
                int acc_id = int.Parse(accid.Text);
                int userdet_fk = int.Parse(userdetfk.Text);
                string acc_type = acctype.Text;
                string acc_date = accdate.Text;
                bool res = df.Insert_AccountDetails(acc_id, userdet_fk, acc_type, acc_date);

                if (res == true)
                {
                    MessageBox.Show("Account Data inserted successfully.");
                    this.accid.Text = "";
                    this.userdetfk.Text = "";
                    this.acctype.Text = "";
                    this.accdate.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to insert Account Data.");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Update User Button
            if (userdetfkupdate.Text == "" || usernameupdate.Text == "" || useremailupdate.Text == "")
            {
                MessageBox.Show("Fill all fields");
            }
            else
            {
                int userdetfk_update = int.Parse(userdetfkupdate.Text);
                string username_update = usernameupdate.Text;
                string useremail_update = useremailupdate.Text;
                bool res = df.Update_UserDetails(userdetfk_update, username_update, useremail_update);

                if (res == true)
                {
                    MessageBox.Show("User Data Updated Successfully.");
                    this.userdetfkupdate.Text = "";
                    this.usernameupdate.Text = "";
                    this.useremailupdate.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to Update user Data.");
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Delete User Button
            if (userid_delete.Text == "")
            {
                MessageBox.Show("Insert user id");
            }
            else
            {
                int userid_deleted = int.Parse(userid_delete.Text);

                bool res = df.Delete_User(userid_deleted);

                if (res == true)
                {
                    MessageBox.Show("User Data Deleted Successfully.");
                    this.userid_delete.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to Delete user Data.");
                }
            }

        }
    }
}
