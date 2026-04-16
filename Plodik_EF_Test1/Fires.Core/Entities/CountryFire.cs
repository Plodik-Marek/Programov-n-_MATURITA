using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fires.Core.Entities
{

    [Table("CountryFire") ]
    public class CountryFire
    {
        [Key]
        [Column("Id")]

        public int Id { get; set; }

        [Column("Location")]
        public string Location { get; set; }

        [Column("Severity")]

        public float  Severity {get; set;}

        [Column("Involvement")]

        public string Involvement {get; set;}

        [Column("Started at")]

        public DateTime StartedAt { get; set; }

        [Column("Ended at")]

        public DateTime EndedAt { get; set; }




    }
}
