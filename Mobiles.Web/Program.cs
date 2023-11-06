using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Mobiles.Core.Data;
using Mobiles.Core.Utils;
using System.Diagnostics;

SqliteConnection? keepAliveConnection = null;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PhonesDbContext>((options) =>
{
    string connectionStringConfig = GetConnectionString(GetConnectionName());
    connectionStringConfig = PathUtils.ResolveVirtual(connectionStringConfig);
    string connectionString = $"Data Source={connectionStringConfig};";
    options.UseSqlite(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

try
{
    InitDb();
    app.Run();
}
finally
{
    keepAliveConnection?.Dispose();
}

string GetConnectionName() => builder?.Configuration.GetSection("AppSettings").GetValue<string>("Connection")
        ?? throw new KeyNotFoundException("Application setting 'Connection' not found.");

string GetConnectionString(string? connection = null) => builder?.Configuration.GetConnectionString(GetConnectionName())
        ?? throw new KeyNotFoundException($"Connection string '{connection}' not found.");

void InitMemDb(string appConnectionConfig)
{
    string connectionStringConfig = GetConnectionString(appConnectionConfig);
    connectionStringConfig = PathUtils.ResolveVirtual(connectionStringConfig);
    string connectionString = $"Data Source={connectionStringConfig};";
    keepAliveConnection = new(connectionString);
    keepAliveConnection.Open();
}

void InitDiskDb(string appConnectionConfig)
{
    string connectionStringConfig = GetConnectionString(appConnectionConfig);
    connectionStringConfig = PathUtils.ResolveVirtual(connectionStringConfig);
    string? dirname = Directory.GetParent(connectionStringConfig)?.FullName;
    if (dirname != null && !Directory.Exists(dirname))
    {
        Directory.CreateDirectory(dirname);
    }
}

void InitDb()
{
    string appConnectionConfig = GetConnectionName();
    switch (appConnectionConfig)
    {
        case "PhonesMemDb":
            InitMemDb(appConnectionConfig);
            break;
        case "PhonesDiskDb":
            InitDiskDb(appConnectionConfig);
            break;
    }
    Debug.Assert(app != null);
    using var serviceScope = app.Services.CreateScope();
    var services = serviceScope.ServiceProvider;
    var context = services.GetRequiredService<PhonesDbContext>();
    bool created = context.Database.EnsureCreated();
    Debug.WriteLine(created ? "Initialized database." : "Using existing database.");
}
