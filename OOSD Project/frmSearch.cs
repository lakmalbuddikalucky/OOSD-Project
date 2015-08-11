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

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace OOSD_Project
{
    public partial class frmSearch : Form
    {
        private static frmSearch form;

        public frmSearch()
        {
            //search
            InitializeComponent();


            //Load employee numbers to combo box
            List<string> em_nos = EmployeeHandler.getAllEmployees();
            employee_no.Text = "Select employee number";
            /*
            foreach (string Txt in em_nos)
            {
                employee_no.Items.Add(Txt);

            }*/
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


            //Load working experience details
            WorkingExperience we = WorkingExperienceHandler.getWorkingExperience();

            we_address.Text = we.address;
            we_award.Text = we.award;
            we_contact.Text = we.contact;
            we_department.Text = we.department;
            we_email.Text = we.email;
            we_institute.Text = we.institute;
            we_resign_reason.Text = we.resign_reason;
            we_telephone.Text = we.telephone;


            //Load extra curricular activity details
            ExtracurricularActivity ea = ExtracurricularActivityHandler.getExtracurricularActivity();

            ea_award.Text = ea.award;
            ea_method.Text = ea.method;
            ea_type.Text = ea.type;



            //Load membership details
            /*Membership mem = MembershipHandler.getMembership();

            member_contribution.Text = mem.contribution;
            member_id.Text = mem.member_id;
            member_institute.Text = mem.institute;
            member_method.Text = mem.method;
            member_status.Text = mem.status;
            memebr_post_name.Text = mem.post_name;

            if (mem.personal_payment == true) { member_personal_payment.Checked = true; }
            else { member_personal_payment.Checked = false; }

            if (mem.institutional_payment == true) { member_institutional_payment.Checked = true; }
            else { member_institutional_payment.Checked = false; }*/

        }

        private void wsd_rank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
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
    }
}
