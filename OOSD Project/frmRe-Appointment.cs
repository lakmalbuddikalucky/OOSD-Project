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
    public partial class frmRe_Appointment : Form
    {
        private static frmRe_Appointment form;

        public frmRe_Appointment()
        {
            InitializeComponent();

            employee_no.Text = Employee.emp_no;
            full_name.Text = Employee.employee_name;
            reappointment_employee_no.Text = Employee.emp_no;
            reappointment_full_name.Text = Employee.employee_name;

            if (!(ReAppointmentHandler.getReAppointment() == null))
            {
                loadDetails();
            }
        }

        public static frmRe_Appointment getForm()
        {
            if (form == null)
            {
                form = new frmRe_Appointment();
            }
            return form;
        }


        public void loadDetails()
        {

            ReAppointment ra = ReAppointmentHandler.getReAppointment();

            reappointment_post.Text = ra.post;
            reappointment_rank.Text = ra.rank;

            reappointment_notes.Text = ra.notes;
            reappointment_rojoining_date.Value = ra.rejoining_date;
            reappointment_suspension__system.Text = ra.suspension__system;
            reappointment_suspension_approved_note.Text = ra.suspension_approved_note;
            reappointment_suspension_reason.Text = ra.suspension_reason;
            


        }


        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool ra_present = true;
            if (ReAppointmentHandler.getReAppointment() == null)
            {
                ra_present = false;
            }

            ReAppointment ra = null;

            if (!ra_present)
            {
                ra = new ReAppointment();
            }
            else
            {
                ra = ReAppointmentHandler.getReAppointment();
            }

            ra.post = reappointment_post.Text;
            ra.rank = reappointment_rank.Text;
            ra.notes = reappointment_notes.Text;
            ra.rejoining_date = reappointment_rojoining_date.Value.Date;
            ra.suspension__system = reappointment_suspension__system.Text;
            ra.suspension_approved_note = reappointment_suspension_approved_note.Text;
            ra.suspension_reason = reappointment_suspension_reason.Text;


            bool state;

            if (!ra_present)
            {
                state = ReAppointmentHandler.addReAppointment(ra);
            }
            else
            {
                state = ReAppointmentHandler.updateReAppointment(ra);
            }

            if (state)
            {
                MessageBox.Show("Employee Re-Appointment details updated succesfully...!");

            }
            else
            {
                MessageBox.Show("Updating Re-Appointment details failed...!");
            }
        }
    }
}
