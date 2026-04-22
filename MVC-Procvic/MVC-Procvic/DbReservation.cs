using Microsoft.EntityFrameworkCore;
using MVC_Procvic.Models;
using System.ComponentModel;

namespace MVC_Procvic
{
    public class DbReservation : DbContext
    {
        public DbSet<Reservation> Reservations {  get; set; }  

       



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz,database=4c2_plodikmarek_db2;uid=plodikmarek;password=123456");
        }
        
    }
}
