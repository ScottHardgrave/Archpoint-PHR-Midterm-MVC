using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class SmokingHistoryRisk
    {
        public int SmokingHistRiskId { get; set; }

        [Display(Name = "Smoker?")]
        [DataType(DataType.Text)]
        public string Smoker { get; set; }

        [Display(Name = "Age started smoking")]
        [DataType(DataType.Text)]
        public int AgeStarted { get; set; }

        [Display(Name = "Age quit smoking")]
        [DataType(DataType.Text)]
        public int AgeQuit { get; set; }

        [Display(Name = "Smokeless tobacco?")]
        [DataType(DataType.Text)]
        public string ChewingSmokelessTobacco { get; set; }

        [Display(Name = "Quitting Goal")]
        [DataType(DataType.Text)]
        public string QuittingGoal { get; set; }
    }
}
