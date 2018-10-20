using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class DoctorVisitForm
    {
        public int ReasonForVisitId { get; set; }

        [Display(Name = "What is your current complaint?")]
        [DataType(DataType.Text)]
        public string CurrentComplaint { get; set; }

        [Display(Name = "What are your specific questions for your doctor?")]
        [DataType(DataType.Text)]
        public string CurrentMedQuestion { get; set; }
    }
}
