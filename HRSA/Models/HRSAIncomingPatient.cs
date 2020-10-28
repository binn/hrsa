using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSA.Models
{
    public class HRSAIncomingPatient
    {
        [Name("Billing TIN Number*")]
        public string BillingTIN { get; set; }

        [Name("Patient First Name*")]
        public string FirstName { get; set; }

        [Name("Patient Middle Initial")]
        public string MiddleInitial { get; set; }

        [Name("Patient Last Name*")]
        public string LastName { get; set; }

        [Name("Patient Date of Birth (MM/DD/YYYY)*")]
        public string DateOfBirth { get; set; }

        [Name("ID Type (SSN, State ID, No ID)*")]
        public string IDType { get; set; }

        [Name("ID Number")]
        public string IDNumber { get; set; }

        [Name("Patient Gender (M/F)*")]
        public string Gender { get; set; }

        [Name("Patient Account Number")]
        public string AccountNumber { get; set; }

        [Name("Patient Street Line 1*")]
        public string AddressLine1 { get; set; }

        [Name("Patient Street Line 2")]
        public string AddressLine2 { get; set; }

        [Name("Patient City*")]
        public string City { get; set; }

        [Name("Patient State*")]
        public string State { get; set; }

        [Name("Patient Zip Code*")]
        public string Zip { get; set; }

        [Name("Service Type (Professional, Institutional Outpatient, Institutional Inpatient)*")]
        public string ServiceType { get; set; }

        [Name("Date of Service (MM/DD/YYYY)")]
        public string DateOfService { get; set; }

        [Name("Date of Admission (MM/DD/YYYY)")]
        public string DateOfAdmission { get; set; }

        [Name("Date of Discharge (MM/DD/YYYY)")]
        public string DateOfDischarge { get; set; }
    }
}
