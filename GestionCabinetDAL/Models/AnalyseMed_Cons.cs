using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class AnalyseMed_Cons
    {
        public int id_AnMed_Cons { get; set; }
        public int id_AnalyseMed { get; set; }
        public int numCons { get; set; }
        public virtual AnalyseMed AnalyseMed { get; set; }
        public virtual Consultation Consultation { get; set; }
    }
}
