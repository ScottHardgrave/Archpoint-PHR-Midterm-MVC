using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class WeightAndMeasurementRisk
    {
        public int WeightMeasurementRiskId { get; set; }

        [Display(Name = "Current Weight")]
        [DataType(DataType.Text)]
        public int Weight { get; set; }

        [Display(Name = "Date Taken")]
        [DataType(DataType.Date)]
        public DateTime DateTaken { get; set; }

        [Display(Name = "Weight Goal")]
        [DataType(DataType.Text)]
        public int WeightGoal { get; set; }

        [Display(Name = "Height")]
        [DataType(DataType.Text)]
        public string Height { get; set; }

        [Display(Name = "Body Mass Index")]
        [DataType(DataType.Text)]
        public int Bmi { get; set; }

        [Display(Name = "Current Waist Size")]
        [DataType(DataType.Text)]
        public int CurrentWaistSize { get; set; }

        [Display(Name = "Waist Size Goal")]
        [DataType(DataType.Text)]
        public int WaistSizeGoal { get; set; }
        public string Comments { get; set; }
    }
}
