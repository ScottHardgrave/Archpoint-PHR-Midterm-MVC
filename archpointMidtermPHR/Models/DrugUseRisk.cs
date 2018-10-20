using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class DrugUseRisk
    {
        public int DrugUseRiskId { get; set; }

        [Display(Name = "Recreational drug use?")]
        [DataType(DataType.Text)]
        public string RecreationalDrugUser { get; set; }

        [Display(Name = "Frequency used")]
        [DataType(DataType.Text)]
        public string FrequencyUsed { get; set; }

        [Display(Name = "Years used")]
        [DataType(DataType.Text)]
        public int YearsUsed { get; set; }

        [Display(Name = "Years since quit")]
        [DataType(DataType.Text)]
        public int YearsQuit { get; set; }

        [Display(Name = "Drugs caused you problems in your life?")]
        [DataType(DataType.Text)]
        public string DrugsCausedLifeProblems { get; set; }

        [Display(Name = "If so, explain:")]
        [DataType(DataType.Text)]
        public string DrugsCausedProblemsExpl { get; set; }

        [Display(Name = "Been treated for drug abuse?")]
        [DataType(DataType.Text)]
        public string TreatedForDrugAbuse { get; set; }

        [Display(Name = "Year treated for drug abuse?")]
        [DataType(DataType.Date)]
        public DateTime YearTreated { get; set; }
        public string TreatmentLength { get; set; }
        public string TypeOfTreatment { get; set; }
        public string Comments { get; set; }
    }
}
