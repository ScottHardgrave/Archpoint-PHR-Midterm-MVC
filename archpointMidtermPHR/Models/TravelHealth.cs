using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class TravelHealth
    {
        public int TravelHealthId { get; set; }
        public string CountryVisited { get; set; }
        public DateTime DateVisited { get; set; }
        public string DiseaseIllnessContracted { get; set; }
        public DateTime DateContracted { get; set; }
        public string Comments { get; set; }
    }
}
