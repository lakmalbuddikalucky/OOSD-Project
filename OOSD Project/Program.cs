﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSD_Project
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new frmLogin());
            Application.Run(new frmMain());

            //Application.Run(new frmNotifications());

            //Application.Run(new frmPassportDetails());
            //Application.Run(new frmEmployeeFinanceDetails());
            //Application.Run(new frmEmployeePersonalDetails());

            //Application.Run(new frmDisciplinaryDetails());
            //Application.Run(new frmSearch());

        }
    }
}
