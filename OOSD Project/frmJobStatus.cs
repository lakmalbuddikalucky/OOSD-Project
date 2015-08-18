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
        }

        public static frmJobStatus getForm()
        {
            if (form == null)
            {
                form = new frmJobStatus();
            }
            return form;
        }

        private bool validateJobStatusDtails()
        {
            bool state = true;
            if (!Validator.validate(job_employee_no, VALIDATE_TYPE.TEXT))
            {
                state = false;
            }

            if(!Validator.validate(job_contract_started_date, VALIDATE_TYPE.LESS_THAN_SYS_DATE))
            {
                erp_job_contract_started_date.SetError(job_contract_started_date, "Invalid date");
                state = false;
            }

            if(!Validator.validate(ref job_contract_ended_date, ref job_contract_started_date, VALIDATE_TYPE.DATE_DIFF))
            {
                erp_job_contract_ended_date.SetError(job_contract_ended_date, "Invalid date");
                state = false;
            }

            if(!Validator.validate(ref job_probation_ended_date, ref job_probation_started_date, VALIDATE_TYPE.DATE_DIFF))
            {
                erp_job_probation_ended_date.SetError(job_probation_ended_date, "Invalid date");
                state = false;
            }
            return state;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void job_contract_started_date_ValueChanged(object sender, EventArgs e)
        {
            erp_job_contract_started_date.Dispose();
            erp_job_contract_ended_date.Dispose();
        }

        private void job_contract_ended_date_ValueChanged(object sender, EventArgs e)
        {
            erp_job_contract_ended_date.Dispose();
        }

        private void job_probation_started_date_ValueChanged(object sender, EventArgs e)
        {
            erp_job_probation_started_date.Dispose();
            erp_job_probation_ended_date.Dispose();
            if(Validator.validate(ref job_probation_ended_date, ref job_probation_started_date, VALIDATE_TYPE.DATE_DIFF))
            {
                TimeSpan ts = job_probation_ended_date.Value - job_probation_started_date.Value;
                int totalDays = (int)Math.Ceiling(ts.TotalDays);
                job_probation_time.Text = totalDays.ToString();
            }
            else
            {
                job_probation_time.Text = "0";
            }
        }

        private void job_probation_ended_date_ValueChanged(object sender, EventArgs e)
        {
            erp_job_probation_ended_date.Dispose();
            if (Validator.validate(ref job_probation_ended_date, ref job_probation_started_date, VALIDATE_TYPE.DATE_DIFF))
            {
                TimeSpan ts = job_probation_ended_date.Value - job_probation_started_date.Value;
                int totalDays = (int)Math.Ceiling(ts.TotalDays);
                job_probation_time.Text = totalDays.ToString();
            }
            else
            {
                job_probation_time.Text = "0";
            }
        }

        private void job_probation_to_permanent_started_date_ValueChanged(object sender, EventArgs e)
        {
            erp_job_probation_to_permanent_started_date.Dispose();
        }

        private void job_contract_to_permanent_started_date_ValueChanged(object sender, EventArgs e)
        {
            erp_job_contract_to_permanent_started_date.Dispose();
        }

        private void btnCheckJobStatusDetails_Click(object sender, EventArgs e)
        {
            validateJobStatusDtails();
        }

        private void job_probation_to_permanent_status_CheckedChanged(object sender, EventArgs e)
        {
            if(job_probation_to_permanent_status.Checked == true)
            {
                job_probation_to_permanent_started_date.Enabled = true;
                job_contract_to_permanent_started_date.Enabled = true;
            }
            else
            {
                job_probation_to_permanent_started_date.Enabled = false;
                job_contract_to_permanent_started_date.Enabled = false;
            }
        }
    }
}
