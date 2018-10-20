using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Display(Name = "Specialty")]
        [DataType(DataType.Text)]
        public string MedProviderSpecialty { get; set; }

        [Display(Name = "Active?")]
        [DataType(DataType.Text)]
        public string ActiveOrInactive { get; set; }

        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string MedProviderFirstName { get; set; }

        [Display(Name = "Last name")]
        [DataType(DataType.Text)]
        public string MedProviderLastName { get; set; }

        [Display(Name = "Location")]
        [DataType(DataType.Text)]
        public int MedProviderLocationId { get; set; }

        [Display(Name = "Phone #")]
        [DataType(DataType.Text)]
        public int PhoneNumber { get; set; }

        [Display(Name = "Fax")]
        [DataType(DataType.Text)]
        public int Fax { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        public MedCareLocation MedProviderLocation { get; set; }
        public ICollection<MedicationHistory> MedicationHistory { get; set; }
        public ICollection<MentalHealthHistory> MentalHealthHistory { get; set; }
        public ICollection<SurgicalHistory> SurgicalHistory { get; set; }
        public ICollection<WomensHealthHistory> WomensHealthHistory { get; set; }
    }
}
