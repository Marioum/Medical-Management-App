using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class AntecedentMedical
    {
        public AntecedentMedical()
        {
            this.Pat_Antecedent_Med = new List<Pat_Antecedent_Med>();
        }

        public int id_Ant_Med { get; set; }
        public string nom_Maladie { get; set; }
        public virtual ICollection<Pat_Antecedent_Med> Pat_Antecedent_Med { get; set; }
    }
}
