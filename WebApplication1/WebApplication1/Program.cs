using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;


namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<ReservationDbContext>(options =>
    options.UseMySql(
        "server=mysqlstudenti.litv.sssvt.cz;database=4c2_plodikmarek_db2;uid=plodikmarek;password=123456",
        ServerVersion.AutoDetect("server=mysqlstudenti.litv.sssvt.cz;database=4c2_plodikmarek_db2;uid=plodikmarek;password=123456")
    )
);

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

            app.Run();
        }
    }
}
