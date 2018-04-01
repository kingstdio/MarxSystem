using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marx
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form loginForm = new F_login();
            DialogResult dialogResult = loginForm.ShowDialog();
            if (DialogResult.Yes == dialogResult)
            {
                Application.Run(new F_main());
            }
        }
    }
}
