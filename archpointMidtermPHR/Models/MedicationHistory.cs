using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class MedicationHistory
    {
        public int MedicationId { get; set; }
        public string MedicationName { get; set; }
        public string MedStrength { get; set; }
        public string MedDosage { get; set; }
        public string MedFrequency { get; set; }
        public string ConditionBeingTreated { get; set; }
        public string DrugStatus { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateStopped { get; set; }
        public int MedProviderId { get; set; }
        public string PharmacyUsed { get; set; }
        public string PharmacyNumber { get; set; }
        public string PrescriptionNumber { get; set; }
        public int Refills { get; set; }
        public string OtcDrugs { get; set; }
        public string VitaminsAndSupplements { get; set; }
        public string CommentsDirections { get; set; }

        public MedicalProvider MedProvider { get; set; }
    }
}
