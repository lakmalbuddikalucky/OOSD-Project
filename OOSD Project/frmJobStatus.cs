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
    public partial class frmJobStatus : Form
    {
        private static frmJobStatus form;

        public frmJobStatus()
        {
            InitializeComponent();
        }

        public static frmJobStatus getForm()
        {
            if (form == null)
            {
                form = new frmJobStatus();
            }
            return form;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
