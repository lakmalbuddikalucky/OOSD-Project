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
    public partial class frmPension_Death : Form
    {
        private static frmPension_Death form;

        public frmPension_Death()
        {
            InitializeComponent();
            gb_dead.Enabled = false;
        }

        public static frmPension_Death getForm()
        {
            if (form == null)
            {
                form = new frmPension_Death();
            }
            return form;
        }

        private bool validatePensionDeadDetails()
        {
            bool state = true;
            if (pension_dead.Checked == true)
            {
                if (!Validator.validate(pension_employee_no, VALIDATE_TYPE.NOT_NULL))
                {
                    state = false;
                }

                if(!Validator.validate(pension_full_name, VALIDATE_TYPE.NOT_NULL) || !Validator.validate(pension_full_name, VALIDATE_TYPE.TEXT))
                {
                    state = false;
                }

                if(!Validator.validate(pension_died_date, VALIDATE_TYPE.LESS_THAN_SYS_DATE))
                {
                    erp_pension_died_date.SetError(pension_died_date, "Invalid date");
                    state = false;
                }

                if(!Validator.validate(ref pension_informed_date, ref pension_died_date, VALIDATE_TYPE.DATE_DIFF)  || !Validator.validate(pension_informed_date, VALIDATE_TYPE.LESS_THAN_SYS_DATE))
                {
                    erp_pension_informed_date.SetError(pension_informed_date, "Invalid date");
                    state = false;
                }
            }

            


            return state;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void pension_dead_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void pension_retired_CheckedChanged(object sender, EventArgs e)
        {
            gb_dead.Enabled = false;
        }

        private void pension_dead_CheckedChanged_1(object sender, EventArgs e)
        {
            gb_dead.Enabled = true;
        }

        private void btnCheckPensionDeadDetails_Click(object sender, EventArgs e)
        {
            validatePensionDeadDetails();
        }

        private void pension_employee_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            pension_employee_no.BackColor = Color.White;
        }

        private void pension_full_name_TextChanged(object sender, EventArgs e)
        {
            pension_full_name.BackColor = Color.White;
        }

        private void pension_died_date_ValueChanged(object sender, EventArgs e)
        {
            erp_pension_died_date.Dispose();
        }

        private void pension_informed_date_ValueChanged(object sender, EventArgs e)
        {
            erp_pension_informed_date.Dispose();
        }
    }
}
