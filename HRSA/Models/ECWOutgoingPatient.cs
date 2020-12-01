namespace HRSA.Models
{
    public class ECWOutgoingPatient
    {
        public ECWOutgoingPatient(ECWIncomingPatient from, ECWGenderPatient src)
        {
            from.Clean();

            this.AccountNumber = from.AccountNumber;
            this.PatientName = from.PatientName;
            this.Address = from.AddressLine1;
            this.City = from.City;
            this.State = from.State;
            this.ZipCode = from.ZipCode;
            this.DateOfBirth = src.DateOfBirth;
            this.Gender = src.Gender;

            string[] names = from.PatientName.Split(',');
            LastName = names[0].Trim();
            FirstName = names[1].Trim();
        }

        public string AccountNumber { get; set; }
        public string PatientName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
