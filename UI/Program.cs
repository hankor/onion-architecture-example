using Core;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddCore()
    .AddInfrastructure(builder.Configuration.GetConnectionString("Database"))
    .AddRazorPages();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.Run();