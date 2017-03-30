using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class InterChirur_Cons
    {
        public int id_ICh_Cons { get; set; }
        public int numCons { get; set; }
        public int id_intChirurgie { get; set; }
        public virtual Consultation Consultation { get; set; }
        public virtual IntervChirugicale IntervChirugicale { get; set; }
    }
}
