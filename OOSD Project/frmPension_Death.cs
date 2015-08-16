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
    public partial class frmPension_Death : Form
    {
        private static frmPension_Death form;

        public frmPension_Death()
        {
            InitializeComponent();

            employee_no.Text = Employee.emp_no;
            full_name.Text = Employee.employee_name;
            pension_employee_no.Text = Employee.emp_no;
            pension_full_name.Text = Employee.employee_name;

            if (!(PensionAndDeathHandler.getPensionAndDeath() == null))
            {
                loadDetails();
            }
        }

        public static frmPension_Death getForm()
        {
            if (form == null)
            {
                form = new frmPension_Death();
            }
            return form;
        }


        public void loadDetails()
        {

            PensionAndDeath pd = PensionAndDeathHandler.getPensionAndDeath();

            pension_died_date.Value = pd.died_date;
            pension_informed_date.Value = pd.informed_date;
            pension_notes.Text = pd.note;
           
            if (pd.retired){pension_retired.Checked = true;}
            else { pension_retired.Checked = false; }

            if (pd.dead) { pension_dead.Checked = true; }
            else { pension_dead.Checked = false; }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            bool pd_present = true;
            if (PensionAndDeathHandler.getPensionAndDeath() == null)
            {
                pd_present = false;
            }

            PensionAndDeath pd = null;

            if (!pd_present)
            {
                pd = new PensionAndDeath();
            }
            else
            {
                pd = PensionAndDeathHandler.getPensionAndDeath();
            }

            pd.note = pension_notes.Text;

            pd.died_date = pension_died_date.Value.Date;
            pd.informed_date = pension_informed_date.Value.Date;

            if (pension_retired.Checked) { pd.retired = true; }
            else { pd.retired = false; }

            if (pension_dead.Checked) { pd.dead = true; }
            else { pd.dead = false; }


            bool state;

            if (!pd_present)
            {
                state = PensionAndDeathHandler.addPensionAndDeath(pd);
            }
            else
            {
                state = PensionAndDeathHandler.updatePensionAndDeath(pd);
            }

            if (state)
            {
                MessageBox.Show("Employee Pension and Death details updated succesfully...!");

            }
            else
            {
                MessageBox.Show("Updating Pension and Death details failed...!");
            }

        }
    }
}
