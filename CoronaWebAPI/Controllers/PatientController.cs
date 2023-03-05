using CoronaWebAPI.Model;
using CoronaWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoronaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private ILogger _logger;
        private IPatientService _service;

        public PatientController(ILogger<PatientController> logger, IPatientService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("/api/patients")]
        public ActionResult<IEnumerable<Patient>> GetPatients()
        {
            return _service.GetAllPatients();
        }

        [HttpGet("/api/patients/state/{state}")]
        public ActionResult<List<Patient>> GetPatientsByState(string state)
        {
            return _service.GetPatientsByState(state);
        }

        [HttpGet("/api/patients/date/{date}")]
        public ActionResult<List<Patient>> GetPatientsByDate(string date)
        {
            return _service.GetPatientsByDate(date);
        }

        [HttpPost("/api/patients")]
        public ActionResult<Patient> AddPatient(Patient patientData)
        {
            _service.AddPatient(patientData);
            return patientData;
        }

        [HttpPut("/api/products/{id}")]
        public ActionResult<Patient> UpdatePatient(int id, Patient patientData)
        {
            _service.UpdatePatient(id, patientData);
            return patientData;
        }

        [HttpDelete("/api/products/{id}")]
        public ActionResult<int> DeletePatient(int id)
        {
            _service.DeletePatient(id);
            return id;
        }

    }
}
