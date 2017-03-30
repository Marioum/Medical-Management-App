using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Pat_Antecedent_Med
    {
        public int id_Pat_AM { get; set; }
        public int numCin { get; set; }
        public int id_Ant_Med { get; set; }
        public virtual AntecedentMedical AntecedentMedical { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
