using OOSD_Project.Database;
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
            
            //Load personal details
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


            //Load contact details
            ContactDetails cd = ContactDetailsHandler.getContactDetails();

            Console.Write(cd.cur_province+"\n");

            perm_address.Text = cd.perm_address;
            perm_city.Text = cd.perm_city;
            perm_district.Text = cd.perm_district;
            perm_email.Text = cd.perm_email;
            perm_fax.Text = cd.perm_fax;
            perm_grama.Text = cd.perm_grama;
            perm_home_no.Text = cd.perm_home_no;
            perm_mobile.Text = cd.perm_mobile;
            perm_polling_division.Text = cd.perm_polling_division;
            perm_province.Text = cd.perm_province;
            perm_teleophone.Text = cd.perm_teleophone;
            perm_uc.Text = cd.perm_uc;
            cur_address.Text = cd.cur_address;
            cur_city.Text = cd.cur_city;
            cur_district.Text = cd.cur_district;
            cur_email.Text = cd.cur_email;
            cur_fax.Text = cd.cur_fax;
            cur_grama.Text = cd.cur_grama;
            cur_home_no.Text = cd.cur_home_no;
            cur_mobile.Text = cd.cur_mobile;
            cur_polling_division.Text = cd.cur_polling_division;
            cur_province.Text = cd.cur_province;
            cur_teleophone.Text = cd.cur_teleophone;
            cur_uc.Text = cd.cur_uc;
           

        }
    }
}
