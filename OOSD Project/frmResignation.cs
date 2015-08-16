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
    public partial class frmResignation : Form
    {
        private static frmResignation form;

        public frmResignation()
        {
            InitializeComponent();

            employee_no.Text = Employee.emp_no;
            full_name.Text = Employee.employee_name;
            resignation_employee_no.Text = Employee.emp_no;
            resignation_full_name.Text = Employee.employee_name;

            if (!(ResignationHandler.getResignation() == null))
            {
                loadDetails();
            }
        }

        public static frmResignation getForm()
        {
            if (form == null)
            {
                form = new frmResignation();
            }
            return form;
        }


        public void loadDetails()
        {

            Resignation r = ResignationHandler.getResignation();

            resignation_letter.Text = r.resignation_letter;
            resignation_letter_submitted_date.Value = r.letter_submitted_date;
            resignation_post.Text = r.post;
            resignation_rank.Text = r.rank;
            resignation_reason.Text = r.reason;
            resignation_date.Value = r.resignation_date;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool r_present = true;
            if (ResignationHandler.getResignation() == null)
            {
                r_present = false;
            }

            Resignation r = null;

            if (!r_present)
            {
                r = new Resignation();
            }
            else
            {
                r = ResignationHandler.getResignation();
            }

            r.letter_submitted_date = resignation_letter_submitted_date.Value.Date;
            r.post = resignation_post.Text;
            r.rank = resignation_rank.Text;
            r.reason = resignation_reason.Text;
            r.resignation_date = resignation_date.Value.Date;
            r.resignation_letter = resignation_letter.Text;


            bool state;

            if (!r_present)
            {
                state = ResignationHandler.addResignation(r);
            }
            else
            {
                state = ResignationHandler.updateResignation(r);
            }

            if (state)
            {
                MessageBox.Show("Employee Resignation details updated succesfully...!");

            }
            else
            {
                MessageBox.Show("Updating Resignation details failed...!");
            }
        }
    }
}
