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
    public partial class frmEmployeeFinanceDetails : Form
    {
        private static frmEmployeeFinanceDetails form;

        public frmEmployeeFinanceDetails()
        {
            InitializeComponent();
        }

        public static frmEmployeeFinanceDetails getForm()
        {
            if (form == null)
            {
                form = new frmEmployeeFinanceDetails();
            }
            return form;
        }

        private void setBankDetailsToWhite()
        {
            bank_name.BackColor = Color.White;
            bank_branch_name.BackColor = Color.White;
            bank_account_name.BackColor = Color.White;
            bank_account_type.BackColor = Color.White;
            erp_bank_account_started_date.Dispose();
        }

        private void setInsuranceToWhite()
        {
            insurance_type.BackColor = Color.White;
            insurance_value.BackColor = Color.White;
            erp_insuarance_started_date.Dispose();
        }

        private void setTaxDetailsToWhite()
        {
            tax_type.BackColor = Color.White;
            tax_no.BackColor = Color.White;
            tax_paying_method.BackColor = Color.White;
            tax_status.BackColor = Color.White;
        }

        private bool validateBankDetails()
        {
            setBankDetailsToWhite();
            bool state = false;
            if(bank_name.Text == "")
            {
                bank_name.BackColor = Color.RosyBrown;
                state = false;
            }
            if(bank_branch_name.Text == "" || !Validator.text(bank_branch_name.Text))
            {
                bank_branch_name.BackColor = Color.RosyBrown;
                state = false;
            }
            if(bank_account_name.Text == "" || !Validator.number(bank_account_name.Text))
            {
                bank_account_name.BackColor = Color.RosyBrown;
                state = false;
            }

            if(bank_account_type.Text == "")
            {
                bank_account_type.BackColor = Color.RosyBrown;
                state = false;
            }

            if(!Validator.dateDiff(DateTime.Today, bank_account_started_date.Value))
            {
                erp_bank_account_started_date.SetError(bank_account_started_date, "Invalid date");
                state = false;
            }

            if (!Validator.dateDiff(bank_account_closed_date.Value,bank_account_started_date.Value))
            {
                erp_bank_account_closed_date.SetError(bank_account_closed_date, "Invalid date");
                state = false;
            }

            return state;
        }

        private bool validateInsuranceDetails()
        {
            setInsuranceToWhite();
            bool state = true;
            if(insurance_type.Text == "")
            {
                insurance_type.BackColor = Color.RosyBrown;
                state = false;
            }

            if(insurance_value.Text == "" || !Validator.money(insurance_value.Text))
            {
                insurance_value.BackColor = Color.RosyBrown;
                state = false;
            }

            if(!Validator.dateDiff(DateTime.Today, insurance_started_date.Value))
            {
                erp_insuarance_started_date.SetError(insurance_started_date, "Invalid date");
                state = false;
            }

            if(!Validator.dateDiff(insurance_ended_date.Value, insurance_started_date.Value))
            {
                erp_insurance_ended_date.SetError(insurance_ended_date, "Invalid date");
                state = false;
            }


            return state;
        }

        private bool validateTaxDetails()
        {
            bool state = true;
            if(tax_type.Text == "")
            {
                tax_type.BackColor = Color.RosyBrown;
                state = false;
            }

            if(tax_no.Text == "")
            {
                tax_no.BackColor = Color.RosyBrown;
                state = false;
            }

            if(tax_paying_method.Text == "")
            {
                tax_paying_method.BackColor = Color.RosyBrown;
                state = false;
            }

            if(tax_status.Text == "")
            {
                tax_status.BackColor = Color.RosyBrown;
                state = false;
            }
            return state;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmEmployeeSpecialDetails.getForm().Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmEmployeeRemunerationAndBenefits.getForm().Show();
            this.Hide();
        }

        private void btnCheckBankDetails_Click(object sender, EventArgs e)
        {
            validateBankDetails();
        }

        private void bank_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            bank_name.BackColor = Color.White;

        }

        private void bank_branch_name_TextChanged(object sender, EventArgs e)
        {
            bank_branch_name.BackColor = Color.White;
        }

        private void bank_account_name_TextChanged(object sender, EventArgs e)
        {
            bank_account_name.BackColor = Color.White;
        }

        private void bank_account_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            bank_account_type.BackColor = Color.White;
        }

        private void btnCheckInsuaranceDetails_Click(object sender, EventArgs e)
        {
            validateInsuranceDetails();
        }

        private void insurance_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            insurance_type.BackColor = Color.White;
        }

        private void insurance_value_TextChanged(object sender, EventArgs e)
        {
            insurance_value.BackColor = Color.White;
        }

        private void btnCheckTaxDetails_Click(object sender, EventArgs e)
        {
            validateTaxDetails();
        }

        private void btnCheckBankDetails_Click_1(object sender, EventArgs e)
        {
            validateBankDetails();
        }

        private void bank_account_started_date_ValueChanged(object sender, EventArgs e)
        {
            erp_bank_account_started_date.Dispose();
            erp_bank_account_closed_date.Dispose();
        }

        private void bank_account_closed_date_ValueChanged(object sender, EventArgs e)
        {
            erp_bank_account_closed_date.Dispose();
        }

        private void insurance_started_date_ValueChanged(object sender, EventArgs e)
        {
            erp_insuarance_started_date.Dispose();
            erp_insurance_ended_date.Dispose();
        }

        private void insurance_ended_date_ValueChanged(object sender, EventArgs e)
        {
            erp_insurance_ended_date.Dispose();
        }

        private void tax_type_TextChanged(object sender, EventArgs e)
        {
            tax_type.BackColor = Color.White;
        }

        private void tax_no_TextChanged(object sender, EventArgs e)
        {
            tax_no.BackColor = Color.White;
        }

        private void tax_paying_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            tax_paying_method.BackColor = Color.White;
        }

        private void tax_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            tax_status.BackColor = Color.White;
        }
    }
}
