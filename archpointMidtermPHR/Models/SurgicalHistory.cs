using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class SurgicalHistory
    {
        public int SurgeryHistoryId { get; set; }
        public string SurgeryProcedure { get; set; }
        public DateTime DateOfSurgeryProcedure { get; set; }
        public int MedProviderId { get; set; }
        public int MedCareLocationId { get; set; }
        public string ProblemWithAnesthesia { get; set; }
        public string AnesthesiaProblemExplanation { get; set; }

        public MedCareLocation MedCareLocation { get; set; }
        public MedicalProvider MedProvider { get; set; }
    }
}
