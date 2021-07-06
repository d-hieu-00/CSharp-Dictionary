using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dictionary.Forms;

namespace Dictionary
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
            Console.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
            if (Resources.Resources.InitRes())
            {
                Application.Run(Resources.Resources.main.mainForm);
            }
            else
            {
                MessageBox.Show("Lỗi mở tệp cấu hình", "Lỗi mở ứng dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
