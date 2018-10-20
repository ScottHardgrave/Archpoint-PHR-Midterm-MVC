using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class MensHealth
    {
        public int MensHealthHistoryId { get; set; }
        public DateTime DateLastAnnualPhysical { get; set; }
        public DateTime DateNextAnnualPhysical { get; set; }
        public string FamilyHistoryProstateCancer { get; set; }
        public DateTime DateLastProstateExam { get; set; }
        public string LastProstateExamResults { get; set; }
        public DateTime DateNextProstateExam { get; set; }
        public DateTime DateLastPsa { get; set; }
        public string LastPsaresults { get; set; }
        public int PsaLevelTestNumber { get; set; }
        public DateTime DateNextPsatest { get; set; }
        public DateTime DateLastFecalOccultTest { get; set; }
        public string FecalOccultResults { get; set; }
        public DateTime DateNextFecalOccultTest { get; set; }
        public DateTime DateLastSigmoidColonoscopyExam { get; set; }
        public string SigmoidColonoscopyResults { get; set; }
        public DateTime DateNextSigmoidColonoscopy { get; set; }
        public string MensHealthIssues { get; set; }
        public string Comments { get; set; }
    }
}
