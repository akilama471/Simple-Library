using System;
using System.Threading.Tasks;

namespace SarasaviLibrary.Services
{
    public static class AppInitializerServices
    {
        public static async Task InitializeAsync(Action<int, string> reportProgress)
        {
            reportProgress(10, "Connecting to Database...");
            await CheckConnectionAsync();
            await Task.Delay(800);

            reportProgress(50, "Initializing database...");
            await InitDBAsync();
            await Task.Delay(800);

            reportProgress(70, "Initializing UI...");
            await Task.Delay(800);

            reportProgress(100, "Startup complete...");
            await Task.Delay(500);
        }

        private static async Task CheckConnectionAsync()
        {
            await Task.Run(() =>
            {
                Data.DatabaseHelper.CheckDBConnection();
            });
        }

        private static async Task InitDBAsync()
        {
            await Task.Run(() =>
            {
                Data.DatabaseInitializerService.Initialize();
            });
        }
    }
}
