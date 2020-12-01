using CsvHelper.Configuration.Attributes;
using System;
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
            string[] street = address.Take(address.Length - 2).ToArray();
            string city = address.Skip(address.Length - 2).Take(1).FirstOrDefault();
            string[] stzip = address.LastOrDefault().Split('-'); // address requires a certain format

            if (city == "Blank")
            {
                street = new[] { "1360 Star Ct", "STE T1" };
                city = "Plano";
                stzip = new[] { "TX", "75074" };
            }

            var patient = new HRSAOutgoingPatient()
            {
                BillingTIN = Global.MasterTIN.Trim(),
                FirstName = new string(Validate(src.FirstName).Take(20).ToArray()),
                LastName = new string(Validate(src.LastName).Take(30).ToArray()),
                ServiceType = "Professional",
                DateOfService = src.DateOfService.Trim(),
                DateOfAdmission = src.DateOfService.Trim(),
                DateOfDischarge = src.DateOfService.Trim(),
                MiddleInitial = string.Empty,
                IDType = ParseDLType(src.DL),
                IDNumber = ParseDL(src.DL),
                DateOfBirth = src.DateOfBirth.Trim(),
                AccountNumber = src.AccountNumber.Trim(),
                Gender = src.Gender.Trim(),
                AddressLine1 = string.Join(",", street).Trim(),
                AddressLine2 = string.Empty,
                City = city.Trim(),
                State = stzip[0].Trim(),
                Zip = stzip[1].Trim()
            };

            return patient;
        }

        private static string Validate(string name)
        {
            return name.ToUpper().Trim().Replace("?", "").Replace(".", "").Trim();
        }

        private static string ParseDLType(string dl)
        {
            if (string.IsNullOrWhiteSpace(dl))
                return "No ID";

            if (dl.Trim().ToUpper() == "NO ID")
                return "No ID";
            else
                return "State ID";
        }

        private static string ParseDL(string dl)
        {
            if (string.IsNullOrWhiteSpace(dl))
                return string.Empty;

            if (dl.Trim().ToUpper() == "NO ID")
                return string.Empty;
            else
                return dl.Trim().ToUpper().Replace("-", "").Trim();
        }
    }
}
