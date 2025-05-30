using ClinicLab.Application.Models;
using ClinicLab.DataAccess;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace ClinicLab.Application.BusinessLogic
{
    public class PatientService
    {
        private readonly ClinicLabDbContext _db;

        public PatientService(ClinicLabDbContext db)
        {
            _db = db; 
        }

        public List<Patient> GetAllPatients() => _db.Patients.ToList();

        public List<Patient> SearchPatients(string searchTerm) =>
            _db.Patients
               .Where(p => p.FirstName.Contains(searchTerm) ||
                           p.LastName.Contains(searchTerm) ||
                           p.PhoneNumber.Contains(searchTerm))
               .ToList();

        public void AddPatient(Patient patient)
        {
            _db.Patients.Add(patient);
            _db.SaveChanges();
        }

        public void UpdatePatient(Patient updatedPatient)
        {
            var existingPatient = _db.Patients.Find(updatedPatient.Id);

            if (existingPatient == null) return;

            _db.Entry(existingPatient).CurrentValues.SetValues(updatedPatient);
            _db.SaveChanges();
        }


        public void DeletePatient(int id)
        {
            var patient = _db.Patients.Find(id);
            if (patient != null)
            {
                _db.Patients.Remove(patient);
                _db.SaveChanges();
            }
        }
    }
}