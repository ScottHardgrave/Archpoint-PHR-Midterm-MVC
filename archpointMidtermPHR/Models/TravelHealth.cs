using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class TravelHealth
    {
        public int TravelHealthId { get; set; }

        [Display(Name = "Country visited:")]
        [DataType(DataType.Text)]
        public string CountryVisited { get; set; }

        [Display(Name = "Date visited:")]
        [DataType(DataType.Text)]
        public DateTime DateVisited { get; set; }

        [Display(Name = "Disease/Illness contracted:")]
        [DataType(DataType.Text)]
        public string DiseaseIllnessContracted { get; set; }

        [Display(Name = "Date contracted:")]
        [DataType(DataType.Text)]
        public DateTime DateContracted { get; set; }
        public string Comments { get; set; }
    }
}
