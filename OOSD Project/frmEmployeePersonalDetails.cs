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
        private static frmEmployeePersonalDetails form;

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

        public static frmEmployeePersonalDetails getForm()
        {
            if (form == null)
            {
                form = new frmEmployeePersonalDetails();
            }
            return form;
        }

        private void setPersonalDetailsToWhite()
        {
            //Set personal details field's background color to white
            employee_no.BackColor = Color.White;
            employee_type.BackColor = Color.White;
            epf_no.BackColor = Color.White;
            salutation.BackColor = Color.White;
            occupation.BackColor = Color.White;
            first_name.BackColor = Color.White;
            nic_no.BackColor = Color.White;
            dob_date.BackColor = Color.White;
            action_status.BackColor = Color.White;
            blood_group.BackColor = Color.White;
        }

        private void setContactDetailsToWhiate()
        {

            perm_home_no.BackColor = Color.White;
            perm_address.BackColor = Color.White;
            perm_city.BackColor = Color.White;
            perm_province.BackColor = Color.White;
            perm_district.BackColor = Color.White;
            perm_uc.BackColor = Color.White;
            perm_grama.BackColor = Color.White;
            perm_polling_division.BackColor = Color.White;
            perm_teleophone.BackColor = Color.White;
            perm_mobile.BackColor = Color.White;
            perm_fax.BackColor = Color.White;
            perm_email.BackColor = Color.White;
            cur_city.BackColor = Color.White;
            cur_teleophone.BackColor = Color.White;
            cur_mobile.BackColor = Color.White;
            cur_fax.BackColor = Color.White;
            cur_email.BackColor = Color.White;
            cur_home_no.BackColor = Color.White;
            cur_address.BackColor = Color.White;
        }

        private void setDependentDetailsToWhite()
        {
            depend_nic_no.BackColor = Color.White;
            depend_full_name.BackColor = Color.White;
            depend_office_tp.BackColor = Color.White;
            depend_personal_tp.BackColor = Color.White;
        }

        private void setEmergencyContactDetailsToWhite()
        {
            emg_full_name.BackColor = Color.White;
            emg_personal_tp.BackColor = Color.White;
            emg_mobile_no.BackColor = Color.White;
            emg_office_tp.BackColor = Color.White;
            emg_nic_no.BackColor = Color.White;
        }

        private void setWorkstationDetailsToWhite()
        {
            wsd_rank.BackColor = Color.White;
            wsd_division.BackColor = Color.White;
            wsd_post.BackColor = Color.White;
            wsd_salary_station.BackColor = Color.White;
            wsd_responsibility.BackColor = Color.White;
            wsd_power.BackColor = Color.White;
        }

        private bool validatePersonalDetails()
        {
            setPersonalDetailsToWhite();
            bool state = true;
            if (employee_no.Text == "")
            {
                employee_no.BackColor = Color.RosyBrown;
                state = false;
            }

            if (employee_type.Text == "")
            {
                employee_type.BackColor = Color.RosyBrown;
                state = false;
            }

            if (epf_no.Text == "" || !Validator.epf(epf_no.Text)) 
            {
                epf_no.BackColor = Color.RosyBrown; ;
                state = false;
            }

            if (salutation.Text == "")
            {
                salutation.BackColor = Color.RosyBrown; ;
                state = false;
            }

            if (occupation.Text == "")
            {
                occupation.BackColor = Color.RosyBrown; ;
                state = false;
            }

            if (first_name.Text == "" || !Validator.text(first_name.Text))
            {
                first_name.BackColor = Color.RosyBrown;
                state = false;
            }

            if (nic_no.Text == "" || !Validator.nic(nic_no.Text))
            {
                nic_no.BackColor = Color.RosyBrown;
                state = false;
            }

            if (action_status.Text == "")
            {
                action_status.BackColor = Color.RosyBrown;
                state = false;
            }

            if (blood_group.Text == "")
            {
                blood_group.BackColor = Color.RosyBrown;
                state = false;
            }
            return state;
        }

        private bool validateContactDetails()
        {
            //Compulsory validations
            setContactDetailsToWhiate();
            bool state = true;
            if (perm_home_no.Text == "")
            {
                perm_home_no.BackColor = Color.RosyBrown;
                state = false;
            }

            if (perm_address.Text == "")
            {
                perm_address.BackColor = Color.RosyBrown;
                state = false;
            }

            if (perm_city.Text == "" || !Validator.text(perm_city.Text))
            {
                perm_city.BackColor = Color.RosyBrown;
                state = false;
            }

            if (perm_province.Text == "")
            {
                perm_province.BackColor = Color.RosyBrown;
                state = false;
            }

            if (perm_district.Text == "")
            {
                perm_district.BackColor = Color.RosyBrown;
                state = false;
            }

            if (perm_uc.Text == "")
            {
                perm_uc.BackColor = Color.RosyBrown;
                state = false;
            }

            if (perm_grama.Text == "")
            {
                perm_grama.BackColor = Color.RosyBrown;
                state = false;
            }

            if (perm_polling_division.Text == "")
            {
                perm_polling_division.BackColor = Color.RosyBrown;
                state = false;
            }

            if (perm_teleophone.Text != "" && !Validator.contactNumber(perm_teleophone.Text))
            {
                perm_teleophone.BackColor = Color.RosyBrown;
                state = false;
            }

            if (perm_mobile.Text != "" && !Validator.contactNumber(perm_mobile.Text))
            {
                perm_mobile.BackColor = Color.RosyBrown;
                state = false;
            }

            if (perm_mobile.Text == "" && perm_teleophone.Text == "")
            {
                perm_teleophone.BackColor = Color.RosyBrown;
                perm_mobile.BackColor = Color.RosyBrown;
                state = false;
            }

            if (perm_fax.Text != "" && Validator.fax(perm_fax.Text))
            {
                perm_fax.BackColor = Color.RosyBrown;
                state = false;
            }

            if (perm_email.Text != "" && !Validator.email(perm_email.Text))
            {
                perm_email.BackColor = Color.RosyBrown;
                state = false;
            }

            //Not compulsory validations
            if (cur_city.Text != "" && !Validator.text(cur_city.Text))
            {
                cur_city.BackColor = Color.RosyBrown;
                state = false;
            }

            if (cur_teleophone.Text != "" && !Validator.contactNumber(cur_teleophone.Text))
            {
                cur_teleophone.BackColor = Color.RosyBrown;
                state = false;
            }

            if (cur_mobile.Text != "" && !Validator.contactNumber(cur_mobile.Text))
            {
                cur_mobile.BackColor = Color.RosyBrown;
                state = false;
            }

            if (cur_fax.Text != "" && !Validator.fax(cur_fax.Text))
            {
                cur_fax.BackColor = Color.RosyBrown;
                state = false;
            }

            if (cur_email.Text != "" && !Validator.email(cur_email.Text))
            {
                cur_email.BackColor = Color.RosyBrown;
                state = false;
            }

            //Data duplication validation
            /*
            if(perm_home_no.Text != "" && cur_home_no.Text != "" && perm_home_no.Text == cur_home_no.Text)
            {
                perm_home_no.BackColor = Color.BurlyWood;
                cur_home_no.BackColor = Color.BurlyWood;
                state = false;
            }

            if(perm_address.Text != "" && cur_address.Text != "" && perm_address.Text == cur_address.Text)
            {
                perm_address.BackColor = Color.BurlyWood;
                cur_address.BackColor = Color.BurlyWood;
                state = false;
            }

            if(perm_mobile.Text != "" && cur_mobile.Text != "" && perm_mobile.Text == cur_mobile.Text)
            {
                perm_mobile.BackColor = Color.BurlyWood;
                cur_mobile.BackColor = Color.BurlyWood;
                state = false;
            }

            if(perm_fax.Text != "" && cur_fax.Text != "" && perm_fax.Text == cur_fax.Text)
            {
                perm_fax.BackColor = Color.BurlyWood;
                cur_fax.BackColor = Color.BurlyWood;
                state = false;
            }

            if(perm_email.Text != "" && cur_email.Text != "" && perm_email.Text == cur_email.Text)
            {
                perm_email.BackColor = Color.BurlyWood;
                cur_email.BackColor = Color.BurlyWood;
                state = false;
            }*/
            return state;
        }

        private bool validateDependentDetails()
        {
            setDependentDetailsToWhite();
            bool state = true;
            if (depend_full_name.Text == "" || !Validator.text(depend_full_name.Text))
            {
                depend_full_name.BackColor = Color.RosyBrown;
                state = false;
            }

            if (depend_relation.Text == "" || !Validator.text(depend_relation.Text))
            {
                depend_relation.BackColor = Color.RosyBrown;
                state = false;
            }

            if(depend_nic_no.Text != "" && !Validator.nic(nic_no.Text))
            {
                depend_nic_no.BackColor = Color.RosyBrown;
                state = false;
            }

            if (depend_birth_certificate.Text == "")
            {
                depend_birth_certificate.BackColor = Color.RosyBrown;
                state = false;
            }
            return state;
        }

        private bool validateEmergencyContactDetails()
        {
            setEmergencyContactDetailsToWhite();
            bool state = true;
            if (emg_full_name.Text == "" || !Validator.text(emg_full_name.Text))
            {
                emg_full_name.BackColor = Color.RosyBrown;
                state = false;
            }

            if(emg_nic_no.Text != "" && !Validator.nic(emg_nic_no.Text))
            {
                emg_nic_no.BackColor = Color.RosyBrown;
                state = false;
            }

            if (emg_personal_tp.Text != "" && !Validator.contactNumber(emg_personal_tp.Text))
            {
                emg_personal_tp.BackColor = Color.RosyBrown;
                state = false;
            }

            if (emg_mobile_no.Text != "" && !Validator.contactNumber(emg_mobile_no.Text))
            {
                emg_mobile_no.BackColor = Color.RosyBrown;
                state = false;
            }

            if (emg_office_tp.Text != "" && !Validator.contactNumber(emg_office_tp.Text))
            {
                emg_office_tp.BackColor = Color.RosyBrown;
                state = false;
            }

            if (emg_mobile_no.Text == "" && emg_personal_tp.Text == "")
            {
                emg_personal_tp.BackColor = Color.RosyBrown;
                emg_mobile_no.BackColor = Color.RosyBrown;
                emg_office_tp.BackColor = Color.RosyBrown;
                state = false;
            }

            if (emg_nic_no.Text != "" && !Validator.nic(emg_nic_no.Text))
            {
                emg_nic_no.BackColor = Color.RosyBrown;
                state = false;
            }



            return state;
        }

        private bool validateWorkstationDetails()
        {
            setWorkstationDetailsToWhite();
            bool state = true;
            if (wsd_rank.Text == "")
            {
                wsd_rank.BackColor = Color.RosyBrown;
                state = false;
            }

            if (wsd_division.Text == "")
            {
                wsd_division.BackColor = Color.RosyBrown;
                state = false;
            }

            if (wsd_post.Text == "")
            {
                wsd_post.BackColor = Color.RosyBrown;
                state = false;
            }


            if (wsd_salary_station.Text == "")
            {
                wsd_salary_station.BackColor = Color.RosyBrown;
                state = false;
            }

            if (wsd_responsibility.Text == "")
            {
                wsd_responsibility.BackColor = Color.RosyBrown;
                state = false;
            }

            if (wsd_power.Text == "")
            {
                wsd_power.BackColor = Color.RosyBrown;
                state = false;
            }
            return state;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            Employee employee = new Employee();

            employee.setAction_status(action_status.Text);
            employee.setBlood_grouph(blood_group.Text);
            employee.setDate_issued(date_issued.Text);
            employee.setEmployee_no(employee_no.Text);
            employee.setEmployee_type(employee_type.Text);
            employee.setEpf_no(epf_no.Text);
            employee.setFirst_name(first_name.Text);
            employee.setFull_name(full_name.Text);
            //employee.setImg_url();
            employee.setInitials(initials.Text);
            employee.setLast_name(last_name.Text);
            employee.setDate_of_birth(dob_date.Value.Date);
            employee.setDate_of_marriage(marry_date.Value.Date);

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

        private void emg_nic_no_TextChanged(object sender, EventArgs e)
        {
            emg_nic_no.BackColor = Color.White;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (!(Employee.employee_id == 0))
            {
                //frmEmployeeSpecialDetails form3 = new frmEmployeeSpecialDetails();
                //form3.Show();
                frmEmployeeSpecialDetails.getForm().Show();
                this.Hide();
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //frmMain form4 = new frmMain();
            //form4.Show();
            frmMain.getForm().Show();
            this.Hide();

        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void employee_no_combo_KeyUp(object sender, KeyEventArgs e)
        {
            employee_no.Text = employee_no_combo.Text;
            bool exists = EmployeeHandler.checkEmployee(employee_no_combo.Text);

            if (exists)
            {
                employee_no_combo.ForeColor = Color.RosyBrown;
                employee_no.ForeColor = Color.RosyBrown;
            }
            else
            {
                employee_no_combo.ForeColor = Color.Black;
                employee_no.ForeColor = Color.Black;
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
            dd.setDate_of_post(depend_date_of_post_date.Value.Date);
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
            //Clear sependent details fields

            depend_birth_certificate = null;
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

        private void btnSave4_Click(object sender, EventArgs e)
        {
            //Save emergency contact details

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

            //Save Workstation details

            WorkstationDetails wd = new WorkstationDetails();

            wd.division = wsd_division.Text;
            wd.post = wsd_post.Text;
            wd.power = wsd_power.Text;
            wd.rank = wsd_rank.Text;
            wd.responsibility = wsd_responsibility.Text;
            wd.salary_station = wsd_salary_station.Text;
            wd.setDate_of_post(wsd_date_of_post_date.Value.Date);

            bool status = WorkstationDetailsHandler.addWorkstationDetails(wd);

            if (status)
            {
                MessageBox.Show("Workstation details added successfully...!");
                btnNext.Enabled = true;
            }
            else { MessageBox.Show("Failed to add workstation details...!"); }
        }

        private void btnCheckPersonalDetails_Click(object sender, EventArgs e)
        {
            validatePersonalDetails();
        }

        private void btnCheckConcatDetails_Click(object sender, EventArgs e)
        {
            validateContactDetails();
        }

        private void btnCheckDependentDetails_Click(object sender, EventArgs e)
        {
            validateDependentDetails();
        }

        private void btnCheckEmergencyDetails_Click(object sender, EventArgs e)
        {
            validateEmergencyContactDetails();
        }

        private void btnCheckWorkStationDetails_Click(object sender, EventArgs e)
        {
            validateWorkstationDetails();
        }

        private void employee_no_TextChanged(object sender, EventArgs e)
        {
            employee_no.BackColor = Color.White;
        }

        private void employee_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee_type.BackColor = Color.White;
        }

        private void epf_no_TextChanged(object sender, EventArgs e)
        {
            epf_no.BackColor = Color.White;
        }

        private void salutation_SelectedIndexChanged(object sender, EventArgs e)
        {
            salutation.BackColor = Color.White;
        }

        private void first_name_TextChanged(object sender, EventArgs e)
        {
            first_name.BackColor = Color.White;
        }

        private void nic_no_TextChanged(object sender, EventArgs e)
        {
            nic_no.BackColor = Color.White;
        }

        private void action_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            action_status.BackColor = Color.White;
        }

        private void blood_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            blood_group.BackColor = Color.White;
        }

        private void perm_home_no_TextChanged(object sender, EventArgs e)
        {
            perm_home_no.BackColor = Color.White;
        }

        private void perm_address_TextChanged(object sender, EventArgs e)
        {
            perm_address.BackColor = Color.White;
        }

        private void perm_city_TextChanged(object sender, EventArgs e)
        {
            perm_city.BackColor = Color.White;
        }

        private void perm_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            perm_province.BackColor = Color.White;
        }

        private void perm_district_SelectedIndexChanged(object sender, EventArgs e)
        {
            perm_district.BackColor = Color.White;
        }

        private void perm_uc_SelectedIndexChanged(object sender, EventArgs e)
        {
            perm_uc.BackColor = Color.White;
        }

        private void perm_grama_SelectedIndexChanged(object sender, EventArgs e)
        {
            perm_grama.BackColor = Color.White;
        }

        private void perm_polling_division_SelectedIndexChanged(object sender, EventArgs e)
        {
            perm_polling_division.BackColor = Color.White;
        }

        private void perm_teleophone_TextChanged(object sender, EventArgs e)
        {
            perm_teleophone.BackColor = Color.White;
            perm_mobile.BackColor = Color.White;
        }

        private void perm_mobile_TextChanged(object sender, EventArgs e)
        {
            perm_teleophone.BackColor = Color.White;
            perm_mobile.BackColor = Color.White;
        }

        private void perm_fax_TextChanged(object sender, EventArgs e)
        {
            perm_fax.BackColor = Color.White;
        }

        private void perm_email_TextChanged(object sender, EventArgs e)
        {
            perm_email.BackColor = Color.White;
        }

        private void cur_email_TextChanged(object sender, EventArgs e)
        {
            cur_email.BackColor = Color.White;
        }

        private void cur_fax_TextChanged(object sender, EventArgs e)
        {
            cur_fax.BackColor = Color.White;
        }

        private void cur_mobile_TextChanged(object sender, EventArgs e)
        {
            cur_mobile.BackColor = Color.White;
        }

        private void cur_teleophone_TextChanged(object sender, EventArgs e)
        {
            cur_teleophone.BackColor = Color.White;
        }

        private void cur_home_no_TextChanged(object sender, EventArgs e)
        {
            cur_home_no.BackColor = Color.White;
        }

        private void cur_address_TextChanged(object sender, EventArgs e)
        {
            cur_address.BackColor = Color.White;
        }

        private void depend_relation_SelectedIndexChanged(object sender, EventArgs e)
        {
            depend_relation.BackColor = Color.White;
        }

        private void depend_full_name_TextChanged(object sender, EventArgs e)
        {
            depend_full_name.BackColor = Color.White;
        }

        private void depend_birth_certificate_TextChanged(object sender, EventArgs e)
        {
            depend_birth_certificate.BackColor = Color.White;
        }

        private void emg_full_name_TextChanged(object sender, EventArgs e)
        {
            emg_full_name.BackColor = Color.White;
        }

        private void emg_personal_tp_TextChanged(object sender, EventArgs e)
        {
            emg_personal_tp.BackColor = Color.White;
            emg_mobile_no.BackColor = Color.White;
            emg_office_tp.BackColor = Color.White;
        }

        private void emg_mobile_no_TextChanged(object sender, EventArgs e)
        {
            emg_personal_tp.BackColor = Color.White;
            emg_mobile_no.BackColor = Color.White;
            emg_office_tp.BackColor = Color.White;
        }

        private void emg_office_tp_TextChanged(object sender, EventArgs e)
        {
            emg_personal_tp.BackColor = Color.White;
            emg_mobile_no.BackColor = Color.White;
            emg_office_tp.BackColor = Color.White;
        }

        private void wsd_rank_SelectedIndexChanged(object sender, EventArgs e)
        {
            wsd_rank.BackColor = Color.White;
        }

        private void wsd_division_SelectedIndexChanged(object sender, EventArgs e)
        {
            wsd_division.BackColor = Color.White;
        }

        private void wsd_post_SelectedIndexChanged(object sender, EventArgs e)
        {
            wsd_post.BackColor = Color.White;
        }

        private void wsd_salary_station_SelectedIndexChanged(object sender, EventArgs e)
        {
            wsd_salary_station.BackColor = Color.White;
        }

        private void wsd_responsibility_SelectedIndexChanged(object sender, EventArgs e)
        {
            wsd_responsibility.BackColor = Color.White;
        }

        private void wsd_power_SelectedIndexChanged(object sender, EventArgs e)
        {
            wsd_power.BackColor = Color.White;
        }

        private void dob_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void depend_nic_no_TextChanged(object sender, EventArgs e)
        {
            depend_nic_no.BackColor = Color.White;
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {

        }

        private void employee_no_KeyUp(object sender, KeyEventArgs e)
        {
            employee_no_combo.Text = employee_no.Text;

            bool exists = EmployeeHandler.checkEmployee(employee_no.Text);

            if (exists)
            {
                employee_no_combo.ForeColor = Color.RosyBrown;
                employee_no.ForeColor = Color.RosyBrown;
            }
            else
            {
                employee_no_combo.ForeColor = Color.Black;
                employee_no.ForeColor = Color.Black;
            }
        }
    }
}
