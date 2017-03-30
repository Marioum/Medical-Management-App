using GestionCabinetBL;
using GestionCabinetDAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GestionCabinetAPI.Controllers
{
    public class AddPatientController : ApiController
    {
        [HttpGet]
        [Route("addpatients")]
        public void addpatients(string newpatient,  string datenaissance)
        {
            var datenaissances = Convert.ToDateTime(datenaissance);
            Patient newpatients = JsonConvert.DeserializeObject<Patient>(newpatient);
            newpatients.dateNaissance = datenaissances;
            PatientBL.addpatients(newpatients);
        }
    }
}
