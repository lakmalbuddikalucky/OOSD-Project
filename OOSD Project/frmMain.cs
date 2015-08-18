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
        private static frmMain form;

        public frmMain()
        {
            InitializeComponent();
            frmEmployeePersonalDetails.getForm();
            frmSearch.getForm();
            frmEmployeeSpecialDetails.getForm();
            frmEmployeeFinanceDetails.getForm();
            frmEmployeeRemunerationAndBenefits.getForm();
            frmPassportDetails.getForm();
            frmDisciplinaryDetails.getForm();
            frmInterdict_Suspend.getForm();
            frmJobStatus.getForm();
            frmPension_Death.getForm();
            frmRe_Appointment.getForm();
            frmResignation.getForm();
            frmTraining.getForm();
            frmTransport.getForm();
            frmMain.form = this;
        }

        public static frmMain getForm()
        {
            if (form == null)
            {
                form = new frmMain();
            }
            return form;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmEmployeePersonalDetails.getForm().Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (!(LoginInfo.UserID == "ozious"))
            {
                LoginSession.expireSession(LoginInfo.UserID);
            }

            frmLogin form1 = new frmLogin();
            form1.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //frmSearch form = new frmSearch();
            //form.Show();
            frmSearch.getForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNotifications form = new frmNotifications();
            form.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            
        
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            frmSettings formSettings = new frmSettings();
            formSettings.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAddUser formAdd = new frmAddUser();
            formAdd.Show();
            this.Hide();
        }
    }
}
