using SarasaviLibrary.Forms;
using SarasaviLibrary.Services;
using System;
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

            RunApplicationAsync().GetAwaiter().GetResult();
        }

        private static async Task RunApplicationAsync()
        {
            SplashForm splash = new SplashForm();
            splash.Show();
            Application.DoEvents();

            try
            {
                await AppInitializerServices.InitializeAsync((value, message) =>
                {
                    splash.UpdateProgress(value, message);
                });

                splash.Hide();
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                splash.Hide();

                MessageBox.Show(
                    $"Startup Failed:\n\n{ex.Message}",
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Application.Exit();
            }
        }

    }
}
