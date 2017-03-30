using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Consultation
    {
        public Consultation()
        {
            this.AnalyseMed_Cons = new List<AnalyseMed_Cons>();
            this.Echo_Cons = new List<Echo_Cons>();
            this.InterChirur_Cons = new List<InterChirur_Cons>();
            this.IRM_Cons = new List<IRM_Cons>();
            this.Med_Cons = new List<Med_Cons>();
            this.Radio_Cons = new List<Radio_Cons>();
            this.Ree_Cons = new List<Ree_Cons>();
            this.Scanner_Cons = new List<Scanner_Cons>();
        }

        public int numCons { get; set; }
        public System.DateTime date { get; set; }
        public string description { get; set; }
        public int numCin { get; set; }
        public virtual ICollection<AnalyseMed_Cons> AnalyseMed_Cons { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<Echo_Cons> Echo_Cons { get; set; }
        public virtual ICollection<InterChirur_Cons> InterChirur_Cons { get; set; }
        public virtual ICollection<IRM_Cons> IRM_Cons { get; set; }
        public virtual ICollection<Med_Cons> Med_Cons { get; set; }
        public virtual ICollection<Radio_Cons> Radio_Cons { get; set; }
        public virtual ICollection<Ree_Cons> Ree_Cons { get; set; }
        public virtual ICollection<Scanner_Cons> Scanner_Cons { get; set; }
    }
}
