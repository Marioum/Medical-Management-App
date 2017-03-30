using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class IntervChirugicale
    {
        public IntervChirugicale()
        {
            this.InterChirur_Cons = new List<InterChirur_Cons>();
        }

        public int id_intChirurgie { get; set; }
        public string descripChirurgie { get; set; }
        public virtual ICollection<InterChirur_Cons> InterChirur_Cons { get; set; }
    }
}
