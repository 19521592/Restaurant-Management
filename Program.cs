using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.GUI.OrderFood;
using Restaurant_Management.GUI.Report;
using Restaurant_Management.GUI.Revenue;

namespace Restaurant_Management
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
            if (DAL.Provider.Ins.TestConStr() == false)
            {
                MessageBox.Show("Error Connection String. Please contact the developers to help!");
            }
            else
                Application.Run(new formLogin());
        }
    }
}
