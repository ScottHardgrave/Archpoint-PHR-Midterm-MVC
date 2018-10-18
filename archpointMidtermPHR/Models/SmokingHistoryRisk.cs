using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class SmokingHistoryRisk
    {
        public int SmokingHistRiskId { get; set; }
        public string Smoker { get; set; }
        public int AgeStarted { get; set; }
        public int AgeQuit { get; set; }
        public string ChewingSmokelessTobacco { get; set; }
        public string QuittingGoal { get; set; }
    }
}
