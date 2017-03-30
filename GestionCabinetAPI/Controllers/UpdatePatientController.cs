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
    public class UpdatePatientController : ApiController
    {
        [HttpGet]
        [Route("updatepatients")]
        public void updatepatients(string patient)
        {
            Patient patients = JsonConvert.DeserializeObject<Patient>(patient);
            PatientBL.updatepatients(patients);
        }
    }
}
