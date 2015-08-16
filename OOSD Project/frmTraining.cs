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
    public partial class frmTraining : Form
    {
        private static frmTraining form;

        public frmTraining()
        {
            InitializeComponent();

            employee_no.Text = Employee.emp_no;
            full_name.Text = Employee.employee_name;
            training_employee_no.Text = Employee.emp_no;
            training_full_name.Text = Employee.employee_name;

            if (!(TrainingHandler.getTraining() == null))
            {
                loadDetails();
                
            }
        }

        public static frmTraining getForm()
        {
            if (form == null)
            {
                form = new frmTraining();
            }
            return form;
        }



        public void loadDetails()
        {

            Training t = TrainingHandler.getTraining();

            training_country.Text = t.country;
            training_course_name.Text = t.course_name;
            training_course_type.Text = t.course_type;
            training_ending_date.Value = t.ending_date;
            training_extended_days.Text = t.extended_days;
            training_institute.Text = t.institute;
            training_new_ending_date.Value = t.new_ending_date;
            training_payments.Text = t.payments;
            training_result.Text = t.result;
            training_started_date.Value = t.started_date;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool t_present = true;
            if (TrainingHandler.getTraining() == null)
            {
                t_present = false;
            }

            Training t = null;

            if (!t_present)
            {
                t = new Training();
            }
            else
            {
                t = TrainingHandler.getTraining();
            }

            t.country = training_country.Text;
            t.course_name = training_course_name.Text;
            t.course_type = training_course_type.Text;
            t.ending_date = training_ending_date.Value.Date;
            t.extended_days = training_extended_days.Text;
            t.institute = training_institute.Text;
            t.new_ending_date = training_new_ending_date.Value.Date;
            t.payments = training_payments.Text;
            t.result = training_result.Text;
            t.started_date = training_started_date.Value.Date;

            bool state;

            if (!t_present)
            {
                state = TrainingHandler.addTraining(t);
            }
            else
            {
                state = TrainingHandler.updateTraining(t);
            }

            if (state)
            {
                MessageBox.Show("Employee Training details updated succesfully...!");

            }
            else
            {
                MessageBox.Show("Updating Training details failed...!");
            }
        }
    }
}
