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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            //search
            InitializeComponent();
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
    }
}
