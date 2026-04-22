using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_MAT
{
    [Table("Reservation")]
    public class Reservation
    {
        [Column("Id")] 
         public int Id { get; set; }



    }
}
