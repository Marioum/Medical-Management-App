using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Medicament
    {
        public Medicament()
        {
            this.Med_Cons = new List<Med_Cons>();
        }

        public int id_Med { get; set; }
        public string nom { get; set; }
        public virtual ICollection<Med_Cons> Med_Cons { get; set; }
    }
}
