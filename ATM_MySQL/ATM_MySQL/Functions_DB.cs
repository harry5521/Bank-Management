using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATM_MySQL
{
    internal class Functions_DB
    {


        string con_string = "server=127.0.0.1;uid=root;pwd=harry;database=atm_system";

        // Connection Function
        public void check_connection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(this.con_string);
                conn.Open();
                MessageBox.Show("Connect to ATM System Database");
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }

        // Read Function

        public int Login(int id, string pass)
        {
            MySqlConnection conn = new MySqlConnection(this.con_string);

            try
            {
                conn.Open();

                // Check in user_Login table
                string query = "SELECT COUNT(*) FROM user_Login WHERE user_id = @idd AND user_pass = @passs";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idd", id);
                cmd.Parameters.AddWithValue("@passs", pass);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    return 2; // User login successful
                }
                else
                {
                    // Check in admin_Login table
                    string qry = "SELECT COUNT(*) FROM admin_Login WHERE admin_id = @idd AND admin_pass = @passs";
                    MySqlCommand cmdd = new MySqlCommand(qry, conn);

                    cmdd.Parameters.AddWithValue("@idd", id);
                    cmdd.Parameters.AddWithValue("@passs", pass);

                    int countt = Convert.ToInt32(cmdd.ExecuteScalar());
                    if (countt > 0)
                    {
                        return 1; // Admin login successful
                    }
                    else
                    {
                        return 3; // Login failed
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                Console.WriteLine("Error: " + ex.Message);
                return 3; // Indicate failure due to exception
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // Data Grid View Accounts Table
        public void LoadData(DataGridView dataGridView, string Tname)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                conn.Open();

                // Use string concatenation to include the table name in the query
                string query = $"SELECT * FROM {Tname}";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;  // Set the DataSource of the passed DataGridView

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // CRUD Functions in Admin Page

        // Insert ID / Pass
        public bool Insert_idpass(int id, string pass)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                conn.Open();
                string query = "INSERT INTO user_Login (user_id, user_pass) values (@id, @pass)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@pass", pass);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

        }

        // Insert user details
        public bool Insert_userDetails(int detid, int userid, string name, string email)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                conn.Open();
                string query = "INSERT INTO user_details values (@detid, @userid, @name, @email)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@detid", detid);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

        }

        // Insert Account Details
        public bool Insert_AccountDetails(int acc_id, int userdetfk, string acc_type, string acc_date)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                conn.Open();
                string query = "INSERT INTO accounts (acc_id, det_id, acc_type, acc_date) values (@acc_id, @userdetfk, @acc_type, @acc_date)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@acc_id", acc_id);
                cmd.Parameters.AddWithValue("@userdetfk", userdetfk);
                cmd.Parameters.AddWithValue("@acc_type", acc_type);
                cmd.Parameters.AddWithValue("@acc_date", acc_date);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

        }

        // Update User Details
        public bool Update_UserDetails(int userdet_up, string username_up, string useremail_up)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                conn.Open();
                string query = "UPDATE atm_system.user_details SET user_name = @username_up, user_email = @useremail_up WHERE det_id = @userdet_up";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userdet_up", userdet_up);
                cmd.Parameters.AddWithValue("@username_up", username_up);
                cmd.Parameters.AddWithValue("@useremail_up", useremail_up);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }

        }

        // Delete User
        public bool Delete_User(int user_id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(con_string))
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        // Delete from accounts table first
                        string accQuery = @"
                DELETE FROM accounts 
                WHERE det_id IN (SELECT det_id FROM user_details WHERE user_id = @user_id)";
                        MySqlCommand accCmd = new MySqlCommand(accQuery, conn, transaction);
                        accCmd.Parameters.AddWithValue("@user_id", user_id);
                        int accRowsAffected = accCmd.ExecuteNonQuery();

                        // Delete from user_details table
                        string userDetailsQuery = "DELETE FROM user_details WHERE user_id = @user_id";
                        MySqlCommand userDetailsCmd = new MySqlCommand(userDetailsQuery, conn, transaction);
                        userDetailsCmd.Parameters.AddWithValue("@user_id", user_id);
                        int userDetailsRowsAffected = userDetailsCmd.ExecuteNonQuery();

                        // Delete from user_Login table
                        string userLoginQuery = "DELETE FROM user_Login WHERE user_id = @user_id";
                        MySqlCommand userLoginCmd = new MySqlCommand(userLoginQuery, conn, transaction);
                        userLoginCmd.Parameters.AddWithValue("@user_id", user_id);
                        int loginRowsAffected = userLoginCmd.ExecuteNonQuery();

                        // Check if all deletions were successful
                        if (loginRowsAffected > 0 && userDetailsRowsAffected > 0 && accRowsAffected > 0)
                        {
                            transaction.Commit();
                            return true;
                        }
                        else
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        // Transaction Table Code

        // Data Grid View
        public void Transactions_Data(DataGridView dataGridView)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                conn.Open();

                // Use string concatenation to include the table name in the query
                string query = "SELECT * FROM transactions";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;  // Set the DataSource of the passed DataGridView

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void Transactions_Data_AccID(DataGridView dataGridView, int trans_accid)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                conn.Open();

                // Use string concatenation to include the table name in the query
                string query = $"SELECT * FROM transactions WHERE acc_id = {trans_accid}";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;  // Set the DataSource of the passed DataGridView

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public void Transactions_Data_Datee(DataGridView dataGridView, string date)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                conn.Open();

                // Use parameterized query to avoid SQL injection and format issues
                string query = "SELECT * FROM transactions WHERE trans_date = @date";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", date);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;  // Set the DataSource of the passed DataGridView

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void Transactions_Data_Between(DataGridView dataGridView, double amt1, double amt2)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                conn.Open();

                // Use parameterized query to avoid SQL injection
                string query = "SELECT * FROM transactions WHERE trans_amount BETWEEN @amt1 AND @amt2";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@amt1", amt1);
                cmd.Parameters.AddWithValue("@amt2", amt2);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;  // Set the DataSource of the passed DataGridView

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



    }

}

