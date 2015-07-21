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
        public frmEmployeeFinanceDetails()
        {
            InitializeComponent();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmEmployeeSpecialDetails form8 = new frmEmployeeSpecialDetails();
            form8.Show();
            this.Dispose();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmEmployeeRemunerationAndBenefits form7 = new frmEmployeeRemunerationAndBenefits();
            form7.Show();
            this.Dispose();
        }


     



       

 
    }
}
