using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class HospitalAdmitCard
    {
        public int HospitalAdmitId { get; set; }
        public int PatientId { get; set; }
        public int EmployerId { get; set; }
        public int EmergencyContactId { get; set; }
        public int InsuranceId { get; set; }
        public int PolicyHolderId { get; set; }
    }
}
