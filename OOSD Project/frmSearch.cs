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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            //search
            InitializeComponent();


            //Load employee numbers to combo box
            List<string> em_nos = EmployeeHandler.getAllEmployees();
            employee_no.Text = "Select employee number";

            foreach (string Txt in em_nos)
            {
                employee_no.Items.Add(Txt);

            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmEmployeeFinanceDetails form9 = new frmEmployeeFinanceDetails();
            form9.Show();
            this.Dispose();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmMain form10 = new frmMain();
            form10.Show();
            this.Dispose();
        }

        private void employee_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //Load personal details
            Employee em = EmployeeHandler.getEmployee(employee_no.Text);

            this.action_status.Text = em.getAction_status();
            this.employee_type.Text = em.getEmployee_type();
            this.old_employee_no.Text = em.getOld_employee_no();
            this.txt_em_no.Text = em.getEmployee_no();
            this.epf_no.Text = em.getEpf_no();
            this.salutation.Text = em.getSalutation();
            this.occupation.Text = em.getOccupation();
            this.initials.Text = em.getInitials();
            this.first_name.Text = em.getFirst_name();
            this.last_name.Text = em.getLast_name();
            this.employee_nic.Text = em.getNic_no();
            this.date_issued.Text = em.date_issued;
            this.nationality.Text = em.getNationality();
            this.religion.Text = em.getReligion();
            this.place_of_birth.Text = em.getPlace_of_birth();
            this.blood_group.Text = em.getBlood_group();
            this.nic_no.Text = em.getNic_no();

            if (em.getMarried() == 1) { this.married.Checked = true; }
            else { { this.married.Checked = false; } }


            //Load contact details
            ContactDetails cd = ContactDetailsHandler.getContactDetails();

            Console.Write(cd.cur_province+"\n");

            this.perm_address.Text = cd.perm_address;
            this.perm_city.Text = cd.perm_city;
            this.perm_district.Text = cd.perm_district;
            this.perm_email.Text = cd.perm_email;
            this.perm_fax.Text = cd.perm_fax;
            this.perm_grama.Text = cd.perm_grama;
            this.perm_home_no.Text = cd.perm_home_no;
            this.perm_mobile.Text = cd.perm_mobile;
            this.perm_polling_division.Text = cd.perm_polling_division;
            this.perm_province.Text = cd.perm_province;
            this.perm_teleophone.Text = cd.perm_teleophone;
            this.perm_uc.Text = cd.perm_uc;
            this.cur_address.Text = cd.cur_address;
            this.cur_city.Text = cd.cur_city;
            this.cur_district.Text = cd.cur_district;
            this.cur_email.Text = cd.cur_email;
            this.cur_fax.Text = cd.cur_fax;
            this.cur_grama.Text = cd.cur_grama;
            this.cur_home_no.Text = cd.cur_home_no;
            this.cur_mobile.Text = cd.cur_mobile;
            this.cur_polling_division.Text = cd.cur_polling_division;
            this.cur_province.Text = cd.cur_province;
            this.cur_teleophone.Text = cd.cur_teleophone;
            this.cur_uc.Text = cd.cur_uc;


            //Load dependent details
            DependentDetails dd = DependentDetailsHandler.getDependentDetails();

            depend_birth_certificate.Text = dd.birth_certificate;

            if (dd.deathade == true) { depend_deathade.Checked = true; }
            else { depend_deathade.Checked = false; }

            if (dd.doctor == true) { depend_medical.Checked = true; }
            else { depend_medical.Checked = false; }

            depend_education.Text = dd.education;
            depend_full_name.Text = dd.full_name;
            depend_marriage_certificate.Text = dd.marriage_certificate;
            depend_nic_no.Text = dd.nic_no;
            depend_note.Text = dd.note;
            depend_office_tp.Text = dd.office_tp;
            depend_official_address.Text = dd.official_address;
            depend_personal_address.Text = dd.personal_address;
            depend_personal_tp.Text = dd.personal_tp;
            depend_relation.Text = dd.relation;
            depend_salutation.Text = dd.salutation;
            depend_status.Text = dd.status;


            //Load emergency contact details
            EmergencyContact ec = EmergencyContactHandler.getEmergencyContact();

            emg_employee_no.Text = ec.employee_no;
            emg_full_name.Text = ec.full_name;
            emg_int_ext.Text = ec.int_ext;
            emg_mobile_no.Text = ec.mobile_no;
            emg_nic_no.Text = ec.nic_no;
            emg_office_tp.Text = ec.office_tp;
            emg_official_address.Text = ec.official_address;
            emg_personal_address.Text = ec.personal_address;
            emg_personal_tp.Text = ec.personal_tp;
            emg_priority.Text = ec.priority;
            emg_relation.Text = ec.relation;
            emg_salutation.Text = ec.salutation;

            //Load workstation details
            WorkstationDetails wsd = WorkstationDetailsHandler.getWorkstationDetails();

            wsd_division.Text = wsd.division;
            wsd_post.Text = wsd.post;
            wsd_power.Text = wsd.power;
            wsd_rank.Text = wsd.rank;
            wsd_responsibility.Text = wsd.responsibility;
            wsd_salary_station.Text = wsd.salary_station;


            //Load qualification details
            Qualification q = QualificationsHandler.getQualification();

            qualification_no.Text = q.qualification_no;
            qual_institute.Text = q.institute;
            qual_months.Text = q.months;
            qual_note.Text = q.note;
            qual_qualification.Text = q.qualification;
            qual_status.Text = q.status;
            qual_year.Text = q.year;

            Console.Write(q.highest_qualification + "\n");

            if (q.highest_qualification == true) { qual_highest_qualification.Checked = true; }
            else { qual_highest_qualification.Checked = false; }

            if (q.occupation_relevant == true) { qual_occupation_relevant.Checked = true; }
            else { qual_occupation_relevant.Checked = false; }


        }

        private void wsd_rank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
