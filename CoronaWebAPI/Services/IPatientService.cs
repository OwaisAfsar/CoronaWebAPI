using CoronaWebAPI.Model;

namespace CoronaWebAPI.Services
{
    public interface IPatientService
    {
        List<Patient> GetAllPatients();

        List<Patient> GetPatientsByState(string state);

        List<Patient> GetPatientsByDate(string date);

        public Patient AddPatient(Patient patientData);

        public Patient UpdatePatient(int id, Patient patientData);

        public int DeletePatient(int id);
    }
}
