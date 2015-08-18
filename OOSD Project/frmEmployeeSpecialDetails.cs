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

            if (!(Employee.emp_no == null)) {
                employee_no_combo_special.Text = Employee.emp_no;
                full_name_special.Text = Employee.employee_name;
            }

        }

        public static frmEmployeeSpecialDetails getForm()
        {
            if (form == null)
            {
                form = new frmEmployeeSpecialDetails();
            }
            return form;
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

        private void btnSave2_Click(object sender, EventArgs e)
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
            we.setDate_from(we_date_from_date.Value.Date);
            we.setDate_to(we_date_to_date.Value.Date);
            we.setDate_perma(we_date_perma_date.Value.Date);
            

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
                MessageBox.Show("Extracurricular activity details added successfully...!");
                //btnSave4.Enabled = true;
                //btnSave5.Enabled = true;
            }
            else { MessageBox.Show("Failed to add extracurricular activity experience details...!"); }

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

            m.setBegin_date(member_begin_date_date.Value.Date);
            m.setRenewal_date(member_renewal_date.Value.Date);
            m.setActive_date_insti(member_active_date_insti_date.Value.Date);
            m.setActive_date_person(member_active_date_person_date.Value.Date);

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

    }
}
