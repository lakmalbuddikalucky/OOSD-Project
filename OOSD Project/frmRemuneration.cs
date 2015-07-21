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
        public frmEmployeeRemunerationAndBenefits()
        {
            InitializeComponent();
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
            frmPassportDetails form8 = new frmPassportDetails();
            form8.Show();
            this.Hide();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmEmployeeFinanceDetails form7 = new frmEmployeeFinanceDetails();
            form7.Show();
            this.Hide();
        }
    }
}
