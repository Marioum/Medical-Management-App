using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class IRM_Cons
    {
        public int id_IRM_Cons { get; set; }
        public int numCons { get; set; }
        public int id_IRM { get; set; }
        public virtual Consultation Consultation { get; set; }
        public virtual IRM IRM { get; set; }
    }
}
