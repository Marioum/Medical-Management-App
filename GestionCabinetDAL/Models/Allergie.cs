using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Allergie
    {
        public Allergie()
        {
            this.Patient_Allergie = new List<Patient_Allergie>();
        }

        public int id_All { get; set; }
        public string nomAllergie { get; set; }
        public virtual ICollection<Patient_Allergie> Patient_Allergie { get; set; }
    }
}
