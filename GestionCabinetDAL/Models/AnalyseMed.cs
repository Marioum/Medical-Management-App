using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class AnalyseMed
    {
        public AnalyseMed()
        {
            this.AnalyseMed_Cons = new List<AnalyseMed_Cons>();
        }

        public int id_AnalyseMed { get; set; }
        public string descripAnalyseMed { get; set; }
        public virtual ICollection<AnalyseMed_Cons> AnalyseMed_Cons { get; set; }
    }
}
