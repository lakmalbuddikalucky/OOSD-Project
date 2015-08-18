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
    public partial class frmTransport : Form
    {
        private static frmTransport form;
        public frmTransport()
        {
            InitializeComponent();
        }

        public static frmTransport getForm()
        {
            if (form == null)
            {
                form = new frmTransport();
            }
            return form;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            frmEmployeeFinanceDetails form9 = new frmEmployeeFinanceDetails();
            form9.Show();
            this.Dispose();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmMain form10 = new frmMain();
            form10.Show();
            this.Dispose();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
