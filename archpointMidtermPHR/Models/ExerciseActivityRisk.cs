using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class ExerciseActivityRisk
    {
        public int ExerciseRiskId { get; set; }
        public string AnyExercise { get; set; }
        public string TypeOfExercise { get; set; }
        public string FrequencyOfExercise { get; set; }
        public string DurationOfExercise { get; set; }
        public string IntensityLevel { get; set; }
        public string DurationGoal { get; set; }
        public string Comments { get; set; }
    }
}
