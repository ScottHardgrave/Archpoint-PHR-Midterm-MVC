using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class WeightAndMeasurementRisk
    {
        public int WeightMeasurementRiskId { get; set; }
        public int Weight { get; set; }
        public DateTime DateTaken { get; set; }
        public int WeightGoal { get; set; }
        public string Height { get; set; }
        public int Bmi { get; set; }
        public int CurrentWaistSize { get; set; }
        public int WaistSizeGoal { get; set; }
        public string Comments { get; set; }
    }
}
