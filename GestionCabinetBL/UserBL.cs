using GestionCabinetDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCabinetBL
{
    public static class UserBL
    {
        public static User authentifier(string log, string pw)
        {
            User userauthentif = new User();
            using (var db = new GestionCabinetContext())
            {
               userauthentif= db.Users.Where(x => x.login == log && x.mdp == pw).FirstOrDefault();
            }
            return userauthentif;
        }
    }
}
