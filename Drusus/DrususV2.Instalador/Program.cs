using System;
using System.Windows.Forms;

namespace DrususV2.Instalador
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the installer application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormInstalador());
        }
    }
}
