using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class MedicalProvider
    {
        public MedicalProvider()
        {
            MedicationHistory = new HashSet<MedicationHistory>();
            MentalHealthHistory = new HashSet<MentalHealthHistory>();
            SurgicalHistory = new HashSet<SurgicalHistory>();
            WomensHealthHistory = new HashSet<WomensHealthHistory>();
        }

        public int MedProviderId { get; set; }
        public string MedProviderSpecialty { get; set; }
        public string ActiveOrInactive { get; set; }
        public string MedProviderFirstName { get; set; }
        public string MedProviderLastName { get; set; }
        public int MedProviderLocationId { get; set; }
        public int PhoneNumber { get; set; }
        public int Fax { get; set; }
        public string Email { get; set; }

        public MedCareLocation MedProviderLocation { get; set; }
        public ICollection<MedicationHistory> MedicationHistory { get; set; }
        public ICollection<MentalHealthHistory> MentalHealthHistory { get; set; }
        public ICollection<SurgicalHistory> SurgicalHistory { get; set; }
        public ICollection<WomensHealthHistory> WomensHealthHistory { get; set; }
    }
}
