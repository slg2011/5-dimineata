using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Administrator
    {
        public int id_admin { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public virtual LogInn LogInn { get; set; }
    }
}
