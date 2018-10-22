using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class A1cTestRisk
    {

        public int A1cTestRiskId { get; set; }

        [Display(Name = "Date Entered")]
        [DataType(DataType.Date)]
        public DateTime DateEntered { get; set; }

        [Display(Name = "Date Tested")]
        [DataType(DataType.Date)]
        public DateTime DateTested { get; set; }

        [Display(Name = "Results")]
        [DataType(DataType.Text)]
        public string A1cTestResults { get; set; }

        [Display(Name = "Target Range Goal")]
        [DataType(DataType.Text)]
        public string A1cTargetRangeGoal { get; set; }
  
        public string Comments { get; set; }
    }
}
