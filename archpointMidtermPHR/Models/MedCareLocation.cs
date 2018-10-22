using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class MedCareLocation
    {
        public MedCareLocation()
        {
            MedicalProvider = new HashSet<MedicalProvider>();
            SurgicalHistory = new HashSet<SurgicalHistory>();
            TestsExams = new HashSet<TestsExams>();
            WomensHealthHistory = new HashSet<WomensHealthHistory>();
        }

        public int LocationId { get; set; }

        [Display(Name = "Street Address")]
        [DataType(DataType.Text)]
        public string LocationStreetAddress { get; set; }

        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string LocationCity { get; set; }

        [Display(Name = "State/Province")]
        [DataType(DataType.Text)]
        public string LocationStateProvince { get; set; }

        [Display(Name = "Zip Code")]
        [DataType(DataType.Text)]
        public string LocationZipCode { get; set; }

        [Display(Name = "Country")]
        [DataType(DataType.Text)]
        public string LocationCountry { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.Text)]
        public string LocationPhoneNum { get; set; }

        [Display(Name = "Fax")]
        [DataType(DataType.Text)]
        public string LocationFax { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.Text)]
        public string LocationEmail { get; set; }

        [Display(Name = "Name of Location")]
        [DataType(DataType.Text)]
        public string LocationName { get; set; }

        public ICollection<MedicalProvider> MedicalProvider { get; set; }
        public ICollection<SurgicalHistory> SurgicalHistory { get; set; }
        public ICollection<TestsExams> TestsExams { get; set; }
        public ICollection<WomensHealthHistory> WomensHealthHistory { get; set; }
    }
}
