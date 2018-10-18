using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class AlcoholRiskId
    {
        public int AlcoholUseRiskId { get; set; }
        public string DrinkAlc { get; set; }
        public int DailyDrinkCount { get; set; }
        public int WeekendDrinkCount { get; set; }
        public int SocialDrinkCount { get; set; }
        public int YearsQuitDrinking { get; set; }
        public string TreatedForAlcAbuse { get; set; }
        public DateTime YearTreated { get; set; }
        public string LengthOfTreatment { get; set; }
        public string TypeOfTreatment { get; set; }
        public string Comments { get; set; }
    }
}
