using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRGA
{
    public class Eater
    {


        [DisplayName("Full Name")]
        public string Name { get; set; }

        [DisplayName("Hamburger Type")]
        public string HamburgerType { get; set; }

        [DisplayName("Eaten")]
        public int Eaten { get; set; }

        [DisplayName("Last Hamburger Eaten")]
        public DateTime LastHamburgerEaten { get; set; }

    }
}
