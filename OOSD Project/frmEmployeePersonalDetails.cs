using OOSD_Project.Database;
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
    public partial class frmEmployeePersonalDetails : Form
    {
        public frmEmployeePersonalDetails()
        {
            InitializeComponent();
            //btnNext.Enabled = false;
            //btnSave2.Enabled = false;
            //btnSave3.Enabled = false;
            //btnSave4.Enabled = false;
            //btnSave5.Enabled = false;
            //btnClear1.Enabled = false;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Employee employee = new Employee();

            employee.setAction_status(action_status.Text);
            employee.setBlood_grouph(blood_group.Text);
            employee.setDate_issued(date_issued.Text);
            employee.setDate_of_birth(dob_year.Text, dob_month.Text, dob_date.Text);
            employee.setDate_of_marriage(marry_year.Text, marry_month.Text, marry_date.Text);
            employee.setEmployee_no(employee_no_txt.Text);
            employee.setEmployee_type(employee_type.Text);
            employee.setEpf_no(epf_no.Text);
            employee.setFirst_name(first_name.Text);
            employee.setFull_name(full_name.Text);
            //employee.setImg_url();
            employee.setInitials(initials.Text);
            employee.setLast_name(last_name.Text);

            if (married.Checked) { employee.setMarried(1); }
            else { employee.setMarried(0); }

            employee.setNationality(nationality.Text);
            employee.setNic_no(nic_no.Text);
            employee.setOccupation(occupation.Text);
            employee.setOld_employee_no(old_employee_no.Text);
            employee.setPlace_of_birth(place_of_birth.Text);
            employee.setReligion(religion.Text);
            employee.setSalutation(salutation.Text);


            //Add a new employee
            if (Employee.employee_id == 0)
            {
                bool state = EmployeeHandler.addEmployee(employee);

                if (state)
                {
                    MessageBox.Show("Employee personal details added succesfully...!");
                    //btnSave2.Enabled = true;
                    //btnSave3.Enabled = true;
                    //btnSave4.Enabled = true;
                    //btnSave5.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Adding employee personal details failed...!");
                }

            }
            //Update existing employee
            else
            {
                bool state = EmployeeHandler.updateEmployee(employee);

                if (state)
                {
                    MessageBox.Show("Employee personal details updated succesfully...!");

                }
                else
                {
                    MessageBox.Show("Updating employee personal details failed...!");
                }
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmEmployeeSpecialDetails form3 = new frmEmployeeSpecialDetails();
            form3.Show();
            this.Dispose();
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmMain form4 = new frmMain();
            form4.Show();
            this.Dispose();

        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void employee_no_combo_KeyUp(object sender, KeyEventArgs e)
        {
            employee_no_txt.Text = employee_no_combo.Text;
            bool exists = EmployeeHandler.checkEmployee(employee_no_combo.Text);

            if (exists)
            {
                employee_no_combo.ForeColor = Color.Red;
                employee_no_txt.ForeColor = Color.Red;
            }
            else
            {
                employee_no_combo.ForeColor = Color.Black;
                employee_no_txt.ForeColor = Color.Black;
            }
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            ContactDetails cd = new ContactDetails();
            cd.cur_address = cur_address.Text;
            cd.cur_city = cur_city.Text;
            cd.cur_district = cur_district.Text;
            cd.cur_email = cur_email.Text;
            cd.cur_fax = cur_fax.Text;
            cd.cur_grama = cur_grama.Text;
            cd.cur_home_no = cur_home_no.Text;
            cd.cur_mobile = cur_mobile.Text;
            cd.cur_polling_division = cur_polling_division.Text;
            cd.cur_province = cur_province.Text;
            cd.cur_teleophone = cur_teleophone.Text;
            cd.cur_uc = cur_uc.Text;
            cd.perm_address = perm_address.Text;
            cd.perm_city = perm_city.Text;
            cd.perm_district = perm_district.Text;
            cd.perm_email = perm_email.Text;
            cd.perm_fax = perm_fax.Text;
            cd.perm_grama = perm_grama.Text;
            cd.perm_home_no = perm_home_no.Text;
            cd.perm_mobile = perm_mobile.Text;
            cd.perm_polling_division = perm_polling_division.Text;
            cd.perm_province = perm_province.Text;
            cd.perm_teleophone = perm_teleophone.Text;
            cd.perm_uc = perm_uc.Text;

            bool status = ContactDetailsHandler.addContactDetails(cd);

            if (status)
            {
                MessageBox.Show("Contact details added successfully...!");
                //btnSave3.Enabled = true;
                //btnClear1.Enabled = true;
                //btnSave4.Enabled = true;
                //btnSave5.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to add contact details...!");
            }
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            DependentDetails dd = new DependentDetails();

            dd.birth_certificate = depend_birth_certificate.Text;
            dd.education = depend_education.Text;
            dd.full_name = depend_full_name.Text;
            dd.marriage_certificate = depend_marriage_certificate.Text;
            dd.nic_no = depend_nic_no.Text;
            dd.note = depend_note.Text;
            dd.office_tp = depend_office_tp.Text;
            dd.official_address = depend_official_address.Text;
            dd.personal_address = depend_personal_address.Text;
            dd.personal_tp = depend_personal_tp.Text;
            dd.relation = depend_relation.Text;
            dd.salutation = depend_salutation.Text;
            dd.status = depend_status.Text;
            dd.setDate_of_post(depend_date_of_post_yr.Text, depend_date_of_post_m.Text, depend_date_of_post_d.Text);

            if (depend_deathade.Checked) { dd.deathade = true; }
            else { dd.deathade = false; }

            if (depend_medical.Checked) { dd.doctor = true; }
            else { dd.doctor = false; }

            bool status = DependentDetailsHandler.addDependentDetails(dd);

            if (status)
            {
                MessageBox.Show("Dependent details added successfully...!");
                //btnSave4.Enabled = true;
                //btnSave5.Enabled = true;
            }
            else { MessageBox.Show("Failed to add dependent details...!"); }
        }

        private void btnClear3_Click(object sender, EventArgs e)
        {
            depend_birth_certificate = null;
            depend_date_of_post_d = null;
            depend_date_of_post_m = null;
            depend_date_of_post_yr = null;
            depend_deathade.Checked = false;
            depend_education = null;
            depend_full_name = null;
            depend_marriage_certificate = null;
            depend_medical.Checked = false;
            depend_nic_no = null;
            depend_note = null;
            depend_office_tp = null;
            depend_official_address = null;
            depend_personal_address = null;
            depend_personal_tp = null;
            depend_relation = null;
            depend_salutation = null;
            depend_status = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            EmergencyContact ec = new EmergencyContact();
            ec.employee_no = emg_employee_no.Text;
            ec.full_name = emg_full_name.Text;
            ec.int_ext = emg_int_ext.Text;
            ec.mobile_no = emg_mobile_no.Text;
            ec.nic_no = emg_nic_no.Text;
            ec.office_tp = emg_office_tp.Text;
            ec.official_address = emg_official_address.Text;
            ec.personal_address = emg_personal_address.Text;
            ec.personal_tp = emg_personal_tp.Text;
            ec.priority = emg_priority.Text;
            ec.relation = emg_relation.Text;
            ec.salutation = emg_salutation.Text;

            bool status = EmergencyContactHandler.addEmergencyContact(ec);

            if (status)
            {
                MessageBox.Show("Emergency contact added successfully...!");
                btnSave5.Enabled = true;
            }
            else { MessageBox.Show("Failed to add emergency contact...!"); }
        }

        private void btnSave5_Click(object sender, EventArgs e)
        {

            WorkstationDetails wd = new WorkstationDetails();

            wd.division = wsd_division.Text;
            wd.post = wsd_post.Text;
            wd.power = wsd_power.Text;
            wd.rank = wsd_rank.Text;
            wd.responsibility = wsd_responsibility.Text;
            wd.salary_station = wsd_salary_station.Text;
            wd.setDate_of_post(wsd_date_of_post_y.Text, wsd_date_of_post_m.Text, wsd_date_of_post_d.Text);

            bool status = WorkstationDetailsHandler.addWorkstationDetails(wd);

            if (status)
            {
                MessageBox.Show("Workstation details added successfully...!");
                btnNext.Enabled = true;
            }
            else { MessageBox.Show("Failed to add workstation details...!"); }
        }
    }
}
