using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Reeducation
    {
        public Reeducation()
        {
            this.Ree_Cons = new List<Ree_Cons>();
        }

        public int id_Ree { get; set; }
        public string descripReeducation { get; set; }
        public virtual ICollection<Ree_Cons> Ree_Cons { get; set; }
    }
}
