using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main mainForm = new Main();
            mainForm.WindowState = FormWindowState.Maximized; 
            mainForm.FormBorderStyle = FormBorderStyle.Sizable; 
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.MaximizeBox = false;
            Application.Run(mainForm);



            // Application.Run(new formLogin());
        }
    }
}
