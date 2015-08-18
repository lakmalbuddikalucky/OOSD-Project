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
    public partial class frmInterdict_Suspend : Form
    {
        private static frmInterdict_Suspend form;

        public frmInterdict_Suspend()
        {
            InitializeComponent();
        }

        public static frmInterdict_Suspend getForm()
        {
            if (form == null)
            {
                form = new frmInterdict_Suspend();
            }
            return form;
        }

        private bool validateInterdictSuspendDetails()
        {
            bool state = true;
            if (!Validator.validate(interdict_employee_no, VALIDATE_TYPE.NOT_NULL))
            {
                state = false;
            }

            if(!Validator.dateDiff(DateTime.Today, interdict_unattended_date_from.Value))
            {
                erp_interdict_unattended_date_from.SetError(interdict_unattended_date_from, "Invalid date");
                state = false;
            }

            if (!Validator.dateDiff(interdict_unattended_date_to.Value, interdict_unattended_date_from.Value) || !Validator.validate(interdict_unattended_date_to, VALIDATE_TYPE.LESS_THAN_SYS_DATE))
            {
                erp_interdict_unattended_date_to.SetError(interdict_unattended_date_to, "Invalid date");
                state = false;
            }

            if(interdict_date_to.Enabled == true && !Validator.dateDiff(interdict_date_to.Value, interdict_date_from.Value))
            {
                erp_interdict_date_to.SetError(interdict_date_to, "Invalid date");
                state = false;
            }
            return state;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void interdict_employee_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            interdict_employee_no.BackColor = Color.White;
        }

        private void interdict_full_name_TextChanged(object sender, EventArgs e)
        {
            interdict_full_name.BackColor = Color.White;
        }

        private void interdict_post_TextChanged(object sender, EventArgs e)
        {
            interdict_post.BackColor = Color.White;
        }

        private void interdict_rank_TextChanged(object sender, EventArgs e)
        {
            interdict_rank.BackColor = Color.White;
        }

        private void interdict_unattended_date_to_ValueChanged(object sender, EventArgs e)
        {
            erp_interdict_unattended_date_to.Dispose();
        }

        private void interdict_unattended_date_from_ValueChanged(object sender, EventArgs e)
        {
            erp_interdict_unattended_date_from.Dispose();
            erp_interdict_unattended_date_to.Dispose();
        }

        private void interdict_date_from_ValueChanged(object sender, EventArgs e)
        {
            erp_interdict_unattended_date_to.Dispose();
        }

        private void interdict_date_to_ValueChanged(object sender, EventArgs e)
        {
            erp_interdict_unattended_date_to.Dispose();
        }

        private void interdict_rejoined_CheckedChanged(object sender, EventArgs e)
        {
            interdict_date_to.Enabled = true;
        }

        private void interdict_not_rejoined_CheckedChanged(object sender, EventArgs e)
        {
            interdict_date_to.Enabled = false;
            erp_interdict_date_to.Dispose();
        }

        private void btnCheckInterdictSuspendDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show(validateInterdictSuspendDetails() + "");
            
        }
    }
}
