using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class SurgicalHistory
    {
        public int SurgeryHistoryId { get; set; }

        [Display(Name = "Surgery Procedure")]
        [DataType(DataType.Text)]
        public string SurgeryProcedure { get; set; }

        [Display(Name = "Date of Procedure")]
        [DataType(DataType.Text)]
        public DateTime DateOfSurgeryProcedure { get; set; }

        [Display(Name = "Medical Provider")]
        [DataType(DataType.Text)]
        public int MedProviderId { get; set; }

        [Display(Name = "Medical Care Location")]
        [DataType(DataType.Text)]
        public int MedCareLocationId { get; set; }

        [Display(Name = "Any problems with anesthesia?")]
        [DataType(DataType.Text)]
        public string ProblemWithAnesthesia { get; set; }

        [Display(Name = "If so, explain")]
        [DataType(DataType.Text)]
        public string AnesthesiaProblemExplanation { get; set; }

        public MedCareLocation MedCareLocation { get; set; }
        public MedicalProvider MedProvider { get; set; }
    }
}
