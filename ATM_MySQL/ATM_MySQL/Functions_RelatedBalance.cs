using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ATM_MySQL
{
    internal class Functions_RelatedBalance
    {
        // Functions Related Balance

        string con_string = "server=127.0.0.1;uid=root;pwd=harry;database=atm_system";
        public void Show_Balance(int accid_dep)
        {
            try
            {
                double balance = 0;

                MySqlConnection conn = new MySqlConnection(con_string);
                conn.Open();
                string query = "SELECT accounts.balance FROM accounts where acc_id = @accid_dep";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accid_dep", accid_dep);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    balance = Convert.ToDouble(result);
                    MessageBox.Show("Current Balance: " + balance);
                }
                else { MessageBox.Show("Enter Valid Account ID"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                
            }

        }


        public bool DepositAmount(int acc_id, double amount)
        {
            MySqlTransaction transaction = null;
            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                conn.Open();
                transaction = conn.BeginTransaction();

                // Prepare the query to update the balance
                string updateBalanceQuery = "UPDATE accounts SET balance = balance + @amount WHERE acc_id = @acc_id";
                MySqlCommand updateBalanceCmd = new MySqlCommand(updateBalanceQuery, conn, transaction);
                updateBalanceCmd.Parameters.AddWithValue("@amount", amount);
                updateBalanceCmd.Parameters.AddWithValue("@acc_id", acc_id);

                // Execute the query to update the balance
                int rowsAffected = updateBalanceCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Prepare the query to insert into the transactions table
                    string insertTransactionQuery = "INSERT INTO transactions (acc_id, trans_type, trans_amount, trans_date, trans_time) VALUES (@acc_id, 'Deposit', @amount, CURDATE(), CURTIME())";
                    MySqlCommand insertTransactionCmd = new MySqlCommand(insertTransactionQuery, conn, transaction);
                    insertTransactionCmd.Parameters.AddWithValue("@acc_id", acc_id);
                    insertTransactionCmd.Parameters.AddWithValue("@amount", amount);

                    // Execute the query to insert into the transactions table
                    insertTransactionCmd.ExecuteNonQuery();

                    // Commit the transaction
                    transaction.Commit();
                    return true;
                }
                else
                {
                    transaction.Rollback();
                    return false;
                }
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }





        // Functions Related Admin
        public bool AddNewAdmin(int admin_id, string admin_pass)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                    conn.Open();
                    // Prepare the query to insert a new admin
                    string query = "INSERT INTO admin_Login (admin_id, admin_pass) VALUES (@admin_id, @admin_pass)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@admin_id", admin_id);
                    cmd.Parameters.AddWithValue("@admin_pass", admin_pass);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if the insert was successful
                    return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public bool DeleteAdmin(int admin_id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(con_string))
                {
                    conn.Open();
                    // Prepare the query to delete an admin by admin_id
                    string query = "DELETE FROM admin_Login WHERE admin_id = @admin_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@admin_id", admin_id);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if the delete was successful
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }


        // Transfer to Bank ( GET CASH ) Function

        public double GetAccountBalance(int acc_id)
        {
            double balance = 0.0;
            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                    conn.Open();
                    string query = "SELECT balance FROM accounts WHERE acc_id = @acc_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@acc_id", acc_id);

                    balance = Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return balance;
        }


        public bool TransferToBank(int acc_id, double amount, int bank_id)
        {
            double currentBalance = GetAccountBalance(acc_id);
            if (currentBalance < amount)
            {
                MessageBox.Show("Insufficient funds.");
                return false;
            }

            try
            {
                MySqlConnection conn = new MySqlConnection(con_string);
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Update user account balance
                        string updateAccountBalanceQuery = "UPDATE accounts SET balance = balance - @amount WHERE acc_id = @acc_id";
                        MySqlCommand updateAccountBalanceCmd = new MySqlCommand(updateAccountBalanceQuery, conn);
                        updateAccountBalanceCmd.Parameters.AddWithValue("@amount", amount);
                        updateAccountBalanceCmd.Parameters.AddWithValue("@acc_id", acc_id);
                        updateAccountBalanceCmd.ExecuteNonQuery();

                        // Update bank account balance
                        string updateBankBalanceQuery = "UPDATE bank_account SET bank_balance = bank_balance + @amount WHERE bank_id = @bank_id";
                        MySqlCommand updateBankBalanceCmd = new MySqlCommand(updateBankBalanceQuery, conn);
                        updateBankBalanceCmd.Parameters.AddWithValue("@amount", amount);
                        updateBankBalanceCmd.Parameters.AddWithValue("@bank_id", bank_id);
                        updateBankBalanceCmd.ExecuteNonQuery();

                        // Record the transaction
                        string insertTransactionQuery = "INSERT INTO transactions (acc_id, trans_type, trans_amount, trans_date, trans_time) VALUES (@acc_id, 'Transfer to Bank', @amount, @trans_date, @trans_time)";
                        MySqlCommand insertTransactionCmd = new MySqlCommand(insertTransactionQuery, conn);
                        insertTransactionCmd.Parameters.AddWithValue("@acc_id", acc_id);
                        insertTransactionCmd.Parameters.AddWithValue("@amount", amount);
                        insertTransactionCmd.Parameters.AddWithValue("@trans_date", DateTime.Now.ToString("yyyy-MM-dd"));
                        insertTransactionCmd.Parameters.AddWithValue("@trans_time", DateTime.Now.ToString("HH:mm:ss"));
                        insertTransactionCmd.ExecuteNonQuery();

                        transaction.Commit();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }




    }
}
