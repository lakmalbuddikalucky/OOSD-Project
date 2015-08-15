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
    public partial class frmEmployeeFinanceDetails : Form
    {
        private static frmEmployeeFinanceDetails form;

        public frmEmployeeFinanceDetails()
        {
            InitializeComponent();

            if (!(Employee.emp_no == null))
            {
                employee_no.Text = Employee.emp_no;
                full_name.Text = Employee.employee_name;
            }
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
            bank_account_number.BackColor = Color.White;
            bank_account_type.BackColor = Color.White;
        }

        private void setInsuranceToWhite()
        {
            insurance_type.BackColor = Color.White;
            insurance_value.BackColor = Color.White;
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
            if(bank_account_number.Text == "" || !Validator.number(bank_account_number.Text))
            {
                bank_account_number.BackColor = Color.RosyBrown;
                state = false;
            }

            if(bank_account_type.Text == "")
            {
                bank_account_type.BackColor = Color.RosyBrown;
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
            bank_account_number.BackColor = Color.White;
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

        private void btnSave1_Click(object sender, EventArgs e)
        {
            FinanceBank fb = new FinanceBank();

            fb.bank_name = bank_name.Text;
            fb.branch_name = bank_branch_name.Text;
            fb.account_number = bank_account_number.Text;
            fb.account_type = bank_account_type.Text;
            fb.setBegin_date(bank_account_started_date.Value.Date);
            fb.setEnd_date(bank_account_closed_date.Value.Date);
            fb.Qual_year = bank_qualified_year.Text;
            fb.qualification = bank_qualification.Text;

            bool state = FinanceBankHandler.addFinanceBank(fb);

            if (state)
            {
                MessageBox.Show("Employee bank details added succesfully...!");

            }
            else
            {
                MessageBox.Show("Adding employee personal details failed...!");
            }

        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            FinanceInsurance fi = new FinanceInsurance();
            
            fi.type = insurance_type.Text;
            fi.value = Convert.ToDouble(insurance_value.Text);
            fi.setBegin_date(insurance_started_date.Value.Date);
            fi.setEnd_date(insurance_ended_date.Value.Date);
            fi.note = insurance_notes.Text;

            bool state = FinanceInsuranceHandler.addFinanceInsurance(fi);

            if (state)
            {
                MessageBox.Show("Employee insurance details added succesfully...!");

            }
            else
            {
                MessageBox.Show("Adding employee insurance details failed...!");
            }

        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            FinanceTax ft = new FinanceTax();

            ft.type = tax_type.Text;
            ft.number = tax_no.Text;
            ft.payment_method = tax_paying_method.Text;
            ft.status = tax_status.Text;
            ft.note = tax_notes.Text;

            bool state = FinanceTaxHandler.addFinanceTax(ft);

            if (state)
            {
                MessageBox.Show("Employee tax details added succesfully...!");

            }
            else
            {
                MessageBox.Show("Adding employee tax details failed...!");
            }
        }
    }
}
