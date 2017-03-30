using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class Scanner
    {
        public Scanner()
        {
            this.Scanner_Cons = new List<Scanner_Cons>();
        }

        public int id_scanner { get; set; }
        public string decripScanner { get; set; }
        public virtual ICollection<Scanner_Cons> Scanner_Cons { get; set; }
    }
}
