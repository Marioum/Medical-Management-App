using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class RendezVou
    {
        public int numRDV { get; set; }
        public System.DateTime date { get; set; }
        public System.TimeSpan heue { get; set; }
        public int numCin { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
