using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procviceni_CRUD
{
    public class Reservation
    {
         

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

        public Reservation(string guestName, int guestsCount, decimal totalPrice, DateTime reservationDate, bool isConfirmed)
        {
            GuestName = guestName;
            GuestsCount = guestsCount;
            TotalPrice = totalPrice;
            ReservationDate = reservationDate;
            IsConfirmed = isConfirmed;
        }

    }
}
