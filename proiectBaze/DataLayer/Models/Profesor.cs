using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Profesor
    {
        public Profesor()
        {
            this.Notes = new List<Note>();
            this.Prof_date = new List<Prof_date>();
        }

        public int id_prof { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Departament { get; set; }
        public string Statut { get; set; }
        public string email { get; set; }
        public string Tip { get; set; }
        public virtual LogInn LogInn { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Prof_date> Prof_date { get; set; }
    }
}
