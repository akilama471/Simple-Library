using SarasaviLibrary.Forms;
using SarasaviLibrary.Services;
using System;
using System.Threading; // Added for Thread.Sleep
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarasaviLibrary
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashForm splash = new SplashForm();
            splash.Show();
            splash.Refresh();

            // 1. Initialize Database during the delay
            try
            {
                // We run this once to ensure schema is ready
                Data.DatabaseInitializerService.Initialize();
            }
            catch (Exception ex)
            {
                splash.Hide();
                MessageBox.Show($"Database Initialization Failed: {ex.Message}\n\nPlease check if SQL Server LocalDB is running.", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3 second delay as requested
            DateTime endTime = DateTime.Now.AddSeconds(3);
            while (DateTime.Now < endTime)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
            }

            splash.Hide();

            // 2. Show Login Screen
            using (Login login = new Login())
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
            }

            // 3. Show Main Form
            Application.Run(new MainForm());
        }

    }
}
