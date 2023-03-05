using CoronaWebAPI.Model;
using System.Globalization;

namespace CoronaWebAPI.Services
{
    public class PatientService : IPatientService
    {
        List<Patient> _searchPatientsData;
        List<Patient> _patientsData = new List<Patient>
        {
            new Patient{PatientID=1, FirstName="John", LastName="Doe", State="Infected", TimeStamp= DateTime.ParseExact("2020-06-22 07:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) },
            new Patient{PatientID=2, FirstName="Sam", LastName="Wick", State="Deceased", TimeStamp=DateTime.ParseExact("2021-07-23 10:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) },
            new Patient{PatientID=3, FirstName="Berry", LastName="Allen", State="Infected", TimeStamp=DateTime.ParseExact("2020-06-22 07:30", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) },
            new Patient{PatientID=4, FirstName="Clark", LastName="Kent", State="Recoverd", TimeStamp=DateTime.ParseExact("2021-07-23 13:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) },
            new Patient{PatientID=5, FirstName="Bruce", LastName="Wayne", State="Recoverd", TimeStamp=DateTime.ParseExact("2021-09-25 17:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) },
        };

        public List<Patient> GetAllPatients()
        {
            return _patientsData;
        }

        public List<Patient> GetPatientsByState(string state)
        {
            _searchPatientsData = new List<Patient>();
            foreach (var patients in _patientsData)
            {
                if (patients.State == state)
                    _searchPatientsData.Add(patients);
            }
            return _searchPatientsData;
        }

        public List<Patient> GetPatientsByDate(string date)
        {
            _searchPatientsData = new List<Patient>();
            DateTime _date = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime startDate = new DateTime(_date.Year, _date.Month, _date.Day, 00, 00, 00);
            DateTime endDate = new DateTime(_date.Year, _date.Month, _date.Day, 23, 59, 59);
            
            foreach (var patients in _patientsData)
            {
                if (patients.TimeStamp >= startDate && patients.TimeStamp <= endDate)
                    _searchPatientsData.Add(patients);
            
            }
            return _searchPatientsData;
        }

        public Patient AddPatient(Patient patientData)
        {
            _patientsData.Add(patientData);
            return patientData;
        }

        public Patient UpdatePatient(int id, Patient patientData)
        {
            for (var index = _patientsData.Count - 1; index >= 0; index--)
            {
                if (_patientsData[index].PatientID == id)
                {
                    _patientsData[index] = patientData;
                }
            }
            return patientData;
        }

        public int DeletePatient(int id)
        {
            for (var index = _patientsData.Count - 1; index >= 0; index--)
            {
                if (_patientsData[index].PatientID == id)
                {
                    _patientsData.RemoveAt(index);
                }
            }

            return id;
        }

    }
}
