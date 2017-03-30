using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Echo_Cons
    {
        public int id_echo_cons { get; set; }
        public int id_echo { get; set; }
        public int numCons { get; set; }
        public virtual Consultation Consultation { get; set; }
        public virtual Echographie Echographie { get; set; }
    }
}
