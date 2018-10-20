using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class ExerciseActivityRisk
    {
        public int ExerciseRiskId { get; set; }

        [Display(Name = "Any exercise?")]
        [DataType(DataType.Text)]
        public string AnyExercise { get; set; }

        [Display(Name = "If so, then what kind?")]
        [DataType(DataType.Text)]
        public string TypeOfExercise { get; set; }

        [Display(Name = "Frequency Of Exercise")]
        [DataType(DataType.Text)]
        public string FrequencyOfExercise { get; set; }

        [Display(Name = "Duration of Exercise")]
        [DataType(DataType.Text)]
        public string DurationOfExercise { get; set; }

        [Display(Name = "Intensity Level")]
        [DataType(DataType.Text)]
        public string IntensityLevel { get; set; }

        [Display(Name = "Duration Goal")]
        [DataType(DataType.Text)]
        public string DurationGoal { get; set; }
        public string Comments { get; set; }
    }
}
