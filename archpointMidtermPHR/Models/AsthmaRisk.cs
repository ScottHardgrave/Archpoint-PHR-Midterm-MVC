using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class AsthmaRisk
    {
        public int AsthmaRiskId { get; set; }

        [Display(Name = "Hospitalized?")]
        [DataType(DataType.Text)]
        public string AsthmaHospitalization { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime AsthmaHospitalizationDate { get; set; }

        [Display(Name = "ICU Required?")]
        [DataType(DataType.Text)]
        public string AsthmaIcu { get; set; }

        [Display(Name = "ICU Admittance Date")]
        [DataType(DataType.Date)]
        public DateTime IcuAdmitDate { get; set; }

        [Display(Name = "Triggers")]
        [DataType(DataType.Text)]
        public string AsthmaTriggers { get; set; }

        [Display(Name = "Symptoms")]
        [DataType(DataType.Text)]
        public string AsthmaSymptoms { get; set; }

        [Display(Name = "Severity")]
        [DataType(DataType.Text)]
        public string AsthmaSeverity { get; set; }

        [Display(Name = "Medication")]
        [DataType(DataType.Text)]
        public string MedicationForAsthma { get; set; }

        [Display(Name = "Medication Name")]
        [DataType(DataType.Text)]
        public string MedicationName { get; set; }
        public string Comments { get; set; }
    }
}
