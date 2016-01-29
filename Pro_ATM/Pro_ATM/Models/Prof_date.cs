using System;
using System.Collections.Generic;

namespace Pro_ATM.Models
{
    public partial class Prof_date
    {
        public int id_prof { get; set; }
        public int id_grupa { get; set; }
        public int id_disc { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual Grupe Grupe { get; set; }
        public virtual Profesor Profesor { get; set; }
    }
}
