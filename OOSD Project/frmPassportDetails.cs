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
        }

        public static frmPassportDetails getForm()
        {
            if (form == null)
            {
                form = new frmPassportDetails();
            }
            return form;
        }

        private bool validatePassportDetails()
        {
            bool state = true;
            if (!Validator.validate(passport_rank, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if(!Validator.validate(passport_post, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if(!Validator.validate(passport_no, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if(!Validator.validate(passport_issued_place, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if(!Validator.validate(passport_issued_date, VALIDATE_TYPE.LESS_THAN_SYS_DATE))
            {
                erp_passport_issued_date.SetError(passport_issued_date, "Invalid date");
                state = false;
            }

            if(!Validator.validate(ref passport_renewal_date, ref passport_issued_date, VALIDATE_TYPE.DATE_DIFF)  || !Validator.validate(passport_renewal_date, VALIDATE_TYPE.LESS_THAN_SYS_DATE))
            {
                erp_passport_renewal_date.SetError(passport_renewal_date, "Invalid date");
                state = false;
            }
            return state;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            frmMain.getForm().Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmEmployeeRemunerationAndBenefits.getForm().Show();
            this.Hide();
        }

        private void btnCheckPassportDetails_Click(object sender, EventArgs e)
        {
            validatePassportDetails();
        }

        private void passport_rank_TextChanged(object sender, EventArgs e)
        {
            passport_rank.BackColor = Color.White;
        }

        private void passport_no_TextChanged(object sender, EventArgs e)
        {
            passport_no.BackColor = Color.White;
        }

        private void passport_issued_place_TextChanged(object sender, EventArgs e)
        {
            passport_issued_place.BackColor = Color.White;
        }

        private void passport_issued_date_ValueChanged(object sender, EventArgs e)
        {
            erp_passport_issued_date.Dispose();
            erp_passport_renewal_date.Dispose();
        }

        private void passport_renewal_date_ValueChanged(object sender, EventArgs e)
        {
            erp_passport_renewal_date.Dispose();
        }

        private void passport_post_TextChanged(object sender, EventArgs e)
        {
            passport_post.BackColor = Color.White;
        }
    }
}
