using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class A1cTestRisk
    {
        public int A1cTestRiskId { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateTested { get; set; }
        public string A1cTestResults { get; set; }
        public string A1cTargetRangeGoal { get; set; }
        public string Comments { get; set; }
    }
}
