using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagement
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
            Application.Run(new Login());
            ////Application.Run(new frmSalaryComponent());
            ////Application.Run(new frmUpdatePaidLeave());
            //Application.Run(new frmAttendance());
        }
    }
}
