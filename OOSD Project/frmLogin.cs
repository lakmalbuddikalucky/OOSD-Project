﻿using OOSD_Project.UserLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSD_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

            UserLog ul = new UserLog();

            ul.setUsername(username.Text);
            ul.setPassword(password.Text);

            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                return;
            }
            else 
            {
                bool r = LoginValidator.validateLogin(ul);
                
                if (r)
                {
                    frmMain form1 = new frmMain();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Credentials");
                }
            }
            

            
            
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
