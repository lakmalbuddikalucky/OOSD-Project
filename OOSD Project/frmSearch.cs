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

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Globalization;

namespace OOSD_Project
{
    public partial class frmSearch : Form
    {
        private static frmSearch form;

        private int cd_id,dd_id,ec_id,ws_id,q_id,we_id,ea_id,mem_id;
        private int fb_id,fi_id,ft_id,r_id,cb_id,ncb_id,p_id;

        public frmSearch()
        {
            //search
            InitializeComponent();


            //Load employee numbers to combo box
            List<string> em_nos = EmployeeHandler.getAllEmployeeNumbers();
            employee_no.Text = "Select employee number";

            if (!(em_nos == null))
            {
                foreach (string Txt in em_nos)
                {
                    employee_no.Items.Add(Txt);
                }
            }
        }

        public static frmSearch getForm()
        {
            if (form == null)
            {
                form = new frmSearch();
            }
            return form;
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            //frmEmployeeFinanceDetails form9 = new frmEmployeeFinanceDetails();
            //form9.Show();
            //this.Dispose();
            frmMain.getForm().Show();
            this.Hide();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateEmployeePersonalDetails();
            updateContactDetails();
            updateDependentDetails();
            updateEmergencyContact();
            updateWorkstation();
            updateQualification();
            updateWorkingExperience();
            updateExtraCurAc();
            updateMembership();
            updateFinance();
            updateRemuneration();
            updateBenefits();
            updatePassport();


            /*frmMain form10 = new frmMain();
            form10.Show();
            this.Dispose();*/
        }

        private void employee_no_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadPersonalDetails();
            loadContactDetails();
            loadDependentDetails();
            loadEmergencyContact();
            loadWorkstationDetails();
            loadQualificationDetails();
            loadWorkingExperience();
            loadExtraCurricular();
            loadMembership();
            loadLanguages();
            loadFinance();
            loadRenumAndCash();
            loadPassport();

        }

        private void wsd_rank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVisaDetails_Click(object sender, EventArgs e)
        {
            //new frmPassportDetails().Show();
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNotification_Click(object sender, EventArgs e)
        {
            new frmAddNotification().Show();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            new frmTraining().Show();
        }

        private void btnJobStatus_Click(object sender, EventArgs e)
        {
            new frmJobStatus().Show();
        }

        private void btnInterdict_Click(object sender, EventArgs e)
        {
            new frmInterdict_Suspend().Show();
        }

        private void btnResignation_Click(object sender, EventArgs e)
        {
            new frmResignation().Show();
        }

        private void btnReAppoinment_Click(object sender, EventArgs e)
        {
            frmRe_Appointment formReAppointment = new frmRe_Appointment();
            formReAppointment.Show();
        }

        private void btnPensionAndDeath_Click(object sender, EventArgs e)
        {
            frmPension_Death formPensionDeath = new frmPension_Death();
            formPensionDeath.Show();
        }

        private void btnDisciplinaryAction_Click(object sender, EventArgs e)
        {
            new frmDisciplinaryDetails().Show();
        }

        private void btnLeaveRequest_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            // _______________________________________________________1_______________________________________________________
            // Setting pagetype, margins and encryption
            iTextSharp.text.Rectangle pageType = iTextSharp.text.PageSize.A4;
            float marginLeft = 72;
            float marginRight = 36;
            float marginTop = 60;
            float marginBottom = 50;
            String reportName = "Test.pdf";

            Document report = new Document(pageType, marginLeft, marginRight, marginTop, marginBottom);
            PdfWriter writer = PdfWriter.GetInstance(report, new FileStream(reportName, FileMode.Create));
            //writer.SetEncryption(PdfWriter.STRENGTH40BITS, "Good", "Bad", PdfWriter.ALLOW_COPY);
            report.Open();

            // _______________________________________________________2_______________________________________________________
            // Setting Document properties(Meta data)
            // 1. Title
            // 2. Subject
            // 3. Keywords
            // 4. Creator
            // 5. Author
            // 6. Header
            report.AddTitle("Employee Details Report");
            report.AddSubject("This file is generated for administrative use only");
            report.AddKeywords("Civil Security Department, Employee Management System, Version 1.0.0, Report Generator");
            report.AddCreator("Ozious Technologies");
            report.AddAuthor("Eranga Heshan");
            report.AddHeader("Owner", "Civil Security Department");

            // _______________________________________________________3_______________________________________________________
            // Setup the font factory
            /*
            int totalFonts = FontFactory.RegisterDirectory("C:\\WINDOWS\\Fonts");
            StringBuilder sb = new StringBuilder();
            foreach (string fontname in FontFactory.RegisteredFonts) { sb.Append(fontname + "\n"); }
            report.Add(new Paragraph("All Fonts:\n" + sb.ToString()));
            */
            iTextSharp.text.Font fontHeader_1 = FontFactory.GetFont("Calibri", 30, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0));
            iTextSharp.text.Font fontHeader_2 = FontFactory.GetFont("Calibri", 15, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(125, 125, 125));

