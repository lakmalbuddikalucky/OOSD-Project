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

        private bool validateBankDetails()
        {
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

        }
    }
}
