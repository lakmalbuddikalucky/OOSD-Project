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
    public partial class frmTraining : Form
    {
        private static frmTraining form;

        public frmTraining()
        {
            InitializeComponent();
        }

        public static frmTraining getForm()
        {
            if (form == null)
            {
                form = new frmTraining();
            }
            return form;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
