using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Patient_Allergie
    {
        public int id_Pat_All { get; set; }
        public int numCin { get; set; }
        public int id_All { get; set; }
        public virtual Allergie Allergie { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
