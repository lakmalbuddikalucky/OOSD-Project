using OOSD_Project.DBHandler;
using OOSD_Project.DBTableClass;
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
    public partial class frmPassportDetails : Form
    {
        private static frmPassportDetails form;

        public frmPassportDetails()
        {
            InitializeComponent();

            if (!(Employee.emp_no == null))
            {
                employee_no.Text = Employee.emp_no;
                full_name.Text = Employee.employee_name;
            }

        }

        public static frmPassportDetails getForm()
        {
            if (form == null)
            {
                form = new frmPassportDetails();
            }
            return form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Passport p = new Passport();

            p.number = passport_no.Text;
            p.place_of_issue = passport_issued_place.Text;
            p.post = passport_post.Text;
            p.rank = passport_rank.Text;
            p.setdate_of_issue(passport_issued_date.Value.Date);
            p.setdate_of_renewal(passport_renewal_date.Value.Date);

            if (passport_status_active.Checked) { p.status = true; }
            else { p.status = false; }

            bool state = PassportHandler.addPassport(p);

            if (state)
            {
                MessageBox.Show("Employee passport details added succesfully...!");

            }
            else
            {
                MessageBox.Show("Adding employee personal pasport failed...!");
            }
            //frmMain.getForm().Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmEmployeeRemunerationAndBenefits.getForm().Show();
            this.Hide();
        }

    }
}
