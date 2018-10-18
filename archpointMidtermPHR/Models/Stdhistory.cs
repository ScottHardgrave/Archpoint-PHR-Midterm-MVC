using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class Stdhistory
    {
        public int StdHistoryId { get; set; }
        public string StdType { get; set; }
        public DateTime StdDateOfDiagnosis { get; set; }
        public string StdStatus { get; set; }
        public DateTime StdDateResolved { get; set; }
        public string StdMedication { get; set; }
        public string Comments { get; set; }
    }
}
