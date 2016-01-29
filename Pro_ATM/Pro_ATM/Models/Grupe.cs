using System;
using System.Collections.Generic;

namespace Pro_ATM.Models
{
    public partial class Grupe
    {
        public Grupe()
        {
            this.Prof_date = new List<Prof_date>();
        }

        public int id_grupa { get; set; }
        public string nume_grupa { get; set; }
        public int an { get; set; }
        public int nr_std { get; set; }
        public string indrumator { get; set; }
        public virtual ICollection<Prof_date> Prof_date { get; set; }
    }
}
