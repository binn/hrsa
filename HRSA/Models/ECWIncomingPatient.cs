using CsvHelper.Configuration.Attributes;

namespace HRSA.Models
{
    public class ECWIncomingPatient
    {
        [Index(0)]
        [Name("Chart Number")]
        public string AccountNumber { get; set; }

        [Index(1)]
        [Name("Patient Name")]
        public string PatientName { get; set; }

        [Index(2)]
        [Name("Phone")]
        public string Phone { get; set; }

        [Index(3)]
        [Name("PCP")]
        public string PCP { get; set; }

        [Index(4)]
        [Name("Address1")]
        public string AddressLine1 { get; set; }

        [Index(5)]
        [Name("Address2")]
        public string AddressLine2 { get; set; }

        [Index(6)]
        [Name("City")]
        public string City { get; set; }

        [Index(7)]
        [Name("State")]
        public string State { get; set; }

        [Index(8)]
        [Name("Zip")]
        public string ZipCode { get; set; }

        public ECWIncomingPatient Clean()
        {
            this.ZipCode = this.ZipCode?.Trim()?.Split('-')[0];
            this.State = this.State?.ToUpper()?.Trim();
            this.AddressLine1 = this.AddressLine1?.Trim() + (string.IsNullOrWhiteSpace(this.AddressLine2) ? string.Empty : " " + this.AddressLine2.Trim());

            return this;
        }
    }

    public class ECWGenderPatient
    {
        [Index(0)]
        [Name("Patient Name")]
        public string PatientName { get; set; }

        [Index(1)]
        [Name("Dob")]
        public string DateOfBirth { get; set; }

        [Index(2)]
        [Name("Sex")]
        public string Gender { get; set; }

        [Index(3)]
        [Name("Age")]
        public string Age { get; set; }

        [Index(4)]
        [Name("Tel.No")]
        public string PhoneNumber { get; set; }

        [Index(5)]
        [Name("Acc #")]
        public string AccountNumber { get; set; }

        [Index(6)]
        [Name("Race")]
        public string Race { get; set; }

        [Index(7)]
        [Name("Ethnicity")]
        public string Ethnicity { get; set; }

        [Index(8)]
        [Name("Language")]
        public string Language { get; set; }
    }
}
