using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class DrugUseRisk
    {
        public int DrugUseRiskId { get; set; }
        public string RecreationalDrugUser { get; set; }
        public string FrequencyUsed { get; set; }
        public int YearsUsed { get; set; }
        public int YearsQuit { get; set; }
        public string DrugsCausedLifeProblems { get; set; }
        public string DrugsCausedProblemsExpl { get; set; }
        public string TreatedForDrugAbuse { get; set; }
        public DateTime YearTreated { get; set; }
        public string TreatmentLength { get; set; }
        public string TypeOfTreatment { get; set; }
        public string Comments { get; set; }
    }
}
