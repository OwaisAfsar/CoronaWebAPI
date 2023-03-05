namespace CoronaWebAPI.Model
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? State { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
