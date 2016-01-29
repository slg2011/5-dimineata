using System;
using System.Collections.Generic;

namespace Pro_ATM.Models
{
    public partial class Disciplina
    {
        public Disciplina()
        {
            this.Notes = new List<Note>();
            this.Prof_date = new List<Prof_date>();
        }

        public int id_disc { get; set; }
        public string Denumire { get; set; }
        public int Nr_credite { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Prof_date> Prof_date { get; set; }
    }
}
