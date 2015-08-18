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
        }

        public static frmRe_Appointment getForm()
        {
            if (form == null)
            {
                form = new frmRe_Appointment();
            }
            return form;
        }

        private bool validateReAppoinmentDetails()
        {

            bool state = true;
            if(!Validator.validate(reappointment_employee_no, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if(!Validator.validate(reappointment_suspension__system, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if (!Validator.validate(reappointment_suspension_reason, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            return state;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckReApoinmentDetails_Click(object sender, EventArgs e)
        {
            validateReAppoinmentDetails();
        }

        private void reappointment_employee_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            reappointment_employee_no.BackColor = Color.White;
        }

        private void reappointment_suspension__system_TextChanged(object sender, EventArgs e)
        {
            reappointment_suspension__system.BackColor = Color.White;
        }

        private void reappointment_suspension_reason_TextChanged(object sender, EventArgs e)
        {
            reappointment_suspension_reason.BackColor = Color.White;
        }
    }
}
