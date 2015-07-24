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
    public partial class frmRe_Appointment : Form
    {
        private static frmRe_Appointment form;

        public frmRe_Appointment()
        {
            InitializeComponent();
        }

        public static frmRe_Appointment getForm()
        {
            if (form == null)
            {
                form = new frmRe_Appointment();
            }
            return form;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
