using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Med_Cons
    {
        public int id_Med_Cons { get; set; }
        public int duree_traitement { get; set; }
        public int numCons { get; set; }
        public int id_Med { get; set; }
        public virtual Consultation Consultation { get; set; }
        public virtual Medicament Medicament { get; set; }
    }
}
