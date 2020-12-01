using CsvHelper.Configuration.Attributes;

namespace HRSA.Models
{
    public class ECWIncomingClaim
    {
        [Name("CLAIMS#")]
        public string ClaimsNumber { get; set; }

        [Name("PATIENT")]
        public string PatientName { get; set; }

        [Name("Phone")]
        public string Phone { get; set; }

        [Name("PVDR")]
        public string PVDR { get; set; }

        [Name("SERVICE DATE")]
        public string ServiceDate { get; set; }

        [Name("AddressLine1")]
        public string AddressLine1 { get; set; }

        [Name("AddressLine2")]
        public string AddressLine2 { get; set; }

        [Name("City")]
        public string City { get; set; }

        [Name("State")]
        public string State { get; set; }

        [Name("Zip")]
        public string ZipCode { get; set; }

        [Name("PAYER")]
        public string Payer { get; set; }

        [Name("STATUS")]
        public string Status { get; set; }

        [Name("CHARGES")]
        public string Charges { get; set; }

        [Name("PMTS/ADJS")]
        public string PaymentsOrAdjustments { get; set; }

        [Name("Adjustment")]
        public string Adjustment { get; set; }

        [Name("WithHeld")]
        public string Withheld { get; set; }

        [Name("Balance")]
        public string Balance { get; set; }

        [Name("Account Number")]
        public string AccountNumber { get; set; }

        [Name("SSN")]
        public string SSN { get; set; }

        [Name("DOB")]
        public string DateOfBirth { get; set; }

        [Name("Gender")]
        public string Gender { get; set; }
    }
}
