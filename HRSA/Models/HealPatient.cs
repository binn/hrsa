using CsvHelper.Configuration.Attributes;

namespace HRSA.Models
{
    public class HealPatient
    {
        [Index(1)]
        [Name("Last name")]
        public string LastName { get; set; }

        [Index(2)]
        [Name("First name")]
        public string FirstName { get; set; }

        [Index(3)]
        [Name("DOB")]
        public string DateOfBirth { get; set; }

        [Index(6)]
        [Name("Driver Lic/SS")]
        public string DL { get; set; }

        [Index(7)]
        [Name("Submit Date")]
        public string SubmittedDate { get; set; }

        [Index(10)]
        [Name("Address")]
        public string Address { get; set; }

        [Index(8)]
        [Name("Subscriber ID")]
        public string SubscriberId { get; set; }

        [Index(9)]
        [Name("Active Date")]
        public string ActiveDate { get; set; }

        [Index(0)]
        [Name("DOS")]
        public string DateOfService { get; set; }

        [Index(5)]
        [Name("Acc #")]
        public string AccountNumber { get; set; }

        [Index(4)]
        [Name("G")]
        public string Gender { get; set; }

        public static HealPatient From(string dos, ECWOutgoingPatient src)
        {
            string address = src.Address.Trim() + ", " + src.City.Trim() + ", " + src.State.Trim() + "-" + src.ZipCode.Trim();
            string[] names = src.PatientName.Split(',');

            var patient = new HealPatient()
            {
                Address = address,
                SubmittedDate = src.SubmitDate ?? string.Empty,
                SubscriberId = string.Empty,
                DateOfService = dos,
                AccountNumber = src.AccountNumber,
                ActiveDate = string.Empty,
                DateOfBirth = src.DateOfBirth.ToShortDateString(),
                DL = src.DL ?? string.Empty,
                Gender = src.Gender,
                LastName = names[0].Trim(),
                FirstName = names[1].Trim()
            };

            return patient;
        }
    }
}
