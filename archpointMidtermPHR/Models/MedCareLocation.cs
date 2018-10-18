using System;
using System.Collections.Generic;

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
        public string LocationStreetAddress { get; set; }
        public string LocationCity { get; set; }
        public string LocationStateProvince { get; set; }
        public string LocationZipCode { get; set; }
        public string LocationCountry { get; set; }
        public string LocationPhoneNum { get; set; }
        public string LocationFax { get; set; }
        public string LocationEmail { get; set; }
        public string LocationName { get; set; }

        public ICollection<MedicalProvider> MedicalProvider { get; set; }
        public ICollection<SurgicalHistory> SurgicalHistory { get; set; }
        public ICollection<TestsExams> TestsExams { get; set; }
        public ICollection<WomensHealthHistory> WomensHealthHistory { get; set; }
    }
}
