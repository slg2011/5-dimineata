using System;
using System.Collections.Generic;

namespace Pro_ATM.Models
{
    public partial class Student
    {
        public Student()
        {
            this.Notes = new List<Note>();
        }

        public int id_stud { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Initiala_Parinte { get; set; }
        public string CNP { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Tip { get; set; }
        public Nullable<double> Taxa { get; set; }
        public string nume_grupa { get; set; }
        public int Credite { get; set; }
        public string email { get; set; }
        public virtual LogInn LogInn { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
