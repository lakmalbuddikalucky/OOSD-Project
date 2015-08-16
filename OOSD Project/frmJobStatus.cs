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
    public partial class frmJobStatus : Form
    {
        private static frmJobStatus form;

        public frmJobStatus()
        {
            InitializeComponent();

            employee_no.Text = Employee.emp_no;
            full_name.Text = Employee.employee_name;
            job_employee_no.Text = Employee.emp_no;
            job_full_name.Text = Employee.employee_name;

            if (!(JobStatusHandler.getJobStatus() == null))
            {
                loadDetails();
            }
        }

        public static frmJobStatus getForm()
        {
            if (form == null)
            {
                form = new frmJobStatus();
            }
            return form;
        }


        public void loadDetails()
        {

            JobStatus j = JobStatusHandler.getJobStatus();

            job_post.Text = j.post;
            job_rank.Text = j.rank;
            job_employee_type.Text = j.em_type;
            job_contract_ended_date.Value = j.contract_ended_date;
            job_contract_started_date.Value = j.contract_started_date;
            job_contract_to_permanent_started_date.Value = j.contract_to_permanent_date;
            job_probation_ended_date.Value = j.probation_ended_date;
            job_probation_started_date.Value = j.probation_started_date;
            job_probation_time.Text = j.probation_time;
            job_probation_to_permanent_started_date.Value = j.probation_to_permanent_date;

            if (j.probation_to_permanent_status) { job_probation_to_permanent_status.Checked = true; }


        }


        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool j_present = true;
            if (JobStatusHandler.getJobStatus() == null)
            {
                j_present = false;
            }

            JobStatus j = null;

            if (!j_present)
            {
                j = new JobStatus();
            }
            else
            {
                j = JobStatusHandler.getJobStatus();
            }

            j.post = job_post.Text;
            j.rank = job_rank.Text;
            j.em_type = job_employee_type.Text;
            j.probation_time = job_probation_time.Text;

            if (job_probation_to_permanent_status.Checked) { j.probation_to_permanent_status = true; }
            else { j.probation_to_permanent_status = false; }

            j.contract_started_date = job_contract_started_date.Value.Date;
            j.contract_ended_date = job_contract_ended_date.Value.Date;
            j.probation_started_date = job_probation_started_date.Value.Date;
            j.probation_ended_date = job_probation_ended_date.Value.Date;
            j.probation_to_permanent_date = job_probation_to_permanent_started_date.Value.Date;
            j.contract_to_permanent_date = job_contract_to_permanent_started_date.Value.Date;

            bool state;

            if (!j_present)
            {
                state = JobStatusHandler.addJobStatus(j);
            }
            else
            {
                state = JobStatusHandler.updateJobStatus(j);
            }

            if (state)
            {
                MessageBox.Show("Employee Job Status details updated succesfully...!");

            }
            else
            {
                MessageBox.Show("Updating Job Status details failed...!");
            }
        }
    }
}
