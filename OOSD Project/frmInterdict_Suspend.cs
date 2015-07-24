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
    public partial class frmInterdict_Suspend : Form
    {
        private static frmInterdict_Suspend form;

        public frmInterdict_Suspend()
        {
            InitializeComponent();
        }

        public static frmInterdict_Suspend getForm()
        {
            if (form == null)
            {
                form = new frmInterdict_Suspend();
            }
            return form;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }
    }
}
