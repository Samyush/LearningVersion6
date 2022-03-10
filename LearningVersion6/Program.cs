using LearningVersion6.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Year3DbContext>(options => {
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("AppAspConnection"),
        b => b.MigrationsAssembly(typeof(Year3DbContext).Assembly.FullName));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


// all app.Method() are middleware such that it runs or checks upon running of the application
app.UseHttpsRedirection();

//The default file runs the wwwroot index.html file 
app.UseDefaultFiles();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseAuthentication();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
