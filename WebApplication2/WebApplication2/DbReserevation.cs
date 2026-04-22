using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2
{
    public class DbReserevation: DbContext
    {


        public DbSet<Reservation> Reservations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz,database=4c2_plodikmarek_db2;uid=plodikmarek;password=123456");
        }
    }
}
