using CsvHelper.Configuration.Attributes;
using System;

namespace HRSA.Models
{
    public class SetmorePatient
    {
        [Name("Date")]
        public string Date { get; set; }

        [Name("Resource Name")]
        public string ResourceName { get; set; }

        [Name("Customer Name")]
        public string CustomerName { get; set; }
        
        [Name("Phone")]
        public string Phone { get; set; }

        [Name("Email")]
        public string Email { get; set; }
        
        [Name("Driver License:")]
        public string DL { get; set; }
        
        [Name("DOB:")]
        public string DOB { get; set; }
        
        [Name("Gender:")]
        public string Gender { get; set; }

        [Ignore]
        public DateTime DateOfBirth { get; set; }

        public SetmorePatient Clean()
        {
            this.Gender = string.IsNullOrWhiteSpace(this.Gender) ? "Male" : this.Gender;
            this.Gender = new string(new [] { this.Gender.ToUpper()[0] });
            this.DateOfBirth = DateTime.Parse(this.DOB.Trim());
            this.DL = this.DL.Trim().ToUpper();
            this.CustomerName = this.CustomerName.Trim().ToUpper();
            return this;
        }
    }
}
