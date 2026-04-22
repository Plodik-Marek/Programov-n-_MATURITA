using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{

    [Table("Reservation")]
    public class Reservation
    {

        [Key]
        [Column("Id")]
              public int Id { get; set; }
 
            [DisplayName("Jméno hosta")]
            public string GuestName { get; set; }
            [DisplayName("Počet hostů")]
            public int GuestsCount { get; set; }

            [DisplayName("Cena")]
            public decimal TotalPrice { get; set; }

            [DisplayName("Datum Rezervace")]
            public DateTime ReservationDate { get; set; }

            [DisplayName("Je potvrzená?")]
            public bool IsConfirmed { get; set; }

           
        
    }
}

