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
    public class DeletePatientController : ApiController
    {
        [HttpGet]
        [Route("deletepatients")]
        public void deletepatients(string patien)
        {
            Patient patients = JsonConvert.DeserializeObject<Patient>(patien);
            PatientBL.deletepatients(patients);
        }
    }
}
