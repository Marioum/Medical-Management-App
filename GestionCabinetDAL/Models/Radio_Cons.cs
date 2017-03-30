using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Radio_Cons
    {
        public int id_Radio_Cons { get; set; }
        public int id_radio { get; set; }
        public int numCons { get; set; }
        public virtual Consultation Consultation { get; set; }
        public virtual Radio Radio { get; set; }
    }
}
