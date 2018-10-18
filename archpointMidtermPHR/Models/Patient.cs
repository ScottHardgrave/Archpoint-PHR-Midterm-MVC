using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class Patient
    {
        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMi { get; set; }
        public string PatientLastName { get; set; }
        public string Gender { get; set; }
        public string BloodType { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Race { get; set; }
        public string MaritalStatus { get; set; }
        public string Religion { get; set; }
        public string EmploymentInfo { get; set; }
        public string EmergencyContactInfo { get; set; }
        public string LivingWill { get; set; }
        public string DoNotResuscitate { get; set; }
        public string OrganDonor { get; set; }
    }
}
