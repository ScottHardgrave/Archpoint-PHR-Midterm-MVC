using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class AllergyHistory
    {
        public int AllergyHistoryId { get; set; }

        [Display(Name = "Allergen")]
        [DataType(DataType.Text)]
        public string DrugAllergen { get; set; }

        [Display(Name = "Results")]
        [DataType(DataType.Text)]
        public string ContactAllergen { get; set; }

        [Display(Name = "Insect Bites/Sting")]
        [DataType(DataType.Text)]
        public string InsectStingBites { get; set; }

        [Display(Name = "Airborns/Inhaled Allergen")]
        [DataType(DataType.Text)]
        public string AirborneInhaledAllergen { get; set; }

        [Display(Name = "Type Of Reaction")]
        [DataType(DataType.Text)]
        public string TypeOfReaction { get; set; }

        public string Severity { get; set; }
        public string Symptoms { get; set; }

        [Display(Name = "Was medical treatment required?")]
        [DataType(DataType.Text)]
        public string MedTreatmentRequired { get; set; }

        public string Comments { get; set; }
    }
}
