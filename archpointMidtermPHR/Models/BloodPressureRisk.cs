using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class BloodPressureRisk
    {
        public int BloodPressureRiskId { get; set; }

        [Display(Name = "Date Record Stored")]
        [DataType(DataType.Text)]
        public DateTime DateDateEntered { get; set; }

        [Display(Name = "Systolic Pressure")]
        [DataType(DataType.Text)]
        public int SystolicPressure { get; set; }

        [Display(Name = "Diastolic Pressure")]
        [DataType(DataType.Text)]
        public int DiastolicPressure { get; set; }

        [Display(Name = "Pulse Rate")]
        [DataType(DataType.Text)]
        public int PulseRate { get; set; }

        [Display(Name = "Date Blood Pressure Taken")]
        [DataType(DataType.Date)]
        public DateTime DateTaken { get; set; }

        [Display(Name = "Time Blood Pressure Taken")]
        [DataType(DataType.Time)]
        public TimeSpan TimeTaken { get; set; }

        [Display(Name = "Systolic Blood Pressure Goal")]
        [DataType(DataType.Text)]
        public int SystolicBpgoal { get; set; }

        [Display(Name = "Diastolic Blood Pressure Goal")]
        [DataType(DataType.Text)]
        public int DiastolicBpgoal { get; set; }
        public string Comments { get; set; }
    }
}
