using OOSD_Project.DBHandler;
using OOSD_Project.DBTableClass;
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
    public partial class frmAddNotification : Form
    {
        public frmAddNotification()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Notification n = new Notification();

            n.Content = notification_content.Text;
            n.Date = notification_rem_date.Value.Date;
            n.Employee_idemployee = Employee.employee_id;
            n.Employee_name = Employee.employee_name;
            n.Employee_number = Employee.emp_no;
            n.Title = notification_title.Text;
            n.User_iduser = int.Parse(LoginInfo.UserID);

            //Add a new notification

            bool state = NotificationHandler.addNotification(n);

            if (state)
            {
                MessageBox.Show("Notification added succesfully...!");
            }
            else
            {
                MessageBox.Show("Adding Notification failed...!");
            }

            
        }
    }
}
