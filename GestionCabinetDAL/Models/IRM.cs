using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class IRM
    {
        public IRM()
        {
            this.IRM_Cons = new List<IRM_Cons>();
        }

        public int id_IRM { get; set; }
        public string descripIRM { get; set; }
        public virtual ICollection<IRM_Cons> IRM_Cons { get; set; }
    }
}
