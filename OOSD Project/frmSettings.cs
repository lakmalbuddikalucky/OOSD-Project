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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*UserLog ul = new UserLog();
            ul.setUsername();
            ul.setPassword(new_password.Text);
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
            }*/
        }
    }
}
