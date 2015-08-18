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
        bool date = false;
        bool text = false;
        public frmTraining()
        {
            InitializeComponent();
        }

        public static frmTraining getForm()
        {
            if (form == null)
            {
                form = new frmTraining();
            }
            return form;
        }

        private bool validateTrainingDetails()
        {
            bool state = true;
            if (!Validator.validate(training_employee_no, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if(!Validator.validate(training_course_name, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if (!Validator.validate(training_course_type, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if (!Validator.validate(training_institute, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if (Validator.validate(training_payments, VALIDATE_TYPE.NOT_NULL) && !Validator.validate(training_payments, VALIDATE_TYPE.MONEY))
            {
                state = false;
            }

            if(!Validator.validate(training_started_date, VALIDATE_TYPE.LESS_THAN_SYS_DATE))
            {
                erp_training_started_date.SetError(training_started_date, "Invalid date");
                state = false;
            }

            if(!Validator.validate(ref training_ending_date, ref training_started_date, VALIDATE_TYPE.DATE_DIFF))
            {
                erp_training_ending_date.SetError(training_ending_date, "Invalid date");
                state = false;
            }

            if(!Validator.validate(ref training_new_ending_date, ref training_ending_date, VALIDATE_TYPE.DATE_DIFF))
            {
                erp_training_new_ending_date.SetError(training_new_ending_date, "Invalid date");
                state = false;
            }

            if(training_extended_days.Text != "" && !Validator.validate(training_extended_days, VALIDATE_TYPE.NUMBER))
            {
                state = false;
            }

            if (!Validator.validate(training_country, VALIDATE_TYPE.NOT_NULL) || !Validator.validate(training_country, VALIDATE_TYPE.TEXT))
            {
                state = false;
            }
            return state;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckTrainingDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show(validateTrainingDetails() + "");
        }

        private void training_extended_days_TextChanged(object sender, EventArgs e)
        {
            training_extended_days.BackColor = Color.White;

            int result;
            if(int.TryParse(training_extended_days.Text, out result))
            {
                try
                {
                    if (Validator.validate(training_extended_days, VALIDATE_TYPE.NUMBER))
                    {
                        training_new_ending_date.Value = training_ending_date.Value.AddDays(int.Parse(training_extended_days.Text));
                    }

                    if (training_extended_days.Text == "")
                    {
                        training_new_ending_date.Value = training_ending_date.Value.AddDays(0);
                    }
                }
                catch(ArgumentOutOfRangeException ee)
                {
                    MessageBox.Show("Out of range", "Error");
                    training_extended_days.Text = "";
                }
                
            }
        }

        private void training_employee_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            training_employee_no.BackColor = Color.White;
        }

        private void training_course_name_TextChanged(object sender, EventArgs e)
        {
            training_course_name.BackColor = Color.White;
        }

        private void training_course_type_TextChanged(object sender, EventArgs e)
        {
            training_course_type.BackColor = Color.White;
        }

        private void training_institute_TextChanged(object sender, EventArgs e)
        {
            training_institute.BackColor = Color.White;
        }

        private void training_payments_TextChanged(object sender, EventArgs e)
        {
            training_payments.BackColor = Color.White;
        }

        private void training_started_date_ValueChanged(object sender, EventArgs e)
        {
            erp_training_started_date.Dispose();
            erp_training_ending_date.Dispose();
            erp_training_new_ending_date.Dispose();
        }

        private void training_ending_date_ValueChanged(object sender, EventArgs e)
        {
            erp_training_ending_date.Dispose();
            erp_training_new_ending_date.Dispose(); 
        }

        private void training_new_ending_date_ValueChanged(object sender, EventArgs e)
        {
            erp_training_new_ending_date.Dispose();
        }

        private void training_country_TextChanged(object sender, EventArgs e)
        {
            training_country.BackColor = Color.White;
        }

        private void training_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            training_country.BackColor = Color.White;
        }

        private void training_extended_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
