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
    public partial class frmEmployeeRemunerationAndBenefits : Form
    {
        private static frmEmployeeRemunerationAndBenefits form;

        public frmEmployeeRemunerationAndBenefits()
        {
            InitializeComponent();

            if (!(Employee.emp_no == null))
            {
                employee_no.Text = Employee.emp_no;
                full_name.Text = Employee.employee_name;
            }
        }

        public static frmEmployeeRemunerationAndBenefits getForm()
        {
            if (form == null)
            {
                form = new frmEmployeeRemunerationAndBenefits();
            }
            return form;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPersonalDetails_Click(object sender, EventArgs e)
        {

        }

        private void tabNonCashBenefits_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Remuneration r = new Remuneration();

            r.salary_grade = remun_salary_grade.Text;
            r.salary_slip_no = remun_salary_no.Text;
            r.basic_salary = (float)Convert.ToDouble(remun_basic_salary.Text);
            r.transport_allowance = (float)Convert.ToDouble(remun_transport_allowance.Text);
            r.fuel_allowance = (float)Convert.ToDouble(remun_fuel_allowance.Text);
            r.mobile_phone_allowance = (float)Convert.ToDouble(remun_telephone_allowance.Text);
            r.housing_allowance = (float)Convert.ToDouble(remun_house_allowance.Text);
            r.other_allowance = (float)Convert.ToDouble(remun_other_allowances.Text);
            r.salary_increase_amount = (float)Convert.ToDouble(remun_increased_by.Text);
            r.current_total_salary = (float)Convert.ToDouble(remun_present_salary.Text);
            r.setsalary_increase_date(remun_salary_increased_date.Value.Date);

            bool state = RemunerationHandler.addRemuneration(r);

            if (state)
            {
                MessageBox.Show("Employee remuneration details added succesfully...!");

            }
            else
            {
                MessageBox.Show("Adding employee remuneration details failed...!");
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmPassportDetails.getForm().Show();
            this.Hide();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmEmployeeFinanceDetails.getForm().Show();
            this.Hide();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            CashBenefit cb = new CashBenefit();

            cb.approved_benefit = cash_approved_benefit.Text;
            cb.price = (float)Convert.ToDouble(cash_issued_price.Text);
            cb.setdate_issued(cash_issued_date.Value.Date);

            bool state = BenefitsHandler.addCashBenefit(cb);

            if (state)
            {
                MessageBox.Show("Employee Cash Benefit details added succesfully...!");

            }
            else
            {
                MessageBox.Show("Adding employee Cash Benefit details failed...!");
            }
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            NonCashBenefit ncb = new NonCashBenefit();

            ncb.approved_benefit = noncash_approved_benefit.Text;
            ncb.price = (float)Convert.ToDouble(noncash_price.Text);
            ncb.amount = (float)Convert.ToDouble(noncash_quantity.Text);
            ncb.setdate_issued(noncash_issued_date.Value.Date);

            bool state = BenefitsHandler.addNonCashBenefit(ncb);

            if (state)
            {
                MessageBox.Show("Employee NonCash Benefit details added succesfully...!");

            }
            else
            {
                MessageBox.Show("Adding employee NonCash Benefit details failed...!");
            }
        }
    }
}
