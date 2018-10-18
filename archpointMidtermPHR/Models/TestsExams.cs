using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class TestsExams
    {
        public int TestExamId { get; set; }
        public string TestExamType { get; set; }
        public string TestExamResult { get; set; }
        public DateTime DateOfTestExam { get; set; }
        public string ReaonForTestExam { get; set; }
        public int MedCareLocationId { get; set; }

        public MedCareLocation MedCareLocation { get; set; }
    }
}
