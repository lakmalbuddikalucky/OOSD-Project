using OOSD_Project.Database;
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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            //search
            InitializeComponent();


            //Load employee numbers to combo box
            List<string> em_nos = EmployeeHandler.getAllEmployees();
            employee_no.Text = "Select employee number";

            foreach (string Txt in em_nos)
            {
                employee_no.Items.Add(Txt);

            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmEmployeeFinanceDetails form9 = new frmEmployeeFinanceDetails();
            form9.Show();
            this.Dispose();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmMain form10 = new frmMain();
            form10.Show();
            this.Dispose();
        }

        private void employee_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.Write("Combo");
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

        }
    }
}
