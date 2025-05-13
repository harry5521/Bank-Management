namespace ATM_MySQL
{
    partial class Accounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.userid = new System.Windows.Forms.TextBox();
            this.userpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.useremail = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.acctype = new System.Windows.Forms.TextBox();
            this.accid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.accdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.useremailupdate = new System.Windows.Forms.TextBox();
            this.usernameupdate = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.userdet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.useridfk = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.userdetfk = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.userdetfkupdate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.userid_delete = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(372, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add User Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(175, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 64);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add User Id / Pass";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(567, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 64);
            this.button6.TabIndex = 6;
            this.button6.Text = "Add User Account";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(761, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 64);
            this.button4.TabIndex = 7;
            this.button4.Text = "Update User Details";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(953, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 64);
            this.button5.TabIndex = 8;
            this.button5.Text = "Delete User Details";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SteelBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(30, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 44);
            this.button7.TabIndex = 9;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(175, 67);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(176, 26);
            this.userid.TabIndex = 10;
            this.userid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userpass
            // 
            this.userpass.Location = new System.Drawing.Point(175, 128);
            this.userpass.Name = "userpass";
            this.userpass.Size = new System.Drawing.Size(176, 26);
            this.userpass.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "User Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(367, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "User Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(367, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "User Name";
            // 
            // useremail
            // 
            this.useremail.Location = new System.Drawing.Point(372, 253);
            this.useremail.Name = "useremail";
            this.useremail.Size = new System.Drawing.Size(176, 26);
            this.useremail.TabIndex = 15;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(372, 191);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(176, 26);
            this.username.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(563, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Account Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(563, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Account ID";
            // 
            // acctype
            // 
            this.acctype.Location = new System.Drawing.Point(567, 191);
            this.acctype.Name = "acctype";
            this.acctype.Size = new System.Drawing.Size(176, 26);
            this.acctype.TabIndex = 19;
            // 
            // accid
            // 
            this.accid.Location = new System.Drawing.Point(567, 67);
            this.accid.Name = "accid";
            this.accid.Size = new System.Drawing.Size(176, 26);
            this.accid.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(563, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Account Date";
            // 
            // accdate
            // 
            this.accdate.Location = new System.Drawing.Point(567, 253);
            this.accdate.Name = "accdate";
            this.accdate.Size = new System.Drawing.Size(176, 26);
            this.accdate.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(757, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "User Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SteelBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(757, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "User Name";
            // 
            // useremailupdate
            // 
            this.useremailupdate.Location = new System.Drawing.Point(761, 191);
            this.useremailupdate.Name = "useremailupdate";
            this.useremailupdate.Size = new System.Drawing.Size(176, 26);
            this.useremailupdate.TabIndex = 25;
            // 
            // usernameupdate
            // 
            this.usernameupdate.Location = new System.Drawing.Point(761, 128);
            this.usernameupdate.Name = "usernameupdate";
            this.usernameupdate.Size = new System.Drawing.Size(176, 26);
            this.usernameupdate.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "user_Login",
            "user_details",
            "accounts",
            "transactions"});
            this.comboBox1.Location = new System.Drawing.Point(39, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 28);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SteelBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(367, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 22);
            this.label11.TabIndex = 32;
            this.label11.Text = "User Detail ID";
            // 
            // userdet
            // 
            this.userdet.Location = new System.Drawing.Point(372, 67);
            this.userdet.Name = "userdet";
            this.userdet.Size = new System.Drawing.Size(176, 26);
            this.userdet.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.SteelBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(367, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 22);
            this.label12.TabIndex = 35;
            this.label12.Text = "User ID";
            // 
            // useridfk
            // 
            this.useridfk.Location = new System.Drawing.Point(372, 128);
            this.useridfk.Name = "useridfk";
            this.useridfk.Size = new System.Drawing.Size(176, 26);
            this.useridfk.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.SteelBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(563, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 22);
            this.label13.TabIndex = 37;
            this.label13.Text = "User Detail ID";
            // 
            // userdetfk
            // 
            this.userdetfk.Location = new System.Drawing.Point(567, 128);
            this.userdetfk.Name = "userdetfk";
            this.userdetfk.Size = new System.Drawing.Size(176, 26);
            this.userdetfk.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(757, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 22);
            this.label10.TabIndex = 39;
            this.label10.Text = "User Detail ID";
            // 
            // userdetfkupdate
            // 
            this.userdetfkupdate.Location = new System.Drawing.Point(761, 67);
            this.userdetfkupdate.Name = "userdetfkupdate";
            this.userdetfkupdate.Size = new System.Drawing.Size(176, 26);
            this.userdetfkupdate.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.SteelBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(948, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 22);
            this.label14.TabIndex = 47;
            this.label14.Text = "User ID";
            // 
            // userid_delete
            // 
            this.userid_delete.Location = new System.Drawing.Point(953, 67);
            this.userid_delete.Name = "userid_delete";
            this.userid_delete.Size = new System.Drawing.Size(176, 26);
            this.userid_delete.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.userid_delete);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.userdetfkupdate);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.userdetfk);
            this.panel1.Controls.Add(this.userid);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.userpass);
            this.panel1.Controls.Add(this.useridfk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.userdet);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.useremail);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.useremailupdate);
            this.panel1.Controls.Add(this.accid);
            this.panel1.Controls.Add(this.usernameupdate);
            this.panel1.Controls.Add(this.acctype);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.accdate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-5, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 623);
            this.panel1.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(362, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(387, 48);
            this.label15.TabIndex = 49;
            this.label15.Text = "ACCOUNTS SETTINGS";
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 710);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Name = "Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.TextBox userpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox useremail;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox acctype;
        private System.Windows.Forms.TextBox accid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox accdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox useremailupdate;
        private System.Windows.Forms.TextBox usernameupdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userdet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox useridfk;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox userdetfk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox userdetfkupdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox userid_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
    }
}