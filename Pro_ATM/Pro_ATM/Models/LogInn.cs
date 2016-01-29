using System;
using System.Collections.Generic;

namespace Pro_ATM.Models
{
    public partial class LogInn
    {
        public int id { get; set; }
        public string username { get; set; }
        public string parola { get; set; }
        public int permis { get; set; }
        public virtual Administrator Administrator { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual Student Student { get; set; }
    }
}
