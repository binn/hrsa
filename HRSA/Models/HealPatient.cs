using CsvHelper.Configuration.Attributes;

namespace HRSA.Models
{
    public class HealPatient
    {
        [Name("Last name")]
        public string LastName { get; set; }

        [Name("First name")]
        public string FirstName { get; set; }

        [Name("DOB")]
        public string DateOfBirth { get; set; }

        [Name("Driver Lic/SS")]
        public string DL { get; set; }

        [Name("Submit Date")]
        public string SubmittedDate { get; set; }

        [Name("Address")]
        public string Address { get; set; }

        [Name("Subscriber ID")]
        public string SubscriberId { get; set; }

        [Name("Active Date")]
        public string ActiveDate { get; set; }

        [Name("DOS")]
        public string DateOfService { get; set; }

        [Name("Acc #")]
        public string AccountNumber { get; set; }

        [Name("G")]
        public string Gender { get; set; }
    }
}
