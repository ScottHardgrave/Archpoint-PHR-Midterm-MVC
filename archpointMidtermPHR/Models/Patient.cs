using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class Patient
    {
        public int PatientId { get; set; }

        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string PatientFirstName { get; set; }

        [Display(Name = "Middle Initial")]
        [DataType(DataType.Text)]
        public string PatientMi { get; set; }

        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string PatientLastName { get; set; }

        [Display(Name = "Gender")]
        [DataType(DataType.Text)]
        public string Gender { get; set; }


        [Display(Name = "Blood Type")]
        [DataType(DataType.Text)]
        public string BloodType { get; set; }

        [Display(Name = "Street Address")]
        [DataType(DataType.Text)]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Display(Name = "State/Province")]
        [DataType(DataType.Text)]
        public string StateProvince { get; set; }

        [Display(Name = "Zip Code")]
        [DataType(DataType.Text)]
        public int ZipCode { get; set; }

        [Display(Name = "Country")]
        [DataType(DataType.Text)]
        public string Country { get; set; }

        [Display(Name = "Phone #")]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Race")]
        [DataType(DataType.Text)]
        public string Race { get; set; }

        [Display(Name = "Marital Status:")]
        [DataType(DataType.Text)]
        public string MaritalStatus { get; set; }

        [Display(Name = "Religion:")]
        [DataType(DataType.Text)]
        public string Religion { get; set; }

        [Display(Name = "Employed?")]
        [DataType(DataType.Text)]
        public string EmploymentInfo { get; set; }

        [Display(Name = "Emergency Contact Info")]
        [DataType(DataType.Text)]
        public string EmergencyContactInfo { get; set; }

        [Display(Name = "Living Will?")]
        [DataType(DataType.Text)]
        public string LivingWill { get; set; }

        [Display(Name = "Do Not Resuscitate order?")]
        [DataType(DataType.Text)]
        public string DoNotResuscitate { get; set; }

        [Display(Name = "Organ Donor?")]
        [DataType(DataType.Text)]
        public string OrganDonor { get; set; }
    }
}
