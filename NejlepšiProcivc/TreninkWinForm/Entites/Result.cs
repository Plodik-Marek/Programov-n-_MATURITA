using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreninkWinForm.Entites
{
    [Table("Results")]
    public class Result
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Score")]
        public string Score { get; set; }

        [Column("Cards")]
        public int Cards { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }

        public List<Club> Clubs { get; set; }




    }
}
