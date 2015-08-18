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
        }

        public static frmResignation getForm()
        {
            if (form == null)
            {
                form = new frmResignation();
            }
            return form;
        }

        private bool validateResignationDetails()
        {
            bool state = true;
            if (!Validator.validate(resignation_employee_no, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }
            if(!Validator.validate(resignation_letter_submitted_date, VALIDATE_TYPE.LESS_THAN_SYS_DATE))
            {
                erp_resignation_letter_submitted_date.SetError(resignation_letter_submitted_date, "Invalid date");
                state = false;
            }

            if(!Validator.validate(ref resignation_date, ref resignation_letter_submitted_date, VALIDATE_TYPE.DATE_DIFF))
            {
                erp_resignation_date.SetError(resignation_date, "Invalid date");
                state = false;
            }

            if(!Validator.validate(resignation_letter, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }
            return state;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckResignationDetails_Click(object sender, EventArgs e)
        {
            validateResignationDetails();
        }

        private void resignation_letter_submitted_date_ValueChanged(object sender, EventArgs e)
        {
            erp_resignation_letter_submitted_date.Dispose();
            erp_resignation_date.Dispose();
        }

        private void resignation_date_ValueChanged(object sender, EventArgs e)
        {
            erp_resignation_date.Dispose();
        }

        private void resignation_employee_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            resignation_employee_no.BackColor = Color.White;

        }

        private void resignation_letter_TextChanged(object sender, EventArgs e)
        {
            resignation_letter.BackColor = Color.White;
        }
    }
}
