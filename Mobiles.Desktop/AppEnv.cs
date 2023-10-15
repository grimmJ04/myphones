using Microsoft.Data.Sqlite;
using Mobiles.Core.Utils;
using System.Configuration;
using System.Diagnostics;

namespace Mobiles.Desktop
{
    internal class AppEnv : IDisposable
    {
        private SqliteConnection? _keepAliveConnection;

        public static string GetConnectionName() => ConfigurationManager.AppSettings["Connection"]
                ?? throw new KeyNotFoundException($"Application setting 'Connection' not found.");

        public static string GetConnectionString(string? connection = null) => ConfigurationManager.ConnectionStrings[connection ?? GetConnectionName()].ConnectionString
                ?? throw new KeyNotFoundException($"Connection string '{connection}' not found.");

        public void Init()
        {
            InitDb();
        }

        public void Dispose()
        {
            _keepAliveConnection?.Dispose();
        }

        private void InitMemDb(string appConnectionConfig)
        {
            string connectionStringConfig = GetConnectionString(appConnectionConfig);
            connectionStringConfig = PathUtils.ResolveVirtual(connectionStringConfig);
            string connectionString = $"Data Source={connectionStringConfig};";
            _keepAliveConnection = new(connectionString);
            _keepAliveConnection.Open();
        }

        private void InitDiskDb(string appConnectionConfig)
        {
            string connectionStringConfig = GetConnectionString(appConnectionConfig);
            connectionStringConfig = PathUtils.ResolveVirtual(connectionStringConfig);
            string? dirname = Directory.GetParent(connectionStringConfig)?.FullName;
            if (dirname != null && !Directory.Exists(dirname))
            {
                Directory.CreateDirectory(dirname);
            }
        }

        private void InitDb()
        {
            string appConnectionConfig = GetConnectionName();
            switch (appConnectionConfig)
            {
                case "PhonesMemDbContext":
                    InitMemDb(appConnectionConfig);
                    break;
                case "PhonesDiskDbContext":
                    InitDiskDb(appConnectionConfig);
                    break;
            }
            using var context = Program.GetDbContext();
            bool created = context.Database.EnsureCreated();
            Debug.WriteLine(created ? "Initialized database." : "Database already created.");
        }
    }
}
