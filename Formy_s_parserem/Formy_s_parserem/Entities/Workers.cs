using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formy_s_parserem.Entities
{
    public class Workers
    {
        [DisplayName("Full Name")]
        public string Name { get; set; }
        [DisplayName("Age")]
        public int Age { get; set; }

        [DisplayName("Specialzation")]
        public string Specialization { get; set; }

        [DisplayName("Date of birth")]
        public DateTime BornDate { get; set; }

        [DisplayName("Gender")]
        public bool Gender {  get; set; }
    }
}
