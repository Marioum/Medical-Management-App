using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Patient
    {
        public Patient()
        {
            this.Consultations = new List<Consultation>();
            this.Pat_Antecedent_Med = new List<Pat_Antecedent_Med>();
            this.Patient_Allergie = new List<Patient_Allergie>();
            this.RendezVous = new List<RendezVou>();
        }

        public int numCin { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public System.DateTime dateNaissance { get; set; }
        public string sexe { get; set; }
        public string etatCivil { get; set; }
        public string profession { get; set; }
        public decimal poids { get; set; }
        public int nbreEnfant { get; set; }
        public decimal taille { get; set; }
        public int numCNSS_CNRPS { get; set; }
        public virtual ICollection<Consultation> Consultations { get; set; }
        public virtual ICollection<Pat_Antecedent_Med> Pat_Antecedent_Med { get; set; }
        public virtual ICollection<Patient_Allergie> Patient_Allergie { get; set; }
        public virtual ICollection<RendezVou> RendezVous { get; set; }
    }
}
