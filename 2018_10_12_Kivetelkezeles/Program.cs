using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_10_12_Kivetelkezeles
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form_kivetelkezeles());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt:\n" + ex.ToString());
            }
        }
    }
}