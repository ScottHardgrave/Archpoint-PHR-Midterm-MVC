using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class DiabetesRisk
    {
        public int DiabetesRiskId { get; set; }
        public DateTime DateTaken { get; set; }
        public int LevelBeforeBreakfast { get; set; }
        public int LevelAfterBreakfast { get; set; }
        public int LeverlBeforeLunch { get; set; }
        public int LevelAfterLunch { get; set; }
        public int LevelBeforeDinner { get; set; }
        public int LevelAfterDinner { get; set; }
        public int LevelAtBedtime { get; set; }
        public string Medications { get; set; }
        public int TargertGlucoseBeforeMealLow { get; set; }
        public int TargetGlucoseAfterMealHigh { get; set; }
        public int TargetGlucoseRangeAfterMealLow { get; set; }
        public int TargetGlucoseRangeAfterMealHigh { get; set; }
        public string DateSpan { get; set; }
        public string Comments { get; set; }
    }
}
