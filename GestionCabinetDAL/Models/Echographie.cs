using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Echographie
    {
        public Echographie()
        {
            this.Echo_Cons = new List<Echo_Cons>();
        }

        public int id_echo { get; set; }
        public string descripEcho { get; set; }
        public virtual ICollection<Echo_Cons> Echo_Cons { get; set; }
    }
}
