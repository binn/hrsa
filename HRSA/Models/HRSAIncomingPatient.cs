using CsvHelper.Configuration.Attributes;
using System;

namespace HRSA.Models
{
    public class HRSAIncomingPatient
    {
        public HRSAIncomingPatient()
        {

        }

        [Index(0)]
        [Name("Submission Date")]
        public string SubmissionDate { get; set; }

        [Index(1)]
        [Name("Reference Number")]
        public string ReferenceNumber { get; set; }

        [Index(2)]
        [Name("First Name")]
        public string FirstName { get; set; }

        [Index(3)]
        [Name("Middle Initial")]
        public string MiddleInitial { get; set; }

        [Index(4)]
        [Name("Last Name")]
        public string LastName { get; set; }

        [Index(5)]
        [Name("Date of Birth")]
        public string DateOfBirth { get; set; }

        [Index(6)]
        [Name("Gender")]
        public string Gender { get; set; }

        [Index(7)]
        [Name("Temporary Member ID")]
        public string MemberID { get; set; }

        [Index(8)]
        [Name("Date of Service")]
        public string DateOfService { get; set; }

        [Index(9)]
        [Name("Patient Account Number")]
        public string AccountNumber { get; set; }

        [Index(10)]
        [Name("Address Line 1")]
        public string AddressLine1 { get; set; }

        [Index(11)]
        [Name("Address Line 2")]
        public string AddressLine2 { get; set; }

        [Index(12)]
        [Name("City")]
        public string City { get; set; }

        [Index(13)]
        [Name("State")]
        public string State { get; set; }

        [Index(14)]
        [Name("Zip")]
        public string Zip { get; set; }

        [Index(15)]
        [Name("Group TIN")]
        public string BillingTIN { get; set; }

        [Ignore]
        public string CleanGender => new string(new char[] { this.Gender != null ? this.Gender[0] : 'U' });

        [Ignore]
        public DateTime DOS { get; set; }
    }
}
