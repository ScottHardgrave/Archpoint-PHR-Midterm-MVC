using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class DiabetesRisk
    {
        public int DiabetesRiskId { get; set; }

        [Display(Name = "Date Taken")]
        [DataType(DataType.Date)]
        public DateTime DateTaken { get; set; }

        [Display(Name = "Level Before Breakfast")]
        [DataType(DataType.Text)]
        public int LevelBeforeBreakfast { get; set; }

        [Display(Name = "Level After breakfast")]
        [DataType(DataType.Text)]
        public int LevelAfterBreakfast { get; set; }

        [Display(Name = "Level Before Lunch")]
        [DataType(DataType.Text)]
        public int LeverlBeforeLunch { get; set; }

        [Display(Name = "Level After Lunch")]
        [DataType(DataType.Text)]
        public int LevelAfterLunch { get; set; }

        [Display(Name = "Level Before Dinner")]
        [DataType(DataType.Text)]
        public int LevelBeforeDinner { get; set; }

        [Display(Name = "Level After Dinner")]
        [DataType(DataType.Text)]
        public int LevelAfterDinner { get; set; }

        [Display(Name = "Level At Bedtime")]
        [DataType(DataType.Text)]
        public int LevelAtBedtime { get; set; }

        [Display(Name = "Medications?")]
        [DataType(DataType.Text)]
        public string Medications { get; set; }

        [Display(Name = "Target Glucose Before Meal: Lowest Acceptable")]
        [DataType(DataType.Text)]
        public int TargertGlucoseBeforeMealLow { get; set; }

        [Display(Name = "Target Glucose After Meal: Highest Acceptable")]
        [DataType(DataType.Text)]
        public int TargetGlucoseAfterMealHigh { get; set; }

        [Display(Name = "Target Glucose Range After Meal: Lowest")]
        [DataType(DataType.Text)]
        public int TargetGlucoseRangeAfterMealLow { get; set; }

        [Display(Name = "Target Glucose Range After Meal: Highest")]
        [DataType(DataType.Text)]
        public int TargetGlucoseRangeAfterMealHigh { get; set; }

        [Display(Name = "How long of a span did this occur over?")]
        [DataType(DataType.Text)]
        public string DateSpan { get; set; }
        public string Comments { get; set; }
    }
}
