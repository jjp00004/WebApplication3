using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;

public class Program
{
    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        var connString = builder.Configuration.GetConnectionString("DefaultConnection");
        // Add services to the container.
        builder.Services.AddDbContext<CarsDbContext>(options => options.UseSqlServer(connString));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

       

     

        app.Run();








    }





}