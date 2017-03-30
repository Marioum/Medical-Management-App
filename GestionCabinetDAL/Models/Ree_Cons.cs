using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Ree_Cons
    {
        public int id_ree_cons { get; set; }
        public int numCons { get; set; }
        public int id_Ree { get; set; }
        public virtual Consultation Consultation { get; set; }
        public virtual Reeducation Reeducation { get; set; }
    }
}
