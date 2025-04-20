using DoctorOfficePro.Data;

namespace DoctorOfficePro.Repository.IRepository
{
    public interface IPatientRepository
    {
        // Create Patient
        public Patient Create(Patient obj);

        // Update Patient
        public Patient Update(Patient obj);

        // Delete Patient
        public bool Delete(int id);

        // Get Patient by id
        public Patient Get(int id);

        // Get All Patient
        public IEnumerable<Patient> GetAll();
    }
}
