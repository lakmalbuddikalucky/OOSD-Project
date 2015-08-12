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
    public partial class frmDisciplinaryDetails : Form
    {
        private static frmDisciplinaryDetails form;

        public frmDisciplinaryDetails()
        {
            InitializeComponent();
        }

        public static frmDisciplinaryDetails getForm()
        {
            if (form == null)
            {
                form = new frmDisciplinaryDetails();
            }
            return form;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
