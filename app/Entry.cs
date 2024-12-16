using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using app.db.records;
using app.globals;
using app.mvc.views;
using app.utils;

namespace app
{
    internal static class Entry
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine(RuntimeInformation.FrameworkDescription);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormManager formMgr = FormManager.Instance;

            UserRecord ur = SessionManager.Instance.LoadSession();
            if (ur == null) {
                formMgr.LoadForm(formMgr.Login);
            }
            else {
                formMgr.LoadForm(formMgr.Dashboard);
            }

            Application.Run(formMgr.MainForm);
        }
    }
}