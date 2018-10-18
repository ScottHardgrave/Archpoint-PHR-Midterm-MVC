using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class AsthmaRisk
    {
        public int AsthmaRiskId { get; set; }
        public string AsthmaHospitalization { get; set; }
        public DateTime AsthmaHospitalizationDate { get; set; }
        public string AsthmaIcu { get; set; }
        public DateTime IcuAdmitDate { get; set; }
        public string AsthmaTriggers { get; set; }
        public string AsthmaSymptoms { get; set; }
        public string AsthmaSeverity { get; set; }
        public string MedicationForAsthma { get; set; }
        public string MedicationName { get; set; }
        public string Comments { get; set; }
    }
}
