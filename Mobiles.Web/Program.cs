using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Mobiles.Core.Data;
using Mobiles.Models;

SqliteConnection? keepAliveConnection = null;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PhonesDbContext>((options) =>
{
    string appConnectionConfig = builder.Configuration.GetSection("AppSettings").GetValue<string>("Connection")
        ?? throw new KeyNotFoundException($"Application setting 'Connection' not found.");
    string connectionStringConfig = builder.Configuration.GetConnectionString(appConnectionConfig)
        ?? throw new KeyNotFoundException($"Connection string '{appConnectionConfig}' not found.");
    string connectionString = $"Data Source={connectionStringConfig};";
    options.UseSqlite(connectionString);
    if (appConnectionConfig == "PhonesMemDbContext")
    {
        keepAliveConnection = new(connectionString);
        keepAliveConnection.Open();
    }
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
    using var serviceScope = app.Services.CreateScope();
    var services = serviceScope.ServiceProvider;
    PhonesDbContext db = services.GetRequiredService<PhonesDbContext>();

    bool created = db.Database.EnsureCreated();
    SmartphoneCpu[] cpus = new SmartphoneCpu[]
    {
        new SmartphoneCpu { Name = "best cpu in the whole world", ClockSpeedMHz = 1500, CoreCount = 6, GpuName = "pepper" },
        new SmartphoneCpu { Name = "salt", ClockSpeedMHz = 512, CoreCount = 2, GpuName = "chili" },
        new SmartphoneCpu { Name = "yessir", ClockSpeedMHz = 2338, CoreCount = 8, GpuName = "mint" },
    };
    db.SmartphoneCpus.AddRange(cpus);
    db.SaveChanges();

    app.Run();
}
finally
{
    keepAliveConnection?.Dispose();
}
