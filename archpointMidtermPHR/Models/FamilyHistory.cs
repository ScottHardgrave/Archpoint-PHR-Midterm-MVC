using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class FamilyHistory
    {
        public int FamilyMemberId { get; set; }

        [Display(Name = "Relationship")]
        [DataType(DataType.Text)]
        public string FamilyMemberType { get; set; }

        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string FamilyMemberFirstName { get; set; }

        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string FamilyMemberLastName { get; set; }

        [Display(Name = "BeenDisease/Disorder")]
        [DataType(DataType.Text)]
        public string DiseaseDisorder { get; set; }

        [Display(Name = "Living/Deceased?")]
        [DataType(DataType.Text)]
        public string LivingOrDeceased { get; set; }

        [Display(Name = "Age At Onset")]
        [DataType(DataType.Text)]
        public int AgeAtOnset { get; set; }

        [Display(Name = "Age At Death")]
        [DataType(DataType.Text)]
        public int AgeAtDeath { get; set; }

        [Display(Name = "Was the condition the cause of their death")]
        [DataType(DataType.Text)]
        public string ConditionCauseOfDeath { get; set; }
        public string Comments { get; set; }
    }
}
