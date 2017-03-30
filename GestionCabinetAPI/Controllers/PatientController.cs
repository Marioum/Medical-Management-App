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
    public class PatientController : ApiController
    {
        [HttpGet]
        [Route("getpatients")]
        public List<Patient> getpatients()
        {
            return PatientBL.getpatients();
        }
    }
}
