using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class MentalHealthHistory
    {
        public int MentalHealthHistoryId { get; set; }

        [Display(Name = "Current Treatment")]
        [DataType(DataType.Text)]
        public string CurrentTreatmentForMentalDisorder { get; set; }

        [Display(Name = "Location where being treated")]
        [DataType(DataType.Text)]
        public string MedCareLocation { get; set; }

        [Display(Name = "Type of Treatment:")]
        [DataType(DataType.Text)]
        public string TypeOfTreatment { get; set; }

        [Display(Name = "Has this condition been treated before?")]
        [DataType(DataType.Text)]
        public string TreatedInThePast { get; set; }

        [Display(Name = "Name of Condition/Disorder")]
        [DataType(DataType.Text)]
        public string MentalCondDisorder { get; set; }

        [Display(Name = "Current Medications")]
        [DataType(DataType.Text)]
        public string CurrentMedication { get; set; }

        [Display(Name = "Medical Provider")]
        [DataType(DataType.Text)]
        public int MedProviderId { get; set; }
        public string Comments { get; set; }

        public MedicalProvider MedProvider { get; set; }
    }
}