            // _______________________________________________________x_______________________________________________________
            // Create header
            PdfContentByte cb = writer.DirectContent;
            cb.MoveTo(marginLeft, marginTop);
            cb.LineTo(500, marginTop);
            cb.Stroke();

            Paragraph paraHeader_1 = new Paragraph("Civil Security Department", fontHeader_1);
            paraHeader_1.Alignment = Element.ALIGN_CENTER;
            paraHeader_1.SpacingAfter = 0f;
            report.Add(paraHeader_1);

            Paragraph paraHeader_2 = new Paragraph("Employee Detailed Report", fontHeader_2);
            paraHeader_2.Alignment = Element.ALIGN_CENTER;
            paraHeader_2.SpacingAfter = 10f;
            report.Add(paraHeader_2);

            // _______________________________________________________x_______________________________________________________
            // Adding employee image
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imgEmployee.ImageLocation);
            img.ScaleToFit(100f, 100f);
            img.Border = iTextSharp.text.Rectangle.BOX;
            img.BorderColor = iTextSharp.text.BaseColor.BLACK;
            img.BorderWidth = 5f;
            img.Alignment = iTextSharp.text.Image.TEXTWRAP | iTextSharp.text.Image.ALIGN_RIGHT | iTextSharp.text.Image.ALIGN_TOP;
            img.IndentationLeft = 50f;
            img.SpacingAfter = 20f;
            img.SpacingBefore = 20f;
            report.Add(img);

            Paragraph para1 = new Paragraph("Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... Testing... ");
            para1.Alignment = Element.ALIGN_JUSTIFIED;
            report.Add(para1);

            report.Close();
            this.Close();
        }

        private void remun_other_allowances1_TextChanged(object sender, EventArgs e)
        {

        }

        public void loadPersonalDetails() {
            //Load personal details
            Employee em = EmployeeHandler.getEmployee(employee_no.Text);

            if (!(em == null))
            {
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
                this.employee_name.Text = em.getFull_name();
                this.date_issued.Text = em.date_issued;
                this.nationality.Text = em.getNationality();
                this.religion.Text = em.getReligion();
                this.place_of_birth.Text = em.getPlace_of_birth();
                this.blood_group.Text = em.getBlood_group();
                this.nic_no.Text = em.getNic_no();

                this.dob_date.Value = em.getDate_of_birth();

                this.marry_date.Value = em.getDate_of_marriage();

                if (em.getMarried() == 1) { this.married.Checked = true; }
                else { { this.married.Checked = false; } }
            }
        }


        public void loadContactDetails()
        {
            //Load contact details
            ContactDetails cd = ContactDetailsHandler.getContactDetails();

            if (!(cd == null))
            {
                this.cd_id = cd.cd_id;
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
            }
        }


        public void loadDependentDetails() {
            //Load dependent details
            DependentDetails dd = DependentDetailsHandler.getDependentDetails();

            if (!(dd == null))
            {
                this.dd_id = dd.dd_id;
                this.depend_birth_certificate.Text = dd.birth_certificate;
                this.depend_date_of_post_date.Value = dd.getDate_of_post();

                if (dd.deathade == true) { this.depend_deathade.Checked = true; }
                else { this.depend_deathade.Checked = false; }

                if (dd.doctor == true) { this.depend_medical.Checked = true; }
                else { this.depend_medical.Checked = false; }

                this.depend_education.Text = dd.education;
                this.depend_full_name.Text = dd.full_name;
                this.depend_marriage_certificate.Text = dd.marriage_certificate;
                this.depend_nic_no.Text = dd.nic_no;
                this.depend_note.Text = dd.note;
                this.depend_office_tp.Text = dd.office_tp;
                this.depend_official_address.Text = dd.official_address;
                this.depend_personal_address.Text = dd.personal_address;
                this.depend_personal_tp.Text = dd.personal_tp;
                this.depend_relation.Text = dd.relation;
                this.depend_salutation.Text = dd.salutation;
                this.depend_status.Text = dd.status;
            }
        }


        public void loadEmergencyContact() {
            //Load emergency contact details
            EmergencyContact ec = EmergencyContactHandler.getEmergencyContact();

            if (!(ec == null))
            {
                this.ec_id = ec.ec_id;
                this.emg_employee_no.Text = ec.employee_no;
                this.emg_full_name.Text = ec.full_name;
                this.emg_int_ext.Text = ec.int_ext;
                this.emg_mobile_no.Text = ec.mobile_no;
                this.emg_nic_no.Text = ec.nic_no;
                this.emg_office_tp.Text = ec.office_tp;
                this.emg_official_address.Text = ec.official_address;
                this.emg_personal_address.Text = ec.personal_address;
                this.emg_personal_tp.Text = ec.personal_tp;
                this.emg_priority.Text = ec.priority;
                this.emg_relation.Text = ec.relation;
                this.emg_salutation.Text = ec.salutation;
            }
        }


        public void loadWorkstationDetails() {
            //Load workstation details
            WorkstationDetails wsd = WorkstationDetailsHandler.getWorkstationDetails();

            if (!(wsd == null))
            {
                this.ws_id = wsd.ws_id;
                this.wsd_division.Text = wsd.division;
                this.wsd_post.Text = wsd.post;
                this.wsd_power.Text = wsd.power;
                this.wsd_rank.Text = wsd.rank;
                this.wsd_responsibility.Text = wsd.responsibility;
                this.wsd_salary_station.Text = wsd.salary_station;
                this.wsd_date_of_post_date.Value = wsd.getDate_of_post();
            }
        }


        public void loadQualificationDetails() {
            //Load qualification details
            Qualification q = QualificationsHandler.getQualification();

            if (!(q == null))
            {
                this.q_id = q.q_id;
                this.qualification_no.Text = q.qualification_no;
                this.qual_institute.Text = q.institute;
                this.qual_months.Text = q.months;
                this.qual_note.Text = q.note;
                this.qual_qualification.Text = q.qualification;
                this.qual_status.Text = q.status;
                this.qual_year.Text = q.year;

                if (q.highest_qualification == true) { this.qual_highest_qualification.Checked = true; }
                else { this.qual_highest_qualification.Checked = false; }

                if (q.occupation_relevant == true) { this.qual_occupation_relevant.Checked = true; }
                else { this.qual_occupation_relevant.Checked = false; }
            }

        }


        public void loadWorkingExperience() {
            //Load working experience details
            WorkingExperience we = WorkingExperienceHandler.getWorkingExperience();

            if (!(we == null))
            {
                this.we_id = we.we_id;
                this.we_address.Text = we.address;
                this.we_award.Text = we.award;
                this.we_contact.Text = we.contact;
                this.we_department.Text = we.department;
                this.we_email.Text = we.email;
                this.we_institute.Text = we.institute;
                this.we_resign_reason.Text = we.resign_reason;
                this.we_telephone.Text = we.telephone;
                this.we_responsibility.Text = we.responsibility;

                this.we_date_from_date.Value = we.getDate_from();
                this.we_date_to_date.Value = we.getDate_to();
                this.we_date_perma_date.Value = we.getDate_perma();

                if (we.occupation_relevant == true) { this.we_occupation_relevant.Checked = true; }
                else { this.we_occupation_relevant.Checked = false; }
            }
        }


        public void loadExtraCurricular() {
            //Load extra curricular activity details
            ExtracurricularActivity ea = ExtracurricularActivityHandler.getExtracurricularActivity();

            if (!(ea == null))
            {
                this.ea_id = ea.ea_id;
                this.ea_award.Text = ea.award;
                this.ea_method.Text = ea.method;
                this.ea_type.Text = ea.type;
            }
        }


        public void loadMembership() {
            //Load membership details
            Membership mem = MembershipHandler.getMembership();

            if (!(mem == null))
            {
                this.mem_id = mem.mem_id;
                this.member_contribution.Text = mem.contribution;
                this.member_id.Text = mem.member_id;
                this.member_institute.Text = mem.institute;
                this.member_method.Text = mem.method;
                this.member_status.Text = mem.status;
                this.memebr_post_name.Text = mem.post_name;

                this.member_begin_date_date.Value = mem.getBegin_date();
                this.member_renewal_date.Value = mem.getRenewal_date();
                this.member_active_date_person_date.Value = mem.getActive_date_person();
                this.member_active_date_insti_date.Value = mem.getActive_date_insti();

                if (mem.personal_payment == true) { this.member_personal_payment.Checked = true; }
                else { this.member_personal_payment.Checked = false; }

                if (mem.institutional_payment == true) { this.member_institutional_payment.Checked = true; }
                else { this.member_institutional_payment.Checked = false; }
            }
        }


        public void loadLanguages()
        {
            //Load languages to combo box
            List<string> languages = LanguageHandler.getLanguages();

            if (!(languages == null))
            {
                foreach (string Txt in languages)
                {
                    language_name.Items.Add(Txt);
                }

                language_name.SelectedIndex = 0;
            }
        }


        public void loadFinance() {
            //Load finance bank details
            FinanceBank fb = FinanceBankHandler.getFinanceBank();

            if (!(fb == null))
            {
                this.fb_id = fb.fb_id;
                bank_name.Text = fb.bank_name;
                bank_branch_name.Text = fb.branch_name;
                bank_account_name.Text = fb.account_number;
                bank_account_type.Text = fb.account_type;
                bank_qualification.Text = fb.qualification;
                bank_qualified_year.Text = fb.Qual_year;

                bank_account_started_year.Value = fb.getBegin_date();
                bank_account_closed_year.Value = fb.getEnd_date();
            }


            //Load finance insurance details
            FinanceInsurance fi = FinanceInsuranceHandler.getFinanceInsurance();

            if (!(fi == null))
            {
                this.fi_id = fi.fi_id;
                this.insurance_type.Text = fi.type;
                this.insurance_value.Text = fi.value.ToString();
                this.insurance_notes.Text = fi.note;

                this.insurance_started_date.Value = fi.getBegin_date();
                this.insurance_ended_year.Value = fb.getEnd_date();
            }


            //Load finance tax details
            FinanceTax ft = FinanceTaxHandler.getFinanceTax();

            if (!(ft == null))
            {
                this.ft_id = ft.ft_id;
                this.tax_type.Text = ft.type;
                this.tax_no.Text = ft.number;
                this.tax_notes.Text = ft.note;
                this.tax_paying_method.Text = ft.payment_method;
                this.tax_status.Text = ft.status;
            }
        }


        public void loadRenumAndCash()
        {
            //Load remuneration details
            Remuneration r = RemunerationHandler.getRemuneration();

            if (!(r == null))
            {
                this.r_id = r.r_id;
                this.remun_basic_salary.Text = r.basic_salary.ToString();
                this.remun_fuel_allowance.Text = r.fuel_allowance.ToString();
                this.remun_housing_allowance.Text = r.housing_allowance.ToString();
                this.remun_salary_increase_amount.Text = r.salary_increase_amount.ToString();
                this.remun_other_allowance.Text = r.other_allowance.ToString();
                this.remun_current_total_salary.Text = r.current_total_salary.ToString();
                this.remun_salary_grade.Text = r.salary_grade;
                this.remun_salary_increase_date.Value = r.getsalary_increase_date();
                this.remun_salary_slip_no.Text = r.salary_slip_no;
                this.remun_mobile_phone_allowance.Text = r.mobile_phone_allowance.ToString();
                this.remun_transport_allowance.Text = r.transport_allowance.ToString();
            }


            //Load cash benefit details
            CashBenefit cb = BenefitsHandler.getCashBenefit();

            if (!(cb == null))
            {
                this.cb_id = cb.cb_id;
                this.cash_approved_benefit.Text = cb.approved_benefit;
                this.cash_issued_price.Text = cb.price.ToString();
                this.cash_issued_date.Value = cb.getdate_issued();
            }


            //Load noncahs benefit details
            NonCashBenefit ncb = BenefitsHandler.getNonCashBenefit();

            if (!(ncb == null))
            {
                this.ncb_id = ncb.ncb_id;
                this.noncash_approved_benefit.Text = ncb.approved_benefit;
                this.noncash_price.Text = ncb.price.ToString();
                this.noncash_quantity.Text = ncb.amount.ToString();
                this.noncash_issued_date.Value = ncb.getdate_issued();
            }
        }


        public void loadPassport()
        {
            //Load Passport details
            Passport p = PassportHandler.getPassport();

            if (!(p == null))
            {
                this.p_id = p.p_id;
                this.passport_post.Text = p.post;
                this.passport_rank.Text = p.rank;
                this.passport_no.Text = p.number;
                this.passport_issued_date.Value = p.getdate_of_issue();
                this.passport_renewal_date.Value = p.getdate_of_renewal();
                this.passport_issued_place.Text = p.place_of_issue;

                if (p.status) { this.passport_status_active.Checked = true; }
                else { this.passport_status_deactive.Checked = true; }
            }
        }



        public void updateEmployeePersonalDetails()
        {
            Employee employee = new Employee();

            employee.setAction_status(this.action_status.Text);
            employee.setBlood_grouph(this.blood_group.Text);
            employee.setDate_issued(this.date_issued.Text);
            employee.setEmployee_no(this.employee_no.Text);
            employee.setEmployee_type(this.employee_type.Text);
            employee.setEpf_no(this.epf_no.Text);
            employee.setFirst_name(this.first_name.Text);
            //employee.setFull_name(full_name.Text);
            //employee.setImg_url();
            employee.setInitials(this.initials.Text);
            employee.setLast_name(this.last_name.Text);
            employee.setDate_of_birth(this.dob_date.Value.Date);
            employee.setDate_of_marriage(this.marry_date.Value.Date);

            if (this.married.Checked) { employee.setMarried(1); }
            else { employee.setMarried(0); }

            employee.setNationality(this.nationality.Text);
            employee.setNic_no(this.nic_no.Text);
            employee.setOccupation(this.occupation.Text);
            employee.setOld_employee_no(this.old_employee_no.Text);
            employee.setPlace_of_birth(this.place_of_birth.Text);
            employee.setReligion(this.religion.Text);
            employee.setSalutation(this.salutation.Text);

            bool state = EmployeeHandler.updateEmployee(employee);

            Console.Write(state+"\n");

        }


        public void updateContactDetails()
        {
            ContactDetails cd = new ContactDetails();
            cd.cd_id = this.cd_id;
            cd.cur_address = this.cur_address.Text;
            cd.cur_city = this.cur_city.Text;
            cd.cur_district = this.cur_district.Text;
            cd.cur_email = this.cur_email.Text;
            cd.cur_fax = this.cur_fax.Text;
            cd.cur_grama = this.cur_grama.Text;
            cd.cur_home_no = this.cur_home_no.Text;
            cd.cur_mobile = this.cur_mobile.Text;
            cd.cur_polling_division = this.cur_polling_division.Text;
            cd.cur_province = this.cur_province.Text;
            cd.cur_teleophone = this.cur_teleophone.Text;
            cd.cur_uc = this.cur_uc.Text;
            cd.perm_address = this.perm_address.Text;
            cd.perm_city = this.perm_city.Text;
            cd.perm_district = this.perm_district.Text;
            cd.perm_email = this.perm_email.Text;
            cd.perm_fax = this.perm_fax.Text;
            cd.perm_grama = this.perm_grama.Text;
            cd.perm_home_no = this.perm_home_no.Text;
            cd.perm_mobile = this.perm_mobile.Text;
            cd.perm_polling_division = this.perm_polling_division.Text;
            cd.perm_province = this.perm_province.Text;
            cd.perm_teleophone = this.perm_teleophone.Text;
            cd.perm_uc = this.perm_uc.Text;

            bool state = ContactDetailsHandler.updateContactDetails(cd);

            Console.Write(state + "\n");
        }


        public void updateDependentDetails() {
            DependentDetails dd = new DependentDetails();

            dd.dd_id = this.dd_id;
            dd.birth_certificate = this.depend_birth_certificate.Text;
            dd.setDate_of_post(this.depend_date_of_post_date.Value.Date);
            dd.education = this.depend_education.Text;
            dd.full_name = this.depend_full_name.Text;
            dd.marriage_certificate = this.depend_marriage_certificate.Text;
            dd.nic_no = this.depend_nic_no.Text;
            dd.note = this.depend_note.Text;
            dd.office_tp = this.depend_office_tp.Text;
            dd.official_address = this.depend_official_address.Text;
            dd.personal_address = this.depend_personal_address.Text;
            dd.personal_tp = this.depend_personal_tp.Text;
            dd.relation = this.depend_relation.Text;
            dd.salutation = this.depend_salutation.Text;
            dd.status = this.depend_status.Text;

            bool state = DependentDetailsHandler.updateDependentDetails(dd);

            Console.Write(state + "\n");
        }


        public void updateEmergencyContact()
        {
            EmergencyContact ec = new EmergencyContact();
            ec.ec_id = this.ec_id;
            ec.employee_no = this.emg_employee_no.Text;
            ec.full_name = this.emg_full_name.Text;
            ec.int_ext = this.emg_int_ext.Text;
            ec.mobile_no = this.emg_mobile_no.Text;
            ec.nic_no = this.emg_nic_no.Text;
            ec.office_tp = this.emg_office_tp.Text;
            ec.official_address = this.emg_official_address.Text;
            ec.personal_address = this.emg_personal_address.Text;
            ec.personal_tp = this.emg_personal_tp.Text;
            ec.priority = this.emg_priority.Text;
            ec.relation = this.emg_relation.Text;
            ec.salutation = this.emg_salutation.Text;

            bool state = EmergencyContactHandler.updateEmergencyContact(ec);

            Console.Write(state + "\n");
        }


        public void updateWorkstation()
        {
            WorkstationDetails wd = new WorkstationDetails();

            wd.ws_id = this.ws_id;
            wd.division = this.wsd_division.Text;
            wd.post = this.wsd_post.Text;
            wd.power = this.wsd_power.Text;
            wd.rank = this.wsd_rank.Text;
            wd.responsibility = this.wsd_responsibility.Text;
            wd.salary_station = this.wsd_salary_station.Text;
            wd.setDate_of_post(this.wsd_date_of_post_date.Value.Date);

            bool state = WorkstationDetailsHandler.updateWorkstationDetails(wd);

            Console.Write(state + "\n");
        }


        public void updateQualification()
        {
            Qualification q = new Qualification();

            q.q_id = this.q_id;
            if (this.qual_highest_qualification.Checked) { q.highest_qualification = true; }
            else { q.highest_qualification = false; }

            if (this.qual_occupation_relevant.Checked) { q.occupation_relevant = true; }
            else { q.occupation_relevant = false; }

            q.institute = this.qual_institute.Text;
            q.months = this.qual_months.Text;
            q.note = this.qual_note.Text;
            q.qualification = this.qual_qualification.Text;
            q.qualification_no = this.qualification_no.Text;
            q.status = this.qual_status.Text;
            q.year = this.qual_year.Text;

            bool state = QualificationsHandler.updateQualifications(q);

            Console.Write(state + "\n");
        }


        public void updateWorkingExperience()
        {
            WorkingExperience we = new WorkingExperience();

            we.we_id = this.we_id;
            we.address = this.we_address.Text;
            we.award = this.we_award.Text;
            we.contact = this.we_contact.Text;
            we.department = this.we_department.Text;
            we.email = this.we_department.Text;
            we.institute = this.we_institute.Text;

            if (this.we_occupation_relevant.Checked) { we.occupation_relevant = true; }
            else { we.occupation_relevant = false; }

            we.resign_reason = this.we_resign_reason.Text;
            we.responsibility = this.we_responsibility.Text;
            we.telephone = this.we_telephone.Text;
            we.setDate_from(this.we_date_from_date.Value.Date);
            we.setDate_to(this.we_date_to_date.Value.Date);
            we.setDate_perma(this.we_date_perma_date.Value.Date);

            bool state = WorkingExperienceHandler.updateWorkingExperience(we);

            Console.Write(state + "\n");
        }


        public void updateExtraCurAc()
        {
            ExtracurricularActivity eca = new ExtracurricularActivity();

            eca.ea_id = this.ea_id;
            eca.award = this.ea_award.Text;
            eca.method = this.ea_method.Text;
            eca.type = this.ea_type.Text;

            bool state = ExtracurricularActivityHandler.updateExtracurricularActivity(eca);

            Console.Write(state + "\n");
        }


        public void updateMembership()
        {
            Membership m = new Membership();

            m.mem_id = this.mem_id;
            m.contribution = this.member_contribution.Text;
            m.institute = this.member_institute.Text;
            m.member_id = this.member_id.Text;
            m.post_name = this.memebr_post_name.Text;
            m.method = this.member_method.Text;

            m.setBegin_date(this.member_begin_date_date.Value.Date);
            m.setRenewal_date(this.member_renewal_date.Value.Date);
            m.setActive_date_insti(this.member_active_date_insti_date.Value.Date);
            m.setActive_date_person(this.member_active_date_person_date.Value.Date);

            if (this.member_institutional_payment.Checked) { m.institutional_payment = true; }
            else { m.institutional_payment = false; }

            if (this.member_personal_payment.Checked) { m.personal_payment = true; }
            else { m.personal_payment = false; }

            bool state = MembershipHandler.updateMembership(m);

            Console.Write(state + "\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Language l = new Language();
            l.language_name = this.language_name.Text;
            bool status = LanguageHandler.addLanguage(l);
        }

        public void updateFinance()
        {
            //Update finance bank details
            FinanceBank fb = new FinanceBank();
            fb.fb_id = this.fb_id;
            fb.bank_name = this.bank_name.Text;
            fb.branch_name = this.bank_branch_name.Text;
            fb.account_number = this.bank_account_name.Text;
            fb.account_type = this.bank_account_type.Text;
            fb.setBegin_date(this.bank_account_started_year.Value.Date);
            fb.setEnd_date(this.bank_account_closed_year.Value.Date);
            fb.Qual_year = this.bank_qualified_year.Text;
            fb.qualification = this.bank_qualification.Text;
            bool state = FinanceBankHandler.updateFinanceBank(fb);
            Console.Write(state + "\n");

            //Update finance insurance details
            FinanceInsurance fi = new FinanceInsurance();
            fi.fi_id = this.fi_id;
            fi.type = this.insurance_type.Text;
            fi.value = Convert.ToDouble(this.insurance_value.Text);
            fi.setBegin_date(this.insurance_started_date.Value.Date);
            fi.setEnd_date(this.insurance_ended_year.Value.Date);
            fi.note = this.insurance_notes.Text;
            state = FinanceInsuranceHandler.updateFinanceInsurance(fi);
            Console.Write(state + "\n");

            //Update finance tax details
            FinanceTax ft = new FinanceTax();
            ft.ft_id = this.ft_id;
            ft.type = this.tax_type.Text;
            ft.number = this.tax_no.Text;
            ft.payment_method = this.tax_paying_method.Text;
            ft.status = this.tax_status.Text;
            ft.note = this.tax_notes.Text;
            state = FinanceTaxHandler.updateFinanceTax(ft);
            Console.Write(state + "\n");
        }


        public void updateRemuneration()
        {
            Remuneration r = new Remuneration();

            r.r_id = this.r_id;
            r.salary_grade = this.remun_salary_grade.Text;
            r.salary_slip_no = this.remun_salary_slip_no.Text;
            r.basic_salary = (float)Convert.ToDouble(this.remun_basic_salary.Text);
            r.transport_allowance = (float)Convert.ToDouble(this.remun_transport_allowance.Text);
            r.fuel_allowance = (float)Convert.ToDouble(this.remun_fuel_allowance.Text);
            r.mobile_phone_allowance = (float)Convert.ToDouble(this.remun_mobile_phone_allowance.Text);
            r.housing_allowance = (float)Convert.ToDouble(this.remun_housing_allowance.Text);
            r.other_allowance = (float)Convert.ToDouble(this.remun_other_allowance.Text);
            r.salary_increase_amount = (float)Convert.ToDouble(this.remun_salary_increase_amount.Text);
            r.current_total_salary = (float)Convert.ToDouble(this.remun_current_total_salary.Text);
            r.setsalary_increase_date(this.remun_salary_increase_date.Value.Date);
            bool state = RemunerationHandler.updateRemuneration(r);
            Console.Write(state + "\n");
        }



        public void updateBenefits()
        {
            CashBenefit cb = new CashBenefit();
            cb.cb_id = this.cb_id;
            cb.approved_benefit = this.cash_approved_benefit.Text;
            cb.price = (float)Convert.ToDouble(this.cash_issued_price.Text);
            cb.setdate_issued(this.cash_issued_date.Value.Date);
            bool state = BenefitsHandler.updateCashBenefit(cb);
            Console.Write(state + "\n");

            NonCashBenefit ncb = new NonCashBenefit();
            ncb.ncb_id = this.ncb_id;
            ncb.approved_benefit = this.noncash_approved_benefit.Text;
            ncb.price = (float)Convert.ToDouble(this.noncash_price.Text);
            ncb.amount = (float)Convert.ToDouble(this.noncash_quantity.Text);
            ncb.setdate_issued(this.noncash_issued_date.Value.Date);
            state = BenefitsHandler.updateNonCashBenefit(ncb);
            Console.Write(state + "\n");

        }


        public void updatePassport()
        {
            Passport p = new Passport();

            p.p_id = this.p_id;
            p.number = this.passport_no.Text;
            p.place_of_issue = this.passport_issued_place.Text;
            p.post = this.passport_post.Text;
            p.rank = this.passport_rank.Text;
            p.setdate_of_issue(this.passport_issued_date.Value.Date);
            p.setdate_of_renewal(this.passport_renewal_date.Value.Date);

            if (this.passport_status_active.Checked) { p.status = true; }
            else { p.status = false; }

            bool state = PassportHandler.updatePassport(p);
            Console.Write(state + "\n");
        }

    }
}
