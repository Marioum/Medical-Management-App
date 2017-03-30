using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Radio
    {
        public Radio()
        {
            this.Radio_Cons = new List<Radio_Cons>();
        }

        public int id_radio { get; set; }
        public string descripRadio { get; set; }
        public virtual ICollection<Radio_Cons> Radio_Cons { get; set; }
    }
}
