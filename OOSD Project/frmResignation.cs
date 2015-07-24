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
    public partial class frmResignation : Form
    {
        private static frmResignation form;

        public frmResignation()
        {
            InitializeComponent();
        }

        public static frmResignation getForm()
        {
            if (form == null)
            {
                form = new frmResignation();
            }
            return form;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
