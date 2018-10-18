using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class BloodPressureRisk
    {
        public int BloodPressureRiskId { get; set; }
        public DateTime DateDateEntered { get; set; }
        public int SystolicPressure { get; set; }
        public int DiastolicPressure { get; set; }
        public int PulseRate { get; set; }
        public DateTime DateTaken { get; set; }
        public TimeSpan TimeTaken { get; set; }
        public int SystolicBpgoal { get; set; }
        public int DiastolicBpgoal { get; set; }
        public string Comments { get; set; }
    }
}
