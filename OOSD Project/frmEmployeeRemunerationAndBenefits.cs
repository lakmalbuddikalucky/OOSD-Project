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
        }

        public static frmEmployeeRemunerationAndBenefits getForm()
        {
            if (form == null)
            {
                form = new frmEmployeeRemunerationAndBenefits();
            }
            return form;
        }

        private void setRenumerationToWhite()
        {
            remun_salary_no.BackColor = Color.White;
            remun_salary_grade.BackColor = Color.White;
            remun_basic_salary.BackColor = Color.White;
            remun_present_salary.BackColor = Color.White;
            remun_increased_by.BackColor = Color.White;
            remun_house_allowance.BackColor = Color.White;
            remun_transport_allowance.BackColor = Color.White;
            remun_telephone_allowance.BackColor = Color.White;
            remun_fuel_allowance.BackColor = Color.White;
            remun_other_allowances.BackColor = Color.White;
        }

        private void setCashBenefitToWhite()
        {
            cash_approved_benefit.BackColor = Color.White;
            cash_issued_price.BackColor = Color.White;
        }

        private void setNonCashBenefitToWhite() {
            noncash_approved_benefit.BackColor = Color.White;
            noncash_quantity.BackColor = Color.White;
            noncash_price.BackColor = Color.White;
        }

        private bool validateRemunerationDetails()
        {
            setRenumerationToWhite();
            bool state = false;
            //Important details
            if(remun_salary_no.Text == "" || !Validator.money(remun_salary_no.Text))
            {
                remun_salary_no.BackColor = Color.RosyBrown;
                state = false;
            }

            if(remun_salary_grade.Text == "" || !Validator.text(remun_salary_grade.Text))
            {
                remun_salary_grade.BackColor = Color.RosyBrown;
                state = false;
            }

            if(remun_basic_salary.Text == "" || !Validator.money(remun_basic_salary.Text))
            {
                remun_basic_salary.BackColor = Color.RosyBrown;
                state = false;
            }

            if(remun_present_salary.Text == "" || !Validator.money(remun_present_salary.Text))
            {
                remun_present_salary.BackColor = Color.RosyBrown;
                state = false;
            }

            //Additional requirements
            if(remun_increased_by.Text != "" && !Validator.money(remun_increased_by.Text))
            {
                remun_increased_by.BackColor = Color.RosyBrown;
                state = false;
            }

            if(remun_house_allowance.Text != "" && !Validator.money(remun_house_allowance.Text))
            {
                remun_house_allowance.BackColor = Color.RosyBrown;
                state = false;
            }

            if(remun_transport_allowance.Text != "" && !Validator.money(remun_transport_allowance.Text))
            {
                remun_transport_allowance.BackColor = Color.RosyBrown;
                state = false;
            }

            if (remun_telephone_allowance.Text != "" && !Validator.money(remun_telephone_allowance.Text))
            {
                remun_telephone_allowance.BackColor = Color.RosyBrown;
                state = false;
            }

            if(remun_fuel_allowance.Text != "" && !Validator.money(remun_fuel_allowance.Text))
            {
                remun_fuel_allowance.BackColor = Color.RosyBrown;
                state = false;
            }

            if(remun_other_allowances.Text != "" && !Validator.money(remun_other_allowances.Text))
            {
                remun_other_allowances.BackColor = Color.RosyBrown;
                state = false;
            }

            if(!Validator.dateDiff(DateTime.Today, remun_salary_increased_date.Value))
            {
                erp_remun_salary_increased_date.SetError(remun_salary_increased_date, "Invalid date");
                state = false;
            }
            return state;
        }

        private bool validateCashBenefitDetails()
        {
            setCashBenefitToWhite();
            bool state = false;
            if(cash_approved_benefit.Text == "" || !Validator.text(cash_approved_benefit.Text))
            {
                cash_approved_benefit.BackColor = Color.RosyBrown;
                state = false;
            }

            if(cash_issued_price.Text == "" || !Validator.money(cash_issued_price.Text))
            {
                cash_issued_price.BackColor = Color.RosyBrown;
                state = false;
            }

            if(!Validator.dateDiff(DateTime.Today, cash_issued_date.Value))
            {
                erp_cash_issued_date.SetError(cash_issued_date, "Invalid date");
                state = false;
            }
            return state;
        }

        private bool validateNonCashBenefitDetails()
        {
            bool state = false;
            if(noncash_approved_benefit.Text == "" || !Validator.text(noncash_approved_benefit.Text))
            {
                noncash_approved_benefit.BackColor = Color.RosyBrown;
                state = false;
            }

            if(noncash_quantity.Text == "" || !Validator.number(noncash_quantity.Text))
            {
                noncash_quantity.BackColor = Color.RosyBrown;
                state = false;
            }

            if(noncash_price.Text == "" || !Validator.money(noncash_price.Text))
            {
                noncash_price.BackColor = Color.RosyBrown;
                state = false;
            }

            if(!Validator.dateDiff(DateTime.Today, noncash_issued_date.Value))
            {
                erp_noncash_issued_date.SetError(noncash_issued_date, "Invalid date");
                state = false;
            }
            return state;
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
            
            Form form1 = new frmPassportDetails();
            this.Hide();
            form1.Show();

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

        private void btnCheckRemunerationDetails_Click(object sender, EventArgs e)
        {
            validateRemunerationDetails();
        }

        private void btnCheckCashBenefitDetails_Click(object sender, EventArgs e)
        {
            validateCashBenefitDetails();
        }

        private void btnCheckNonCashBenefitDetails_Click(object sender, EventArgs e)
        {

        }

        private void cash_approved_benefit_TextChanged(object sender, EventArgs e)
        {
            cash_approved_benefit.BackColor = Color.White;
        }

        private void cash_issued_price_TextChanged(object sender, EventArgs e)
        {
            cash_issued_price.BackColor = Color.White;
        }

        private void remun_salary_increased_date_ValueChanged(object sender, EventArgs e)
        {
            erp_remun_salary_increased_date.Dispose();
        }

        private void cash_issued_date_ValueChanged(object sender, EventArgs e)
        {
            erp_cash_issued_date.Dispose();
        }

        private void noncash_issued_date_ValueChanged(object sender, EventArgs e)
        {
            erp_noncash_issued_date.Dispose();
        }
    }
}
