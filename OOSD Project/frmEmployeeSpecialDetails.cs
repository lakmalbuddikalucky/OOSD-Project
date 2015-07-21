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
    public partial class frmEmployeeSpecialDetails : Form
    {
        public frmEmployeeSpecialDetails()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmEmployeeFinanceDetails form5 = new frmEmployeeFinanceDetails();
            form5.Show();
            this.Dispose();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmEmployeePersonalDetails form6 = new frmEmployeePersonalDetails();
            form6.Show();
            this.Dispose();
        }

    }
}
