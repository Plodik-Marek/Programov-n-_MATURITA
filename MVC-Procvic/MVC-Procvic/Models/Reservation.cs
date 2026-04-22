using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Procvic.Models
{
    [Table("Reservation")]
    public class Reservation
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        public string? GuestName { get; set; }
        
        public int GuestsCount { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime ReservationDate { get; set; }

        public bool IsConfirmed { get; set; }





    }
}
