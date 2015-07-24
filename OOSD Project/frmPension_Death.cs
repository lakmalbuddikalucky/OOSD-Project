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
    public partial class frmPension_Death : Form
    {
        private static frmPension_Death form;

        public frmPension_Death()
        {
            InitializeComponent();
        }

        public static frmPension_Death getForm()
        {
            if (form == null)
            {
                form = new frmPension_Death();
            }
            return form;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
