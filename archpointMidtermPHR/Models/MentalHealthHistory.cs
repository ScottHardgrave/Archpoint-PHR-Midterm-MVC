using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class MentalHealthHistory
    {
        public int MentalHealthHistoryId { get; set; }
        public string CurrentTreatmentForMentalDisorder { get; set; }
        public string MedCareLocation { get; set; }
        public string TypeOfTreatment { get; set; }
        public string TreatedInThePast { get; set; }
        public string MentalCondDisorder { get; set; }
        public string CurrentMedication { get; set; }
        public int MedProviderId { get; set; }
        public string Comments { get; set; }

        public MedicalProvider MedProvider { get; set; }
    }
}
