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
    public partial class frmEmployeePersonalDetails : Form
    {
        public frmEmployeePersonalDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Employee employee = new Employee();

            employee.setAction_status(action_status.Text);
            employee.setBlood_grouph(blood_group.Text);
            employee.setDate_issued(date_issued.Text);
            employee.setDate_of_birth(dob_year.Text, dob_month.Text, dob_date.Text);
            employee.setDate_of_marriage(marry_year.Text, marry_month.Text, marry_date.Text);
            employee.setEmployee_no(employee_no.Text);
            employee.setEmployee_type(employee_type.Text);
            employee.setEpf_no(epf_no.Text);
            employee.setFirst_name(first_name.Text);
            employee.setFull_name(full_name.Text);
            //employee.setImg_url();
            employee.setInitials(initials.Text);
            employee.setLast_name(last_name.Text);

            if (married.Checked){employee.setMarried(1);}
            else{employee.setMarried(0);}
            
            employee.setNationality(nationality.Text);
            employee.setNic_no(nic_no.Text);
            employee.setOccupation(occupation.Text);
            employee.setOld_employee_no(old_employee_no.Text);
            employee.setPlace_of_birth(place_of_birth.Text);
            employee.setReligion(religion.Text);
            employee.setSalutation(salutation.Text);

            bool state = EmployeeHandler.addEmployee(employee);

            if (state){MessageBox.Show("Employee details added succesfully...!");}
            else{MessageBox.Show("Adding employee details failed...!");}

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmEmployeeSpecialDetails form3 = new frmEmployeeSpecialDetails();
            form3.Show();
            this.Dispose();
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmMain form4 = new frmMain();
            form4.Show();
            this.Dispose();

        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
