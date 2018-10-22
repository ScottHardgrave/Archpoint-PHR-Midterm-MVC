using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class CholesterolRisk
    {
        public int CholesterolRiskId { get; set; }

        [Display(Name = "Date Cholesterol Taken")]
        [DataType(DataType.Date)]
        public DateTime DateCholTaken { get; set; }

        [Display(Name = "Total Cholesterol Level")]
        [DataType(DataType.Text)]
        public int TotalCholesterol { get; set; }

        [Display(Name = "LDL Cholesterol Level")]
        [DataType(DataType.Text)]
        public int LdlCholesterol { get; set; }

        [Display(Name = "HDL Cholesterol Level")]
        [DataType(DataType.Text)]
        public int HdlCholesterol { get; set; }

        [Display(Name = "Triglycerides")]
        [DataType(DataType.Text)]
        public int Triglycerides { get; set; }

        [Display(Name = "Taken After Fasting?")]
        [DataType(DataType.Text)]
        public string TakenAfterFasting { get; set; }

        [Display(Name = "Total Cholesterol Goal")]
        [DataType(DataType.Text)]
        public int TotalCholGoal { get; set; }

        [Display(Name = "LDL Cholesterol Goal")]
        [DataType(DataType.Text)]
        public int LdlCholGoal { get; set; }

        [Display(Name = "HDL Cholesterol Goal")]
        [DataType(DataType.Text)]
        public int HdlCholGoal { get; set; }

        [Display(Name = "Triglyceride Goal")]
        [DataType(DataType.Text)]
        public int TriglycerideGoal { get; set; }
        public string Comments { get; set; }
    }
}
