using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using System.Numerics;

namespace WinFormsDataCollector
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            System.Diagnostics.Debug.WriteLine("Hello World");

            ApplicationConfiguration.Initialize();
            Application.Run(new DataCollector());
        }
    }
}