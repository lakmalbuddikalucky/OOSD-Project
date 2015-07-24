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
    }
}
