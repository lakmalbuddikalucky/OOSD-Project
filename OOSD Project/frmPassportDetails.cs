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
    public partial class frmPassportDetails : Form
    {
        private static frmPassportDetails form;

        public frmPassportDetails()
        {
            InitializeComponent();
        }

        public static frmPassportDetails getForm()
        {
            if (form == null)
            {
                form = new frmPassportDetails();
            }
            return form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmMain form10 = new frmMain();
            form10.Show();
            this.Dispose();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmEmployeeRemunerationAndBenefits.getForm().Show();
            this.Hide();
        }

    }
}
