using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Database
{
    public class ReservationDbContext : DbContext
    {
        // 👇 TOTO JE POVINNÉ
        public ReservationDbContext(DbContextOptions<ReservationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Reservation> Reservations { get; set; }
    }
}