using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class FamilyHistory
    {
        public int FamilyMemberId { get; set; }
        public string FamilyMemberType { get; set; }
        public string FamilyMemberFirstName { get; set; }
        public string FamilyMemberLastName { get; set; }
        public string DiseaseDisorder { get; set; }
        public string LivingOrDeceased { get; set; }
        public int AgeAtOnset { get; set; }
        public int AgeAtDeath { get; set; }
        public string ConditionCauseOfDeath { get; set; }
        public string Comments { get; set; }
    }
}
