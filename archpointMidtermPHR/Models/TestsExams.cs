using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class TestsExams
    {
        public int TestExamId { get; set; }

        [Display(Name = "Test/Exam given")]
        [DataType(DataType.Text)]
        public string TestExamType { get; set; }

        [Display(Name = "Result")]
        [DataType(DataType.Text)]
        public string TestExamResult { get; set; }

        [Display(Name = "Date of test/exam given")]
        [DataType(DataType.Date)]
        public DateTime DateOfTestExam { get; set; }

        [Display(Name = "Reason")]
        [DataType(DataType.Text)]
        public string ReaonForTestExam { get; set; }

        [Display(Name = "Medical care Location")]
        [DataType(DataType.Text)]
        public int MedCareLocationId { get; set; }

        public MedCareLocation MedCareLocation { get; set; }
    }
}
