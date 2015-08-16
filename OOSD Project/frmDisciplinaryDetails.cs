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
            if(disciplinary_employee_no.Text == "")
            {
                disciplinary_employee_no.BackColor = Color.RosyBrown;
                state = false;
            }
            if (disciplinary_full_name.Text == "" || !Validator.text(disciplinary_full_name.Text))
            {
                disciplinary_full_name.BackColor = Color.RosyBrown;
                state = false;
            }

            if (disciplinary_post.Text == "" || !Validator.text(disciplinary_post.Text))
            {
                disciplinary_post.BackColor = Color.RosyBrown;
                state = false;
            }

            if (disciplinary_rank.Text == "" || !Validator.text(disciplinary_rank.Text))
            {
                disciplinary_rank.BackColor = Color.RosyBrown;
                state = false;
            }

            if (disciplinary_breaking.Text == "" || !Validator.text(disciplinary_breaking.Text))
            {
                disciplinary_breaking.BackColor = Color.RosyBrown;
                state = false;
            }

            if (disciplinary_request_of_main_administration_officer.Text == "" || !Validator.text(disciplinary_request_of_main_administration_officer.Text))
            {
                disciplinary_request_of_main_administration_officer.BackColor = Color.RosyBrown;
                state = false;
            }

            if(disciplinary_given_sentence.Text == "" || !Validator.text(disciplinary_given_sentence.Text)){
                disciplinary_given_sentence.BackColor = Color.RosyBrown;
                state = false;
            }

            if (disciplinary_verdict_of_director_general.Text == "" || !Validator.text(disciplinary_verdict_of_director_general.Text))
            {
                disciplinary_verdict_of_director_general.BackColor = Color.RosyBrown;
                state = false;
            }

            if (disciplinary_inquiry_officer.Text == "" || !Validator.text(disciplinary_inquiry_officer.Text))
            {
                disciplinary_inquiry_officer.BackColor = Color.RosyBrown;
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

        }

        private void disciplinary_employee_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            disciplinary_employee_no.BackColor = Color.White;
        }

        private void disciplinary_full_name_TextChanged(object sender, EventArgs e)
        {
            disciplinary_full_name.BackColor = Color.White;
        }

        private void disciplinary_post_TextChanged(object sender, EventArgs e)
        {
            disciplinary_post.BackColor = Color.White;
        }

        private void disciplinary_rank_TextChanged(object sender, EventArgs e)
        {
            disciplinary_rank.BackColor = Color.White;
        }

        private void disciplinary_breaking_TextChanged(object sender, EventArgs e)
        {
            disciplinary_breaking.BackColor = Color.White;
        }

        private void disciplinary_request_of_main_administration_officer_TextChanged(object sender, EventArgs e)
        {
            disciplinary_request_of_main_administration_officer.BackColor = Color.White;
        }

        private void disciplinary_given_sentence_TextChanged(object sender, EventArgs e)
        {
            disciplinary_given_sentence.BackColor = Color.White;
        }

        private void disciplinary_verdict_of_director_general_TextChanged(object sender, EventArgs e)
        {
            disciplinary_verdict_of_director_general.BackColor = Color.White;
        }

        private void disciplinary_inquiry_officer_TextChanged(object sender, EventArgs e)
        {
            disciplinary_inquiry_officer.BackColor = Color.White;
        }

        private void btnCheckDisciplinaryDetails_Click(object sender, EventArgs e)
        {
            validateDiciplinaryDetails();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
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
            // Setting fonts
            iTextSharp.text.Font fontHeader_1 = FontFactory.GetFont("Calibri", 30, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0));
            iTextSharp.text.Font fontHeader_2 = FontFactory.GetFont("Calibri", 15, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(125, 125, 125));
            iTextSharp.text.Font fontContentTopic = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.NORMAL, new iTextSharp.text.BaseColor(125, 125, 125));
            iTextSharp.text.Font fontSubContentTopic = FontFactory.GetFont("Calibri", 9, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0));
            iTextSharp.text.Font fontContent = FontFactory.GetFont("Calibri", 9, iTextSharp.text.Font.NORMAL, new iTextSharp.text.BaseColor(0, 0, 0));

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
            try
            {
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(pictureBox1.ImageLocation);
                img.ScaleToFit(100f, 100f);
                img.Border = iTextSharp.text.Rectangle.BOX;
                img.BorderColor = iTextSharp.text.BaseColor.BLACK;
                img.BorderWidth = 5f;
                img.Alignment = iTextSharp.text.Image.TEXTWRAP | iTextSharp.text.Image.ALIGN_RIGHT | iTextSharp.text.Image.ALIGN_TOP;
                img.IndentationLeft = 50f;
                img.SpacingAfter = 20f;
                img.SpacingBefore = 20f;
                report.Add(img);
            }catch(System.ArgumentNullException exceptionArgumentNullException) { }

            if (disciplinary_employee_no.Text != "")
            {
                Paragraph paraContentTopic_1 = new Paragraph("Employee No", fontContentTopic);
                report.Add(paraContentTopic_1);
                Paragraph paraContent_1 = new Paragraph(disciplinary_employee_no.Text, fontContent);
                report.Add(paraContent_1);
            }

            if(disciplinary_full_name.Text != "")
            {
                Paragraph paraContentTopic_2 = new Paragraph("Old employee No", fontContentTopic);
                report.Add(paraContentTopic_2);
                Paragraph paraContent_2 = new Paragraph(disciplinary_full_name.Text, fontContent);
                report.Add(paraContent_2);
            }            

            if(disciplinary_post.Text != "")
            {
                Paragraph paraContentTopic_3 = new Paragraph("Post", fontContentTopic);
                report.Add(paraContentTopic_3);
                Paragraph paraContent_3 = new Paragraph(disciplinary_post.Text, fontContent);
                report.Add(paraContent_3);
            }            

            if (disciplinary_rank.Text != "")
            {
                Paragraph paraContentTopic_4 = new Paragraph("Rank", fontContentTopic);
                report.Add(paraContentTopic_4);
                Paragraph paraContent_4 = new Paragraph(disciplinary_rank.Text, fontContent);
                report.Add(paraContent_4);
            }

            if(disciplinary_breaking.Text != "")
            {
                Paragraph paraContentTopic_5 = new Paragraph("Discipline Breaking", fontContentTopic);
                report.Add(paraContentTopic_5);
                Paragraph paraContent_5 = new Paragraph(disciplinary_breaking.Text, fontContent);
                report.Add(paraContent_5);
            }

            if (disciplinary_breaking_date.Text != "")
            {
                Paragraph paraContentTopic_6 = new Paragraph("Discipline Breaking Date", fontContentTopic);
                report.Add(paraContentTopic_6);
                Paragraph paraContent_6 = new Paragraph(disciplinary_breaking_date.Text, fontContent);
                report.Add(paraContent_6);
            }
            
            if (disciplinary_request_of_main_administration_officer.Text != "")
            {
                Paragraph paraContentTopic_7 = new Paragraph("Request of Main Administration Officer", fontContentTopic);
                report.Add(paraContentTopic_7);
                Paragraph paraContent_7 = new Paragraph(disciplinary_request_of_main_administration_officer.Text, fontContent);
                report.Add(paraContent_7);
            }

            if (disciplinary_given_sentence.Text != "")
            {
                Paragraph paraContentTopic_8 = new Paragraph("Given Sentence", fontContentTopic);
                report.Add(paraContentTopic_8);
                Paragraph paraContent_8 = new Paragraph(disciplinary_given_sentence.Text, fontContent);
                report.Add(paraContent_8);
            }

            if (disciplinary_given_sentence_date.Text != "")
            {
                Paragraph paraContentTopic_9 = new Paragraph("Sentence Given Date", fontContentTopic);
                report.Add(paraContentTopic_9);
                Paragraph paraContent_9 = new Paragraph(disciplinary_given_sentence_date.Text, fontContent);
                report.Add(paraContent_9);
            }

            if (disciplinary_verdict_of_director_general.Text != "")
            {
                Paragraph paraContentTopic_10 = new Paragraph("Verdict of Director General", fontContentTopic);
                report.Add(paraContentTopic_10);
                Paragraph paraContent_10 = new Paragraph(disciplinary_verdict_of_director_general.Text, fontContent);
                report.Add(paraContent_10);
            }

            if (disciplinary_verdict_of_director_general_date.Text != "")
            {
                Paragraph paraContentTopic_11 = new Paragraph("Date of Verdict", fontContentTopic);
                report.Add(paraContentTopic_11);
                Paragraph paraContent_11 = new Paragraph(disciplinary_verdict_of_director_general_date.Text, fontContent);
                report.Add(paraContent_11);
            }

            if (disciplinary_inquiry_officer.Text != "")
            {
                Paragraph paraContentTopic_12 = new Paragraph("Inquired Officer", fontContentTopic);
                report.Add(paraContentTopic_12);
                Paragraph paraContent_12 = new Paragraph(disciplinary_inquiry_officer.Text, fontContent);
                report.Add(paraContent_12);
            }

            if (disciplinary_suspended_date.Text != "")
            {
                Paragraph paraContentTopic_13 = new Paragraph("Suspended Date", fontContentTopic);
                report.Add(paraContentTopic_13);
                Paragraph paraContent_13 = new Paragraph(disciplinary_suspended_date.Text, fontContent);
                report.Add(paraContent_13);
            }

            if (disciplinary_suspended_date.Text != "")
            {
                Paragraph paraContentTopic_14 = new Paragraph("Rejoined Date", fontContentTopic);
                report.Add(paraContentTopic_14);
                Paragraph paraContent_14 = new Paragraph(disciplinary_rejoined_date.Text, fontContent);
                report.Add(paraContent_14);
            }

            if (disciplinary_suspended_time.Text != "")
            {
                Paragraph paraContentTopic_15 = new Paragraph("Suspended Time Period", fontContentTopic);
                report.Add(paraContentTopic_15);
                Paragraph paraContent_15 = new Paragraph(disciplinary_suspended_time.Text, fontContent);
                report.Add(paraContent_15);
            }

            report.Close();
            this.Close();
        }
    }
}
