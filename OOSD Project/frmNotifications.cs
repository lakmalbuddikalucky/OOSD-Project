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
    public partial class frmNotifications : Form
    {
        private static frmNotifications form;
        public frmNotifications()
        {
            InitializeComponent();
        }

        public static frmNotifications getForm()
        {
            if (form == null)
            {
                form = new frmNotifications();
            }
            return form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain formMain = new frmMain();
            formMain.Show();
            this.Hide();
        }
    }
}
