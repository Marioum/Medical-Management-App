using GestionCabinetBL;
using GestionCabinetDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GestionCabinetAPI.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("authentifier")]
        public User authentifier(string log, string pw)
        {
            return UserBL.authentifier(log, pw);
        }
       
    }
}
