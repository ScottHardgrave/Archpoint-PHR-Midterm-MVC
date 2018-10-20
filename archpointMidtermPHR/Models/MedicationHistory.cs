using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class MedicationHistory
    {
        public int MedicationId { get; set; }

        [Display(Name = "Name of Medication")]
        [DataType(DataType.Text)]
        public string MedicationName { get; set; }

        [Display(Name = "Strength")]
        [DataType(DataType.Text)]
        public string MedStrength { get; set; }

        [Display(Name = "Dosage")]
        [DataType(DataType.Text)]
        public string MedDosage { get; set; }

        [Display(Name = "Frequency")]
        [DataType(DataType.Text)]
        public string MedFrequency { get; set; }

        [Display(Name = "Condition being treated")]
        [DataType(DataType.Text)]
        public string ConditionBeingTreated { get; set; }

        [Display(Name = "Status")]
        [DataType(DataType.Text)]
        public string DrugStatus { get; set; }

        [Display(Name = "Date started taking")]
        [DataType(DataType.Date)]
        public DateTime DateStarted { get; set; }

        [Display(Name = "Date stopped taking")]
        [DataType(DataType.Date)]
        public DateTime DateStopped { get; set; }

        [Display(Name = "Medical Provider")]
        [DataType(DataType.Text)]
        public int MedProviderId { get; set; }

        [Display(Name = "Pharmacy")]
        [DataType(DataType.Text)]
        public string PharmacyUsed { get; set; }

        [Display(Name = "Pharmacy #")]
        [DataType(DataType.Text)]
        public string PharmacyNumber { get; set; }

        [Display(Name = "Prescription #")]
        [DataType(DataType.Text)]
        public string PrescriptionNumber { get; set; }

        [Display(Name = "Refills")]
        [DataType(DataType.Text)]
        public int Refills { get; set; }

        [Display(Name = "OTC Drugs")]
        [DataType(DataType.Text)]
        public string OtcDrugs { get; set; }

        [Display(Name = "Vitamins/Supplements")]
        [DataType(DataType.Text)]
        public string VitaminsAndSupplements { get; set; }

        [Display(Name = "Comments/Directions")]
        [DataType(DataType.Text)]
        public string CommentsDirections { get; set; }

        public MedicalProvider MedProvider { get; set; }
    }
}
