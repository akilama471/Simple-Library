using SarasaviLibrary.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarasaviLibrary
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
            
            // Initialize Database
            try
            {
                Data.DatabaseInitializer.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database initialization failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new MainForm());
        }
    }
}
