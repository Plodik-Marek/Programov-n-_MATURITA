using Microsoft.EntityFrameworkCore;

namespace Procviceni_CRUD.DbContext
{
    public class ReservationDbContext : DbContext
    {

        DbSet<Reservation> Reservations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string
            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=4c2_plodikmarek_db2;uid=plodikmarek;password=123456");
        }
    }
}
