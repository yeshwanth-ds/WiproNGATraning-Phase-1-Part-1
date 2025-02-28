using Microsoft.EntityFrameworkCore;
using WebApplication9.Models;
using WebApplication9.Services;
using NLog;
using NLog.Web;


var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();  
    logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);  
}).UseNLog(); 


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<UserDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("NewConnection")));


builder.Services.AddScoped<UserService>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
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
 
    var logger = LogManager.GetCurrentClassLogger(); 
    logger.Info("Application starting up...");

  
    app.Run();
}
catch (Exception ex)
{
    
    var logger = LogManager.GetCurrentClassLogger(); 
    logger.Fatal(ex, "Application start-up failed.");
}
finally
{
    
    LogManager.Shutdown();  
}
