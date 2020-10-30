using CsvHelper.Configuration.Attributes;
using System.Linq;

namespace HRSA.Models
{
    public class HRSAOutgoingPatient
    {
        [Index(0)]
        [Name("Billing TIN Number*")]
        public string BillingTIN { get; set; }

        [Index(1)]
        [Name("Patient First Name*")]
        public string FirstName { get; set; }

        [Index(2)]
        [Name("Patient Middle Initial")]
        public string MiddleInitial { get; set; }

        [Index(3)]
        [Name("Patient Last Name*")]
        public string LastName { get; set; }

        [Index(4)]
        [Name("Patient Date of Birth (MM/DD/YYYY)*")]
        public string DateOfBirth { get; set; }

        [Index(5)]
        [Name("ID Type (SSN, State ID, No ID)*")]
        public string IDType { get; set; }

        [Index(6)]
        [Name("ID Number")]
        public string IDNumber { get; set; }

        [Index(7)]
        [Name("Patient Gender (M/F)*")]
        public string Gender { get; set; }

        [Index(8)]
        [Name("Patient Account Number")]
        public string AccountNumber { get; set; }

        [Index(9)]
        [Name("Patient Street Line 1*")]
        public string AddressLine1 { get; set; }

        [Index(10)]
        [Name("Patient Street Line 2")]
        public string AddressLine2 { get; set; }

        [Index(11)]
        [Name("Patient City*")]
        public string City { get; set; }

        [Index(12)]
        [Name("Patient State*")]
        public string State { get; set; }

        [Index(13)]
        [Name("Patient Zip Code*")]
        public string Zip { get; set; }

        [Index(14)]
        [Name("Service Type (Professional, Institutional Outpatient, Institutional Inpatient)*")]
        public string ServiceType { get; set; }

        [Index(15)]
        [Name("Date of Service (MM/DD/YYYY)")]
        public string DateOfService { get; set; }

        [Index(16)]
        [Name("Date of Admission (MM/DD/YYYY)")]
        public string DateOfAdmission { get; set; }

        [Index(17)]
        [Name("Date of Discharge (MM/DD/YYYY)")]
        public string DateOfDischarge { get; set; }

        public static HRSAOutgoingPatient From(HealPatient src)
        {
            var address = src.Address.Split(',').Select(x => x.Trim()).ToArray();
            string[] stzip = address[2].Split('-'); // address requires a certain format

            var patient = new HRSAOutgoingPatient()
            {
                BillingTIN = Global.MasterTIN.Trim(),
                FirstName = src.FirstName.Trim(),
                LastName = src.LastName.Trim(),
                ServiceType = "Professional",
                DateOfService = src.DateOfService.Trim(),
                DateOfAdmission = src.DateOfService.Trim(),
                DateOfDischarge = src.DateOfService.Trim(),
                MiddleInitial = string.Empty,
                IDType = src.DL == "No ID" ? "No ID" : (src.DL == "Non-US ID" ? "No ID" : "State ID"),
                IDNumber = src.DL == "No ID" ? string.Empty : (src.DL != "Non-US ID" ? src.DL.Trim() : string.Empty),
                DateOfBirth = src.DateOfBirth.Trim(),
                AccountNumber = src.AccountNumber.Trim(),
                Gender = src.Gender.Trim(),
                AddressLine1 = address[0].Trim(),
                AddressLine2 = string.Empty,
                City = address[1].Trim(),
                State = stzip[0].Trim(),
                Zip = stzip[1].Trim()
            };

            return patient;
        }
    }
}
