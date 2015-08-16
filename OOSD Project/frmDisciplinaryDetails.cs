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
    public partial class frmDisciplinaryDetails : Form
    {
        private static frmDisciplinaryDetails form;

        public frmDisciplinaryDetails()
        {
            InitializeComponent();

            employee_no.Text = Employee.emp_no;
            full_name.Text = Employee.employee_name;
            desciplinary_employee_no.Text = Employee.emp_no;
            desciplinary_full_name.Text = Employee.employee_name;

            if (!(DisciplinaryDetailsHandler.getDisciplinaryDetails() == null))
            {
                loadDetails();
                
            }
        }

        public static frmDisciplinaryDetails getForm()
        {
            if (form == null)
            {
                form = new frmDisciplinaryDetails();
            }
            return form;
        }


        public void loadDetails() {

            DisciplinaryDetails dd = DisciplinaryDetailsHandler.getDisciplinaryDetails();

            desciplinary_rank.Text = dd.rank;
            desciplinary_post.Text = dd.post;
            desciplinary_verdict_of_director_general.Text = dd.verdict_of_director_general;
            desciplinary_breaking.Text = dd.breaking;
            desciplinary_given_sentence.Text = dd.given_sentence;
            desciplinary_inquiry_officer.Text = dd.inquiry_officer;
            desciplinary_request_of_main_administration_officer.Text = dd.request_main_admin;
            desciplinary_suspended_time.Text = dd.suspended_time;
            desciplinary_verdict_of_director_general_date.Value = dd.verdict_of_director_general_date;
            disciplinary_given_sentence_date.Value = dd.given_sentence_date;
            disciplinary_breaking_date.Value = dd.breaking_date;
            disciplinary_rejoined_date.Value = dd.rejoined_date;
            desciplinary_suspended_time.Text = dd.suspended_time;

        }

        private bool validateDiciplinaryDetails()
        {
            bool state = true;
            if(desciplinary_employee_no.Text == "")
            {
                desciplinary_employee_no.BackColor = Color.RosyBrown;
                state = false;
            }
            if (desciplinary_full_name.Text == "" || !Validator.text(desciplinary_full_name.Text))
            {
                desciplinary_full_name.BackColor = Color.RosyBrown;
                state = false;
            }

            if (desciplinary_post.Text == "" || !Validator.text(desciplinary_post.Text))
            {
                desciplinary_post.BackColor = Color.RosyBrown;
                state = false;
            }

            if (desciplinary_rank.Text == "" || !Validator.text(desciplinary_rank.Text))
            {
                desciplinary_rank.BackColor = Color.RosyBrown;
                state = false;
            }

            if (desciplinary_breaking.Text == "" || !Validator.text(desciplinary_breaking.Text))
            {
                desciplinary_breaking.BackColor = Color.RosyBrown;
                state = false;
            }

            if (desciplinary_request_of_main_administration_officer.Text == "" || !Validator.text(desciplinary_request_of_main_administration_officer.Text))
            {
                desciplinary_request_of_main_administration_officer.BackColor = Color.RosyBrown;
                state = false;
            }

            if(desciplinary_given_sentence.Text == "" || !Validator.text(desciplinary_given_sentence.Text)){
                desciplinary_given_sentence.BackColor = Color.RosyBrown;
                state = false;
            }

            if (desciplinary_verdict_of_director_general.Text == "" || !Validator.text(desciplinary_verdict_of_director_general.Text))
            {
                desciplinary_verdict_of_director_general.BackColor = Color.RosyBrown;
                state = false;
            }

            if (desciplinary_inquiry_officer.Text == "" || !Validator.text(desciplinary_inquiry_officer.Text))
            {
                desciplinary_inquiry_officer.BackColor = Color.RosyBrown;
                state = false;
            }
            return state;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool desc_present = true;
            if (DisciplinaryDetailsHandler.getDisciplinaryDetails() == null)
            {
                desc_present = false;
            }
            
            DisciplinaryDetails dd = null;

            if (!desc_present)
            {
                dd = new DisciplinaryDetails();
            }
            else {
                dd = DisciplinaryDetailsHandler.getDisciplinaryDetails();
            }

            dd.rank = desciplinary_rank.Text;
            dd.post = desciplinary_post.Text;
            dd.verdict_of_director_general = desciplinary_verdict_of_director_general.Text;
            dd.breaking = desciplinary_breaking.Text;
            dd.given_sentence = desciplinary_given_sentence.Text;
            dd.inquiry_officer = desciplinary_inquiry_officer.Text;
            dd.request_main_admin = desciplinary_request_of_main_administration_officer.Text;
            dd.suspended_time = desciplinary_suspended_time.Text;
            dd.verdict_of_director_general_date = desciplinary_verdict_of_director_general_date.Value.Date;
            dd.given_sentence_date = disciplinary_given_sentence_date.Value.Date;
            dd.breaking_date = disciplinary_breaking_date.Value.Date;
            dd.rejoined_date = disciplinary_rejoined_date.Value.Date;
            dd.suspended_time = desciplinary_suspended_time.Text;

            bool state;

            if (!desc_present)
            {
                state = DisciplinaryDetailsHandler.addDisciplinaryDetails(dd);
            }
            else {
                state = DisciplinaryDetailsHandler.updateDisciplinaryDetails(dd);
            }

            if (state)
            {
                MessageBox.Show("Employee Disciplinary details updated succesfully...!");

            }
            else
            {
                MessageBox.Show("Updating Disciplinary details failed...!");
            }

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
    }
}
