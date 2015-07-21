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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmployeePersonalDetails form2 = new frmEmployeePersonalDetails();
            form2.Show();
            this.Dispose();

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginSession.expireSession(LoginInfo.UserID);

            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSearch form = new frmSearch();
            form.Show();
            this.Hide();
        }
    }
}
