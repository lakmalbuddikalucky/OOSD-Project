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
    public partial class frmEmployeeSpecialDetails : Form
    {
        private static frmEmployeeSpecialDetails form;

        public frmEmployeeSpecialDetails()
        {
            InitializeComponent();
        }

        public static frmEmployeeSpecialDetails getForm()
        {
            if (form == null)
            {
                form = new frmEmployeeSpecialDetails();
            }
            return form;
        }

        private bool validateQualificationDetails()
        {
            bool state = true;
            if(!Validator.validate(qualification_no,VALIDATE_TYPE.NOT_NULL) || !Validator.validate(qualification_no, VALIDATE_TYPE.NUMBER))
            {
                state = false;
            }

            if (!Validator.validate(qual_institute, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if(!Validator.validate(qual_months,VALIDATE_TYPE.NOT_NULL) || !Validator.validate(qual_months, VALIDATE_TYPE.NUMBER))
            {
                state = false;
            }

            if (!Validator.validate(qual_qualification, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if(!Validator.validate(qual_year,VALIDATE_TYPE.NOT_NULL) || !Validator.validate(qual_year, VALIDATE_TYPE.YEAR))
            {
                state = false;
            }
            return state;
        }

        private bool validateWorkExperienceDetails()
        {
            bool state = true;
            if (!Validator.validate(we_institute, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }
            
            if (!Validator.validate(we_address, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if (we_telephone.Text != "" && !Validator.validate(we_telephone, VALIDATE_TYPE.CONTACT_NO))
            {
                state = false;
            }

            if (we_email.Text != "" && !Validator.validate(we_email, VALIDATE_TYPE.EMAIL))
            {
                state = false;
            }

            if (!Validator.validate(we_department, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if(!Validator.dateDiff(DateTime.Today, we_date_from_date.Value))
            {
                erp_we_date_from_date.SetError(we_date_from_date, "Invalid date");
                state = false;
            }

            if (!Validator.validate(ref we_date_to_date,ref we_date_from_date, VALIDATE_TYPE.DATE_DIFF) || !Validator.validate(we_date_to_date, VALIDATE_TYPE.LESS_THAN_SYS_DATE))
            {
                erp_we_date_to_date.SetError(we_date_to_date, "Invalid date");
                state = false;
            }

            if(!Validator.validate(ref we_date_perma_date, ref we_date_from_date, VALIDATE_TYPE.DATE_DIFF)||!Validator.validate(ref we_date_to_date, ref we_date_perma_date,VALIDATE_TYPE.DATE_DIFF))
            {
                erp_we_date_perma_date.SetError(we_date_perma_date, "Invalid date");
                state = false;
            }

            return state;
        }

        private bool validateMembershipDetails()
        {
            bool state = true;
            if (!Validator.validate(member_institute, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if (!Validator.validate(member_id, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if(!Validator.dateDiff(DateTime.Today, member_begin_date_date.Value))
            {
                erp_member_begin_date_date.SetError(member_begin_date_date, "Invalid date");
                state = false;
            }

            if(!Validator.dateDiff(member_renewal_date.Value, member_begin_date_date.Value)  || !Validator.validate(member_renewal_date, VALIDATE_TYPE.LESS_THAN_SYS_DATE))
            {
                erp_member_renewal_date.SetError(member_renewal_date, "Invalid date");
                state = false;
            }

            return state;
        }

        private bool validateExtraCurricularActivityDetails()
        {
            bool state = true;
            if (!Validator.validate(ea_type, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }
            return state;
        }

        private bool validateLanguageSkillDetails()
        {
            bool state = true;
            if(!Validator.validate(language_name,VALIDATE_TYPE.NOT_NULL) || !Validator.validate(language_name, VALIDATE_TYPE.TEXT))
            {
                state = false;
            }
            return state;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmEmployeeFinanceDetails.getForm().Show();
            this.Hide();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmEmployeePersonalDetails.getForm().Show();
            this.Hide();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            Qualification q = new Qualification();

            if (qual_highest_qualification.Checked) { q.highest_qualification = true; }
            else { q.highest_qualification = false; }

            if (qual_occupation_relevant.Checked) { q.occupation_relevant = true; }
            else { q.occupation_relevant = false; }

            q.institute = qual_institute.Text;
            q.months = qual_months.Text;
            q.note = qual_note.Text;
            q.qualification = qual_qualification.Text;
            q.qualification_no = qualification_no.Text;
            q.status = qual_status.Text;
            q.year = qual_year.Text;

            bool status = QualificationsHandler.addQualification(q);

            if (status)
            {
                MessageBox.Show("Qualification details added successfully...!");
                //btnSave4.Enabled = true;
                //btnSave5.Enabled = true;
            }
            else { MessageBox.Show("Failed to add qualification details...!"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            WorkingExperience we = new WorkingExperience();

            we.address = we_address.Text;
            we.award = we_award.Text;
            we.contact = we_contact.Text;
            we.department = we_department.Text;
            we.email = we_department.Text;
            we.institute = we_institute.Text;

            if (we_occupation_relevant.Checked) { we.occupation_relevant = true; }
            else { we.occupation_relevant = false; }

            we.resign_reason = we_resign_reason.Text;
            we.responsibility = we_responsibility.Text;
            we.telephone = we_telephone.Text;
            
            

            bool status = WorkingExperienceHandler.addWorkingExperience(we);

            if (status)
            {
                MessageBox.Show("Working experience details added successfully...!");
                //btnSave4.Enabled = true;
                //btnSave5.Enabled = true;
            }
            else { MessageBox.Show("Failed to add working experience details...!"); }
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {

            ExtracurricularActivity eca = new ExtracurricularActivity();

            eca.award = ea_award.Text;
            eca.method = ea_method.Text;
            eca.type = ea_type.Text;

            bool status = ExtracurricularActivityHandler.addExtracurricularActivity(eca);

            if (status)
            {
                MessageBox.Show("Extracurricular ectivity details added successfully...!");
                //btnSave4.Enabled = true;
                //btnSave5.Enabled = true;
            }
            else { MessageBox.Show("Failed to add extracurricular ectivity experience details...!"); }

        }

        private void btnClear3_Click(object sender, EventArgs e)
        {
            ea_type.Text = null;
            ea_method.Text = null;
            ea_award.Text = null;
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            we_address.Text=null;
            we_award.Text = null;
            we_contact.Text = null;
            we_department.Text = null;
            we_department.Text = null;
            we_institute.Text = null;
            we_occupation_relevant.Checked=false;

            we_resign_reason.Text = null;
            we_responsibility.Text = null;
            we_telephone.Text = null;

            
            we_date_to_date.Text = null;
            

        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            qual_highest_qualification.Checked=false;
            qual_occupation_relevant.Checked=false;

            qual_institute.Text = null;
            qual_months.Text = null;
            qual_note.Text = null;
            qual_qualification.Text = null;
            qualification_no.Text = null;
            qual_status.Text = null;
            qual_year.Text = null;
        }

        private void btnSave4_Click(object sender, EventArgs e)
        {

            Membership m = new Membership();

            m.contribution = member_contribution.Text;
            m.institute = member_institute.Text;
            m.member_id = member_id.Text;
            m.post_name = memebr_post_name.Text;
            m.method = member_method.Text;

            if (member_institutional_payment.Checked) { m.institutional_payment = true; }
            else { m.institutional_payment = false; }

            if (member_personal_payment.Checked) { m.personal_payment = true; }
            else { m.personal_payment = false; }

            

            m.status = member_status.Text;
            
            bool status = MembershipHandler.addMembership(m);

            if (status)
            {
                MessageBox.Show("Membership details added successfully...!");
                //btnSave4.Enabled = true;
                //btnSave5.Enabled = true;
            }
            else { MessageBox.Show("Failed to add membership details...!"); }
        }

        private void btnAddLan_Click(object sender, EventArgs e)
        {
            Language l = new Language();
            l.language_name = language_name.Text;

            bool status = LanguageHandler.addLanguage(l);

            if (status)
            {
                MessageBox.Show("Language details added successfully...!");
                //btnSave4.Enabled = true;
                //btnSave5.Enabled = true;
            }
            else { MessageBox.Show("Failed to add language details...!"); }
        }

        private void btnCheckQualificationDetails_Click(object sender, EventArgs e)
        {
            validateQualificationDetails();
        }

        private void qualification_no_TextChanged(object sender, EventArgs e)
        {
            qualification_no.BackColor = Color.White;
        }

        private void qual_institute_TextChanged(object sender, EventArgs e)
        {
            qual_institute.BackColor = Color.White;
        }

        private void qual_months_TextChanged(object sender, EventArgs e)
        {
            qual_months.BackColor = Color.White;
        }

        private void qual_qualification_TextChanged(object sender, EventArgs e)
        {
            qual_qualification.BackColor = Color.White;
        }

        private void qual_year_TextChanged(object sender, EventArgs e)
        {
            qual_year.BackColor = Color.White;
        }

        private void we_institute_TextChanged(object sender, EventArgs e)
        {
            we_institute.BackColor = Color.White;
        }

        private void we_telephone_TextChanged(object sender, EventArgs e)
        {
            we_telephone.BackColor = Color.White;
        }

        private void we_department_TextChanged(object sender, EventArgs e)
        {
            we_department.BackColor = Color.White;
        }

        private void we_date_to_date_ValueChanged(object sender, EventArgs e)
        {
            erp_we_date_to_date.Dispose();
        }

        private void we_date_perma_date_ValueChanged(object sender, EventArgs e)
        {
            erp_we_date_perma_date.Dispose();
        }

        private void btnCheckWorkExperianceDetails_Click(object sender, EventArgs e)
        {
            validateWorkExperienceDetails();
        }

        private void we_email_TextChanged(object sender, EventArgs e)
        {
            we_email.BackColor = Color.White;
        }

        private void we_address_TextChanged(object sender, EventArgs e)
        {
            we_address.BackColor = Color.White;
        }

        private void we_date_from_date_ValueChanged(object sender, EventArgs e)
        {
            erp_we_date_from_date.Dispose();
            erp_we_date_perma_date.Dispose();
            erp_we_date_to_date.Dispose();
        }

        private void btnExtraCurricularActivityDetails_Click(object sender, EventArgs e)
        {
            validateExtraCurricularActivityDetails();
        }

        private void member_institute_TextChanged(object sender, EventArgs e)
        {
            member_institute.BackColor = Color.White;
        }

        private void member_id_TextChanged(object sender, EventArgs e)
        {
            member_id.BackColor = Color.White;
        }

        private void btnCheckMembershipDetails_Click(object sender, EventArgs e)
        {
            validateMembershipDetails();
        }

        private void member_renewal_date_ValueChanged(object sender, EventArgs e)
        {
            erp_member_renewal_date.Dispose();
        }

        private void member_begin_date_date_ValueChanged(object sender, EventArgs e)
        {
            erp_member_begin_date_date.Dispose();
            erp_member_renewal_date.Dispose();
        }

        private void member_active_date_person_date_ValueChanged(object sender, EventArgs e)
        {
            erp_member_active_date_person_date.Dispose();
        }

        private void member_active_date_insti_date_ValueChanged(object sender, EventArgs e)
        {
            erp_member_active_date_insti_date.Dispose();
        }
    }
}
