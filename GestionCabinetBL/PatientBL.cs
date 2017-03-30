using GestionCabinetDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCabinetBL
{
   public static class PatientBL
    {
        public static List<Patient> getpatients()
       {
           List<Patient> listpatient = new List<Patient>();
           using (var db = new GestionCabinetContext())
           {
               listpatient = db.Patients.ToList();
           }
            return listpatient;
        }

        public static void deletepatients(Patient patientss)
        {
          // var p = new Patient { numCin = cin };
           using (var db = new GestionCabinetContext())
           {
               db.Entry(patientss).State = EntityState.Deleted;
             //  db.Patients.Remove(patients);
               db.SaveChanges();
           }
            
        }

        public static void updatepatients(Patient patients)
        {
            using (var db = new GestionCabinetContext())
            {
                db.Entry(patients).State = EntityState.Modified;
                //  db.Patients.Remove(patients);
                db.SaveChanges();
            }
        }

        public static void addpatients(Patient newpatients)
        {
            using (var db = new GestionCabinetContext())
            {
                db.Patients.Add(newpatients);
                db.SaveChanges();
            }
        }
    }
}
