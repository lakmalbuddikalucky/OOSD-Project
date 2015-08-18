using OOSD_Project.Database;
using OOSD_Project.UserLogin;
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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
            loadEmployeeNICs();
            loadEmployeeNumbers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain form = new frmMain();
            form.Show();
            this.Hide();
        }


        private void loadEmployeeNumbers()
        {
            //Load employee numbers to combo box
            List<string> em_nos = EmployeeHandler.getAllEmployeeNumbers();
            employee_no.Text = "Select employee number";

            if (!(em_nos == null))
            {
                foreach (string Txt in em_nos)
                {
                    employee_no.Items.Add(Txt);
                }
            }
        }


        private void loadEmployeeNICs()
        {
            //Load employee numbers to combo box
            List<string> em_nic = EmployeeHandler.getAllEmployeeNIC();
            employee_nic.Text = "Select employee number";

            if (!(em_nic == null))
            {
                foreach (string Txt in em_nic)
                {
                    employee_nic.Items.Add(Txt);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            UserLog ul = new UserLog();
            ul.setUsername(username.Text);
            ul.setPassword(password.Text);
            ul.setEmp_no(employee_no.Text);

            string status = UserHandler.addUser(ul);

            if(status=="success"){
                MessageBox.Show("New user added successfully...!");
            }
            else if (status == "user exists")
            {
                MessageBox.Show("User already exists. Please add a new user.");
            }
            else
            {
                MessageBox.Show("Failed to add user.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserLog ul = new UserLog();
            ul.setUsername(username.Text);
            ul.setPassword(password.Text);
            ul.setEmp_no(employee_no.Text);

            string status = UserHandler.updateUser(ul);

            if (status == "success")
            {
                MessageBox.Show("User updated successfully...!");
            }
            else if (status == "user does not exist")
            {
                MessageBox.Show("User does not exists. Please add a new user.");
            }
            else
            {
                MessageBox.Show("Failed to update user.");
            }
        }

        private void employee_no_SelectedIndexChanged(object sender, EventArgs e)
        {

            //EmployeeHandler.getEmployee();

        }

    }
}
