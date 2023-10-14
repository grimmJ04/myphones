using Microsoft.EntityFrameworkCore;
using Mobiles.Core.Data;
using Mobiles.Core.Utils;
using Mobiles.Desktop.Views;

namespace Mobiles.Desktop
{
    internal static class Program
    {
        internal static void TryInvoke(Control sender, Action action)
        {
            if (sender.InvokeRequired)
            {
                sender.Invoke(action);
            }
            else
            {
                action();
            }
        }

        internal static PhonesDbContext GetDbContext()
        {
            string appConnectionConfig = AppEnv.GetConnectionName();
            string connectionStringConfig = AppEnv.GetConnectionString(appConnectionConfig);
            connectionStringConfig = PathUtils.ResolveVirtual(connectionStringConfig);
            string connectionString = $"Data Source={connectionStringConfig};";
            var optionsBuilder = new DbContextOptionsBuilder<PhonesDbContext>().UseSqlite(connectionString);
            return new PhonesDbContext(optionsBuilder.Options);
        }

        [STAThread]
        static void Main()
        {
            using AppEnv env = new();
            env.Init();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}