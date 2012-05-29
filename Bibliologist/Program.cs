using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bibliologist
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Global.Formats = Global.LoadConfigValues(Properties.Settings.Default.Language, "format");
            Global.Genres = Global.LoadConfigValues(Properties.Settings.Default.Language, "genre");
            Global.Locations = Global.LoadConfigValues(Properties.Settings.Default.Language, "location");
            Global.Messages = Global.LoadConfigValues(Properties.Settings.Default.Language, "message");
            Global.Statuses = Global.LoadConfigValues(Properties.Settings.Default.Language, "status");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUI());
        }
    }
}
