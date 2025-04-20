using DoctorOfficePro.Data;
using DoctorOfficePro.Repository.IRepository;

namespace DoctorOfficePro.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext _db;
        public PatientRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Patient Create(Patient obj)
        {
            _db.Patients.Add(obj);
            _db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var obj = _db.Patients.FirstOrDefault(u => u.Id == id);
            if(obj != null)
            {
                _db.Patients.Remove(obj);
                return _db.SaveChanges() > 0;
            }
            return false;
        }

        public Patient Get(int id)
        {
            var obj = _db.Patients.FirstOrDefault(u => u.Id == id);
            if(obj == null)
            {
                return new Patient();
            }
            return obj;
        }

        public IEnumerable<Patient> GetAll()
        {
            return _db.Patients.ToList();
        }

        public Patient Update(Patient obj)
        {
            var objFromDb = _db.Patients.FirstOrDefault(u => u.Id == obj.Id);
            if(objFromDb is not null)
            {
                objFromDb.FirstName = obj.FirstName;
                objFromDb.LastName = obj.LastName;
                objFromDb.NationalCode = obj.NationalCode;
                objFromDb.DateOfBirth = obj.DateOfBirth;
                objFromDb.Gender = obj.Gender;
                objFromDb.PhoneNumber = obj.PhoneNumber;
                objFromDb.Email = obj.Email;
                objFromDb.Address = obj.Address;
                objFromDb.InsuranceType = obj.InsuranceType;
                objFromDb.InsuranceNumber = obj.InsuranceNumber;
                objFromDb.BloodType = obj.BloodType;
                objFromDb.Allergies = obj.Allergies;
                objFromDb.ChronicDiseases = obj.ChronicDiseases;
                objFromDb.CreatedAt = obj.CreatedAt;

                _db.Patients.Update(objFromDb);
                _db.SaveChanges();
                return objFromDb;
            }
            return obj;
        }
    }
}
