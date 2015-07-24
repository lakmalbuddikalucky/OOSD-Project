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


     



       

 
    }
}
