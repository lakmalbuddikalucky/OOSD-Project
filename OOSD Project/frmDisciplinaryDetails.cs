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
    public partial class frmDisciplinaryDetails : Form
    {
        private static frmDisciplinaryDetails form;

        public frmDisciplinaryDetails()
        {
            InitializeComponent();
        }

        public static frmDisciplinaryDetails getForm()
        {
            if (form == null)
            {
                form = new frmDisciplinaryDetails();
            }
            return form;
        }

        private bool validateDiciplinaryDetails()
        {
            bool state = true;
            if (!Validator.validate(desciplinary_employee_no, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if (!Validator.validate(desciplinary_full_name, VALIDATE_TYPE.NOT_NULL) || !Validator.validate(desciplinary_full_name, VALIDATE_TYPE.TEXT))
            {
                state = false;
            }

            if (!Validator.validate(desciplinary_post, VALIDATE_TYPE.NOT_NULL) || !Validator.validate(desciplinary_post, VALIDATE_TYPE.TEXT))
            {
                state = false;
            }

            if (!Validator.validate(desciplinary_rank, VALIDATE_TYPE.NOT_NULL) || !Validator.validate(desciplinary_rank, VALIDATE_TYPE.TEXT))
            {
                state = false;
            }

            if(!Validator.validate(desciplinary_breaking,VALIDATE_TYPE.NOT_NULL) || !Validator.validate(desciplinary_breaking, VALIDATE_TYPE.TEXT))
            {
                state = false;
            }

            if(!Validator.validate(desciplinary_request_of_main_administration_officer,VALIDATE_TYPE.NOT_NULL) || !Validator.validate(desciplinary_request_of_main_administration_officer, VALIDATE_TYPE.TEXT))
            {
                state = false;
            }

            if(!Validator.validate(desciplinary_given_sentence,VALIDATE_TYPE.NOT_NULL) || !Validator.validate(desciplinary_given_sentence, VALIDATE_TYPE.TEXT))
            {
                state = false;
            }

            if(!Validator.validate(desciplinary_verdict_of_director_general,VALIDATE_TYPE.NOT_NULL) || !Validator.validate(desciplinary_verdict_of_director_general, VALIDATE_TYPE.TEXT))
            {
                state = false;
            }

            if(!Validator.validate(desciplinary_inquiry_officer,VALIDATE_TYPE.NOT_NULL) || !Validator.validate(desciplinary_inquiry_officer, VALIDATE_TYPE.TEXT))
            {
                state = false;
            }

            if(!Validator.validate(ref disciplinary_rejoined_date,ref disciplinary_suspended_date, VALIDATE_TYPE.DATE_DIFF))
            {
                erp_disciplinary_rejoined_date.SetError(disciplinary_rejoined_date, "Invalid date");
                state = false;
            }
            else
            {
                erp_disciplinary_rejoined_date.Dispose();
            }

            if (!Validator.validate(ref disciplinary_given_sentence_date, ref disciplinary_date, VALIDATE_TYPE.DATE_DIFF))
            {
                erp_disciplinary_given_sentence_date.SetError(disciplinary_given_sentence_date, "Invalid date");
                state = false;
            }
            else
            {
                erp_disciplinary_given_sentence_date.Dispose();
            }

            if(!Validator.validate(ref desciplinary_verdict_of_director_general_date,ref disciplinary_given_sentence_date, VALIDATE_TYPE.DATE_DIFF))
            {
                erp_desciplinary_verdict_of_director_general_date.SetError(desciplinary_verdict_of_director_general_date, "Invalid date");
                state = false;
            }
            else
            {
                erp_desciplinary_verdict_of_director_general_date.Dispose();
            }

            if(!Validator.dateDiff(DateTime.Today, disciplinary_date.Value))
            {
                erp_disciplinary_date.SetError(disciplinary_date, "Invalid date");
                state = false;
            }
            return state;
        }

        private bool validateNewDiciplinaryDetails()
        {
            if (Validator.validate(desciplinary_employee_no,VALIDATE_TYPE.NOT_NULL) &&
                Validator.validate(desciplinary_employee_no,VALIDATE_TYPE.NUMBER))
            {
                return true;
            }
            return false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void desciplinary_employee_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            desciplinary_employee_no.BackColor = Color.White;
        }

        private void desciplinary_full_name_TextChanged(object sender, EventArgs e)
        {
            desciplinary_full_name.BackColor = Color.White;
        }

        private void desciplinary_post_TextChanged(object sender, EventArgs e)
        {
            desciplinary_post.BackColor = Color.White;
        }

        private void desciplinary_rank_TextChanged(object sender, EventArgs e)
        {
            desciplinary_rank.BackColor = Color.White;
        }

        private void desciplinary_breaking_TextChanged(object sender, EventArgs e)
        {
            desciplinary_breaking.BackColor = Color.White;
        }

        private void desciplinary_request_of_main_administration_officer_TextChanged(object sender, EventArgs e)
        {
            desciplinary_request_of_main_administration_officer.BackColor = Color.White;
        }

        private void desciplinary_given_sentence_TextChanged(object sender, EventArgs e)
        {
            desciplinary_given_sentence.BackColor = Color.White;
        }

        private void desciplinary_verdict_of_director_general_TextChanged(object sender, EventArgs e)
        {
            desciplinary_verdict_of_director_general.BackColor = Color.White;
        }

        private void desciplinary_inquiry_officer_TextChanged(object sender, EventArgs e)
        {
            desciplinary_inquiry_officer.BackColor = Color.White;
        }

        private void btnCheckDisciplinaryDetails_Click(object sender, EventArgs e)
        {
            validateDiciplinaryDetails();
        }

        private void disciplinary_suspended_date_ValueChanged(object sender, EventArgs e)
        {
            erp_disciplinary_rejoined_date.Dispose();
        }

        private void disciplinary_rejoined_date_ValueChanged(object sender, EventArgs e)
        {
            erp_disciplinary_rejoined_date.Dispose();
        }

        private void disciplinary_date_ValueChanged(object sender, EventArgs e)
        {
            erp_disciplinary_date.Dispose();
            erp_disciplinary_given_sentence_date.Dispose();
        }

        private void disciplinary_given_sentence_date_ValueChanged(object sender, EventArgs e)
        {
            erp_disciplinary_given_sentence_date.Dispose();
            erp_desciplinary_verdict_of_director_general_date.Dispose();
        }

        private void desciplinary_verdict_of_director_general_date_ValueChanged(object sender, EventArgs e)
        {
            erp_desciplinary_verdict_of_director_general_date.Dispose();
        }
    }
}
