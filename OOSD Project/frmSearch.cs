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
        private static frmSearch form;

        public frmSearch()
        {
            //search
            InitializeComponent();
        }

        public static frmSearch getForm()
        {
            if (form == null)
            {
                form = new frmSearch();
            }
            return form;
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            //frmEmployeeFinanceDetails form9 = new frmEmployeeFinanceDetails();
            //form9.Show();
            //this.Dispose();
            frmMain.getForm().Show();
            this.Hide();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmMain form10 = new frmMain();
            form10.Show();
            this.Dispose();
        }
    }
}
