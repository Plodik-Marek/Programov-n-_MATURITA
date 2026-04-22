using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreninkWinForm.Entites
{
    [Table("Clubs")]
    public class Club
    {
        public static readonly IReadOnlyList<string> Types = ["AC", "SK", "FC", "TJ"];

        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Type")]
        public string Type { get; set; }

        [Column("First_league")]
        public bool First_league { get; set; }

        public List<Result> Results { get; set; }
    }
}
