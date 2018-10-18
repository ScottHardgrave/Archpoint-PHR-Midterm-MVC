using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class CholesterolRisk
    {
        public int CholesterolRiskId { get; set; }
        public DateTime DateCholTaken { get; set; }
        public int TotalCholesterol { get; set; }
        public int LdlCholesterol { get; set; }
        public int HdlCholesterol { get; set; }
        public int Triglycerides { get; set; }
        public string TakenAfterFasting { get; set; }
        public int TotalCholGoal { get; set; }
        public int LdlCholGoal { get; set; }
        public int HdlCholGoal { get; set; }
        public int TriglycerideGoal { get; set; }
        public string Comments { get; set; }
    }
}
