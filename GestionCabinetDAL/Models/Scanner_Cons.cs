using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Scanner_Cons
    {
        public int id_Scan_Cons { get; set; }
        public int numCons { get; set; }
        public int id_scanner { get; set; }
        public virtual Consultation Consultation { get; set; }
        public virtual Scanner Scanner { get; set; }
    }
}
