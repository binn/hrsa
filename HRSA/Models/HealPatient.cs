using CsvHelper.Configuration.Attributes;

namespace HRSA.Models
{
    public class HealPatient
    {
        [Index(2)]
        [Name("Last name")]
        public string LastName { get; set; }

        [Index(3)]
        [Name("First name")]
        public string FirstName { get; set; }

        [Index(4)]
        [Name("DOB")]
        public string DateOfBirth { get; set; }

        [Index(7)]
        [Name("Driver Lic/SS")]
        public string DL { get; set; }

        [Index(8)]
        [Name("Submit Date")]
        public string SubmittedDate { get; set; }

        [Index(6)]
        [Name("Address")]
        public string Address { get; set; }

        [Index(9)]
        [Name("Subscriber ID")]
        public string SubscriberId { get; set; }

        [Index(10)]
        [Name("Active Date")]
        public string ActiveDate { get; set; }

        [Index(0)]
        [Name("DOS")]
        public string DateOfService { get; set; }

        [Index(1)]
        [Name("Acc #")]
        public string AccountNumber { get; set; }

        [Index(5)]
        [Name("G")]
        public string Gender { get; set; }
    }
}
