using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ATM_MySQL
{
    public partial class Transactions_View : Form
    {
        public Transactions_View()
        {
            InitializeComponent();
        }

        Functions_DB df = new Functions_DB();

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard ad = new Admin_Dashboard();
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Load Data Button
            df.Transactions_Data(dataGridView2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Transaction View by Account id
            if (viewtransid.Text == "")
            {
                MessageBox.Show("Insert Account ID");
            }
            else
            {
                int trans_id = int.Parse(viewtransid.Text);
                df.Transactions_Data_AccID(dataGridView2, trans_id);
                this.viewtransid.Text = "";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Transaction View by date
            if (viewtransdate.Text == "")
            {
                MessageBox.Show("Insert Date");
            }
            else
            {
                string date = DateTime.Parse(viewtransdate.Text).ToString("yyyy-MM-dd");
                df.Transactions_Data_Datee(dataGridView2, date);
                this.viewtransdate.Text = "";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Transaction View by Amount Between
            if (viewtransbet1.Text == "" || viewtransbet2.Text == "")
            {
                MessageBox.Show("Fill both Fields");
            }
            else
            {
                int amount1 = int.Parse(viewtransbet1.Text);
                int amount2 = int.Parse(viewtransbet2.Text);
                df.Transactions_Data_Between(dataGridView2, amount1, amount2);
                this.viewtransbet1.Text = "";
                this.viewtransbet2.Text = "";

            }
        }
    }
}
