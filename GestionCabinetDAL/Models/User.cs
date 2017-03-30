using System;
using System.Collections.Generic;

namespace GestionCabinetDAL.Models
{
    public partial class User
    {
        public int idUser { get; set; }
        public string login { get; set; }
        public string mdp { get; set; }
        public string role { get; set; }
    }
}
