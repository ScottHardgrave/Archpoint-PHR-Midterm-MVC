using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class WomensHealthHistory
    {
        public int WomensHealthHistoryId { get; set; }
        public int MedCareProviderId { get; set; }
        public DateTime DateLastClinicialBreastExam { get; set; }
        public string ResultsLastBreastExam { get; set; }
        public DateTime DateNextBreastExam { get; set; }
        public DateTime DateLastMammogram { get; set; }
        public string ResultsLastMammogram { get; set; }
        public DateTime DateNextMammogram { get; set; }
        public DateTime DateLastPapExam { get; set; }
        public string ResultsLastPapExam { get; set; }
        public DateTime DateNextPapExam { get; set; }
        public string WomensDiseaseDisorder { get; set; }
        public DateTime DateOfDiagnosis { get; set; }
        public string WomensDiseaseDisorderStatus { get; set; }
        public DateTime DateResolved { get; set; }
        public string WomensHealthSurgeryProcedure { get; set; }
        public DateTime DateOfSurgeryProcedure { get; set; }
        public int MedCareLocationId { get; set; }
        public int AgePeriodsStarted { get; set; }
        public string PeriodsRegular { get; set; }
        public string PeriodProblems { get; set; }
        public string PeriodFlow { get; set; }
        public string StillHavingPeriods { get; set; }
        public string BirthControlMethod { get; set; }
        public string HormoneReplacementTherapy { get; set; }
        public DateTime HrtDateStarted { get; set; }
        public DateTime HrtDateStopped { get; set; }
        public int NumOfPregnancies { get; set; }
        public int NumOfLiveBirths { get; set; }
        public int NumOfPrematureBirths { get; set; }
        public int NumOfStillBirths { get; set; }
        public int NumOfMiscarriages { get; set; }
        public int NumOfCsections { get; set; }
        public int NumOfElectiveAbortions { get; set; }
        public string PregnancyComplications { get; set; }

        public MedCareLocation MedCareLocation { get; set; }
        public MedicalProvider MedCareProvider { get; set; }
    }
}
