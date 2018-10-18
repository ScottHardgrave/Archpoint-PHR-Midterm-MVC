using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class AllergyHistory
    {
        public int AllergyHistoryId { get; set; }
        public string DrugAllergen { get; set; }
        public string ContactAllergen { get; set; }
        public string InsectStingBites { get; set; }
        public string AirborneInhaledAllergen { get; set; }
        public string TypeOfReaction { get; set; }
        public string Severity { get; set; }
        public string Symptoms { get; set; }
        public string MedTreatmentRequired { get; set; }
        public string Comments { get; set; }
    }
}
