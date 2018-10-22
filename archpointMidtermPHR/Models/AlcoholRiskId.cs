using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class AlcoholRiskId
    {
        public int AlcoholUseRiskId { get; set; }

        [Display(Name = "Drink Alcohol?")]
        [DataType(DataType.Text)]
        public string DrinkAlc { get; set; }

        [Display(Name = "Daily Drink Count?")]
        [DataType(DataType.Text)]
        public int DailyDrinkCount { get; set; }

        [Display(Name = "Weekend Drink Count")]
        [DataType(DataType.Text)]
        public int WeekendDrinkCount { get; set; }

        [Display(Name = "Social Drink Count?")]
        [DataType(DataType.Text)]
        public int SocialDrinkCount { get; set; }

        [Display(Name = "Years since quit drinking")]
        [DataType(DataType.Text)]
        public int YearsQuitDrinking { get; set; }

        [Display(Name = "Been treated for alcohol abuse?")]
        [DataType(DataType.Text)]
        public string TreatedForAlcAbuse { get; set; }

        [Display(Name = "Year Treated")]
        [DataType(DataType.Text)]
        public DateTime YearTreated { get; set; }

        [Display(Name = "Length of treatment")]
        [DataType(DataType.Text)]
        public string LengthOfTreatment { get; set; }

        [Display(Name = "Type of treatment")]
        [DataType(DataType.Text)]
        public string TypeOfTreatment { get; set; }

        public string Comments { get; set; }
    }
}
