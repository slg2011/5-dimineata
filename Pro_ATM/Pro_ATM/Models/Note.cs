using System;
using System.Collections.Generic;

namespace Pro_ATM.Models
{
    public partial class Note
    {
        public int nota { get; set; }
        public int nr_credite { get; set; }
        public int id_disc { get; set; }
        public int id_stud { get; set; }
        public int id_prof { get; set; }
        public int forma { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual Student Student { get; set; }
    }
}
