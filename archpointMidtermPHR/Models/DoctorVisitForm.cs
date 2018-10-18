using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class DoctorVisitForm
    {
        public int ReasonForVisitId { get; set; }
        public string CurrentComplaint { get; set; }
        public string CurrentMedQuestion { get; set; }
    }
}
