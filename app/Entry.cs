using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            FontManager fm = FontManager.Instance;
            Console.WriteLine(Security.HashString("12345678!" + "9NOV6F3hYrOS0HeanJMuDA=="));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}