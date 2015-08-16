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
    public partial class frmInterdict_Suspend : Form
    {
        private static frmInterdict_Suspend form;

        public frmInterdict_Suspend()
        {
            InitializeComponent();

            employee_no.Text = Employee.emp_no;
            full_name.Text = Employee.employee_name;
            interdict_employee_no.Text = Employee.emp_no;
            interdict_full_name.Text = Employee.employee_name;

            if (!(InterdictSuspendHandler.getInterdictSuspend() == null))
            {
                loadDetails();
            }

        }

        public static frmInterdict_Suspend getForm()
        {
            if (form == null)
            {
                form = new frmInterdict_Suspend();
            }
            return form;
        }


        public void loadDetails()
        {

            InterdictSuspend s = InterdictSuspendHandler.getInterdictSuspend();

            interdict_post.Text = s.post;
            interdict_rank.Text = s.rank;
            interdict_unattended_date_from.Value = s.unattended_from;
            interdict_unattended_date_to.Value = s.unattended_to;
            interdict_date_from.Value = s.suspend_from;
            interdict_date_to.Value = s.suspend_to;
            interdict_more_notes.Text = s.more_notes;
            interdict_reason.Text = s.reason;

            if (s.rejoined) 
            { 
                interdict_rejoined.Checked = true;
            }
            else 
            { 
                interdict_not_rejoined.Checked = true; 
            }

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            bool is_present = true;
            if (InterdictSuspendHandler.getInterdictSuspend() == null)
            {
                is_present = false;
            }

            InterdictSuspend s = null;

            if (!is_present)
            {
                s = new InterdictSuspend();
            }
            else
            {
                s = InterdictSuspendHandler.getInterdictSuspend();
            }

            s.post = interdict_post.Text;
            s.rank = interdict_rank.Text;
            s.more_notes = interdict_more_notes.Text;
            s.reason = interdict_reason.Text;

            if (interdict_rejoined.Checked) { s.rejoined = true; }
            else { s.rejoined = false; }

            s.suspend_from = interdict_date_from.Value.Date;
            s.suspend_to = interdict_date_to.Value.Date;
            s.unattended_from = interdict_unattended_date_from.Value.Date;
            s.unattended_to = interdict_unattended_date_to.Value.Date;


            bool state;

            if (!is_present)
            {
                state = InterdictSuspendHandler.addInterdictSuspend(s);
            }
            else
            {
                state = InterdictSuspendHandler.updateInterdictSuspend(s);
            }

            if (state)
            {
                MessageBox.Show("Employee Interdict/Suspend details updated succesfully...!");

            }
            else
            {
                MessageBox.Show("Updating Interdict/Suspend details failed...!");
            }

        }
    }
}
