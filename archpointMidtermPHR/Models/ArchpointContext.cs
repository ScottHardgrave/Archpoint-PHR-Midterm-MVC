using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class ArchpointContext : DbContext
    {
        public ArchpointContext()
        {
        }

        public ArchpointContext(DbContextOptions<ArchpointContext> options)
            : base(options)
        {
        }

        public virtual DbSet<A1cTestRisk> A1cTestRisk { get; set; }
        public virtual DbSet<AlcoholRiskId> AlcoholRiskId { get; set; }
        public virtual DbSet<AllergyHistory> AllergyHistory { get; set; }
        public virtual DbSet<AsthmaRisk> AsthmaRisk { get; set; }
        public virtual DbSet<BloodPressureRisk> BloodPressureRisk { get; set; }
        public virtual DbSet<CholesterolRisk> CholesterolRisk { get; set; }
        public virtual DbSet<DiabetesRisk> DiabetesRisk { get; set; }
        public virtual DbSet<DoctorVisitForm> DoctorVisitForm { get; set; }
        public virtual DbSet<DrugUseRisk> DrugUseRisk { get; set; }
        public virtual DbSet<EmergencyContact> EmergencyContact { get; set; }
        public virtual DbSet<EmployerInfo> EmployerInfo { get; set; }
        public virtual DbSet<ExerciseActivityRisk> ExerciseActivityRisk { get; set; }
        public virtual DbSet<FamilyHistory> FamilyHistory { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<HospitalAdmitCard> HospitalAdmitCard { get; set; }
        public virtual DbSet<Immunizations> Immunizations { get; set; }
        public virtual DbSet<InsurancePolicyHolder> InsurancePolicyHolder { get; set; }
        public virtual DbSet<LegalDocuments> LegalDocuments { get; set; }
        public virtual DbSet<MedCareLocation> MedCareLocation { get; set; }
        public virtual DbSet<MedicalProvider> MedicalProvider { get; set; }
        public virtual DbSet<MedicationHistory> MedicationHistory { get; set; }
        public virtual DbSet<MensHealth> MensHealth { get; set; }
        public virtual DbSet<MentalHealthHistory> MentalHealthHistory { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<SmokingHistoryRisk> SmokingHistoryRisk { get; set; }
        public virtual DbSet<Stdhistory> Stdhistory { get; set; }
        public virtual DbSet<SurgicalHistory> SurgicalHistory { get; set; }
        public virtual DbSet<TestsExams> TestsExams { get; set; }
        public virtual DbSet<TravelHealth> TravelHealth { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<WeightAndMeasurementRisk> WeightAndMeasurementRisk { get; set; }
        public virtual DbSet<WomensHealthHistory> WomensHealthHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Archpoint;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<A1cTestRisk>(entity =>
            {
                entity.Property(e => e.A1cTestRiskId).HasColumnName("a1cTestRiskID");

                entity.Property(e => e.A1cTargetRangeGoal)
                    .IsRequired()
                    .HasColumnName("a1cTargetRangeGoal")
                    .HasMaxLength(50);

                entity.Property(e => e.A1cTestResults)
                    .IsRequired()
                    .HasColumnName("a1cTestResults")
                    .HasMaxLength(50);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.DateEntered)
                    .HasColumnName("dateEntered")
                    .HasColumnType("date");

                entity.Property(e => e.DateTested)
                    .HasColumnName("dateTested")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<AlcoholRiskId>(entity =>
            {
                entity.HasKey(e => e.AlcoholUseRiskId);

                entity.ToTable("AlcoholRiskID");

                entity.Property(e => e.AlcoholUseRiskId).HasColumnName("alcoholUseRiskID");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.DailyDrinkCount).HasColumnName("dailyDrinkCount");

                entity.Property(e => e.DrinkAlc)
                    .IsRequired()
                    .HasColumnName("drinkAlc")
                    .HasMaxLength(50);

                entity.Property(e => e.LengthOfTreatment)
                    .IsRequired()
                    .HasColumnName("lengthOfTreatment")
                    .HasMaxLength(50);

                entity.Property(e => e.SocialDrinkCount).HasColumnName("socialDrinkCount");

                entity.Property(e => e.TreatedForAlcAbuse)
                    .IsRequired()
                    .HasColumnName("treatedForAlcAbuse")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeOfTreatment)
                    .IsRequired()
                    .HasColumnName("typeOfTreatment")
                    .HasMaxLength(50);

                entity.Property(e => e.WeekendDrinkCount).HasColumnName("weekendDrinkCount");

                entity.Property(e => e.YearTreated)
                    .HasColumnName("yearTreated")
                    .HasColumnType("date");

                entity.Property(e => e.YearsQuitDrinking).HasColumnName("yearsQuitDrinking");
            });

            modelBuilder.Entity<AllergyHistory>(entity =>
            {
                entity.Property(e => e.AllergyHistoryId).HasColumnName("allergyHistoryID");

                entity.Property(e => e.AirborneInhaledAllergen)
                    .IsRequired()
                    .HasColumnName("airborneInhaledAllergen")
                    .HasMaxLength(50);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.ContactAllergen)
                    .IsRequired()
                    .HasColumnName("contactAllergen")
                    .HasMaxLength(50);

                entity.Property(e => e.DrugAllergen)
                    .IsRequired()
                    .HasColumnName("drugAllergen")
                    .HasMaxLength(50);

                entity.Property(e => e.InsectStingBites)
                    .IsRequired()
                    .HasColumnName("insectStingBites")
                    .HasMaxLength(50);

                entity.Property(e => e.MedTreatmentRequired)
                    .IsRequired()
                    .HasColumnName("medTreatmentRequired")
                    .HasMaxLength(50);

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasColumnName("severity")
                    .HasMaxLength(50);

                entity.Property(e => e.Symptoms)
                    .IsRequired()
                    .HasColumnName("symptoms")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeOfReaction)
                    .IsRequired()
                    .HasColumnName("typeOfReaction")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AsthmaRisk>(entity =>
            {
                entity.Property(e => e.AsthmaRiskId).HasColumnName("asthmaRiskID");

                entity.Property(e => e.AsthmaHospitalization)
                    .IsRequired()
                    .HasColumnName("asthmaHospitalization")
                    .HasMaxLength(50);

                entity.Property(e => e.AsthmaHospitalizationDate)
                    .HasColumnName("asthmaHospitalizationDate")
                    .HasColumnType("date");

                entity.Property(e => e.AsthmaIcu)
                    .IsRequired()
                    .HasColumnName("asthmaICU")
                    .HasMaxLength(50);

                entity.Property(e => e.AsthmaSeverity)
                    .IsRequired()
                    .HasColumnName("asthmaSeverity")
                    .HasMaxLength(50);

                entity.Property(e => e.AsthmaSymptoms)
                    .IsRequired()
                    .HasColumnName("asthmaSymptoms")
                    .HasMaxLength(50);

                entity.Property(e => e.AsthmaTriggers)
                    .IsRequired()
                    .HasColumnName("asthmaTriggers")
                    .HasMaxLength(50);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.IcuAdmitDate)
                    .HasColumnName("icuAdmitDate")
                    .HasColumnType("date");

                entity.Property(e => e.MedicationForAsthma)
                    .IsRequired()
                    .HasColumnName("medicationForAsthma")
                    .HasMaxLength(50);

                entity.Property(e => e.MedicationName)
                    .IsRequired()
                    .HasColumnName("medicationName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BloodPressureRisk>(entity =>
            {
                entity.Property(e => e.BloodPressureRiskId).HasColumnName("bloodPressureRiskID");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.DateDateEntered)
                    .HasColumnName("dateDateEntered")
                    .HasColumnType("date");

                entity.Property(e => e.DateTaken)
                    .HasColumnName("dateTaken")
                    .HasColumnType("date");

                entity.Property(e => e.DiastolicBpgoal).HasColumnName("diastolicBPGoal");

                entity.Property(e => e.DiastolicPressure).HasColumnName("diastolicPressure");

                entity.Property(e => e.PulseRate).HasColumnName("pulseRate");

                entity.Property(e => e.SystolicBpgoal).HasColumnName("systolicBPGoal");

                entity.Property(e => e.SystolicPressure).HasColumnName("systolicPressure");

                entity.Property(e => e.TimeTaken).HasColumnName("timeTaken");
            });

            modelBuilder.Entity<CholesterolRisk>(entity =>
            {
                entity.Property(e => e.CholesterolRiskId).HasColumnName("cholesterolRiskID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.DateCholTaken)
                    .HasColumnName("dateCholTaken")
                    .HasColumnType("date");

                entity.Property(e => e.HdlCholGoal).HasColumnName("hdlCholGoal");

                entity.Property(e => e.HdlCholesterol).HasColumnName("hdlCholesterol");

                entity.Property(e => e.LdlCholGoal).HasColumnName("ldlCholGoal");

                entity.Property(e => e.LdlCholesterol).HasColumnName("ldlCholesterol");

                entity.Property(e => e.TakenAfterFasting)
                    .IsRequired()
                    .HasColumnName("takenAfterFasting")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalCholGoal).HasColumnName("totalCholGoal");

                entity.Property(e => e.TotalCholesterol).HasColumnName("totalCholesterol");

                entity.Property(e => e.TriglycerideGoal).HasColumnName("triglycerideGoal");

                entity.Property(e => e.Triglycerides).HasColumnName("triglycerides");
            });

            modelBuilder.Entity<DiabetesRisk>(entity =>
            {
                entity.Property(e => e.DiabetesRiskId).HasColumnName("diabetesRiskID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.DateSpan)
                    .IsRequired()
                    .HasColumnName("dateSpan")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTaken)
                    .HasColumnName("dateTaken")
                    .HasColumnType("date");

                entity.Property(e => e.LevelAfterBreakfast).HasColumnName("levelAfterBreakfast");

                entity.Property(e => e.LevelAfterDinner).HasColumnName("levelAfterDinner");

                entity.Property(e => e.LevelAfterLunch).HasColumnName("levelAfterLunch");

                entity.Property(e => e.LevelAtBedtime).HasColumnName("levelAtBedtime");

                entity.Property(e => e.LevelBeforeBreakfast).HasColumnName("levelBeforeBreakfast");

                entity.Property(e => e.LevelBeforeDinner).HasColumnName("levelBeforeDinner");

                entity.Property(e => e.LeverlBeforeLunch).HasColumnName("leverlBeforeLunch");

                entity.Property(e => e.Medications)
                    .IsRequired()
                    .HasColumnName("medications")
                    .HasMaxLength(200);

                entity.Property(e => e.TargertGlucoseBeforeMealLow).HasColumnName("targertGlucoseBeforeMealLow");

                entity.Property(e => e.TargetGlucoseAfterMealHigh).HasColumnName("targetGlucoseAfterMealHigh");

                entity.Property(e => e.TargetGlucoseRangeAfterMealHigh).HasColumnName("targetGlucoseRangeAfterMealHigh");

                entity.Property(e => e.TargetGlucoseRangeAfterMealLow).HasColumnName("targetGlucoseRangeAfterMealLow");
            });

            modelBuilder.Entity<DoctorVisitForm>(entity =>
            {
                entity.HasKey(e => e.ReasonForVisitId);

                entity.Property(e => e.ReasonForVisitId).HasColumnName("reasonForVisitID");

                entity.Property(e => e.CurrentComplaint)
                    .IsRequired()
                    .HasColumnName("currentComplaint")
                    .HasMaxLength(200);

                entity.Property(e => e.CurrentMedQuestion)
                    .IsRequired()
                    .HasColumnName("currentMedQuestion")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<DrugUseRisk>(entity =>
            {
                entity.Property(e => e.DrugUseRiskId).HasColumnName("drugUseRiskID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.DrugsCausedLifeProblems)
                    .IsRequired()
                    .HasColumnName("drugsCausedLifeProblems")
                    .HasMaxLength(50);

                entity.Property(e => e.DrugsCausedProblemsExpl)
                    .IsRequired()
                    .HasColumnName("drugsCausedProblemsExpl")
                    .HasMaxLength(50);

                entity.Property(e => e.FrequencyUsed)
                    .IsRequired()
                    .HasColumnName("frequencyUsed")
                    .HasMaxLength(50);

                entity.Property(e => e.RecreationalDrugUser)
                    .IsRequired()
                    .HasColumnName("recreationalDrugUser")
                    .HasMaxLength(50);

                entity.Property(e => e.TreatedForDrugAbuse)
                    .IsRequired()
                    .HasColumnName("treatedForDrugAbuse")
                    .HasMaxLength(50);

                entity.Property(e => e.TreatmentLength)
                    .IsRequired()
                    .HasColumnName("treatmentLength")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeOfTreatment)
                    .IsRequired()
                    .HasColumnName("typeOfTreatment")
                    .HasMaxLength(50);

                entity.Property(e => e.YearTreated)
                    .HasColumnName("yearTreated")
                    .HasColumnType("date");

                entity.Property(e => e.YearsQuit).HasColumnName("yearsQuit");

                entity.Property(e => e.YearsUsed).HasColumnName("yearsUsed");
            });

            modelBuilder.Entity<EmergencyContact>(entity =>
            {
                entity.Property(e => e.EmergencyContactId).HasColumnName("emergencyContactID");

                entity.Property(e => e.EmerContactCellPhone)
                    .IsRequired()
                    .HasColumnName("emerContactCellPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.EmerContactCity)
                    .IsRequired()
                    .HasColumnName("emerContactCity")
                    .HasMaxLength(200);

                entity.Property(e => e.EmerContactCountry)
                    .IsRequired()
                    .HasColumnName("emerContactCountry")
                    .HasMaxLength(200);

                entity.Property(e => e.EmerContactDayPhone)
                    .IsRequired()
                    .HasColumnName("emerContactDayPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.EmerContactEmail)
                    .IsRequired()
                    .HasColumnName("emerContactEmail")
                    .HasMaxLength(200);

                entity.Property(e => e.EmerContactEveningPhone)
                    .IsRequired()
                    .HasColumnName("emerContactEveningPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.EmerContactFirstName)
                    .IsRequired()
                    .HasColumnName("emerContactFirstName")
                    .HasMaxLength(200);

                entity.Property(e => e.EmerContactLastName)
                    .IsRequired()
                    .HasColumnName("emerContactLastName")
                    .HasMaxLength(200);

                entity.Property(e => e.EmerContactStateProvince)
                    .IsRequired()
                    .HasColumnName("emerContactStateProvince")
                    .HasMaxLength(520);

                entity.Property(e => e.EmerContactStreetAddress)
                    .IsRequired()
                    .HasColumnName("emerContactStreetAddress")
                    .HasMaxLength(200);

                entity.Property(e => e.EmerContactZip)
                    .IsRequired()
                    .HasColumnName("emerContactZip")
                    .HasMaxLength(50);

                entity.Property(e => e.PrimaryOrSecondaryContact)
                    .IsRequired()
                    .HasColumnName("primaryOrSecondaryContact")
                    .HasMaxLength(50);

                entity.Property(e => e.RelationshipToPatient)
                    .IsRequired()
                    .HasColumnName("relationshipToPatient")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployerInfo>(entity =>
            {
                entity.HasKey(e => e.EmployerId);

                entity.Property(e => e.EmployerId).HasColumnName("employerID");

                entity.Property(e => e.EmployerAddress)
                    .IsRequired()
                    .HasColumnName("employerAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployerCity)
                    .IsRequired()
                    .HasColumnName("employerCity")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployerName)
                    .IsRequired()
                    .HasColumnName("employerName")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployerPhone)
                    .IsRequired()
                    .HasColumnName("employerPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployerStateProvince)
                    .IsRequired()
                    .HasColumnName("employerStateProvince")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployerZip)
                    .IsRequired()
                    .HasColumnName("employerZip")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ExerciseActivityRisk>(entity =>
            {
                entity.HasKey(e => e.ExerciseRiskId);

                entity.Property(e => e.ExerciseRiskId).HasColumnName("exerciseRiskID");

                entity.Property(e => e.AnyExercise)
                    .IsRequired()
                    .HasColumnName("anyExercise")
                    .HasMaxLength(50);

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.DurationGoal)
                    .IsRequired()
                    .HasColumnName("durationGoal")
                    .HasMaxLength(50);

                entity.Property(e => e.DurationOfExercise)
                    .IsRequired()
                    .HasColumnName("durationOfExercise")
                    .HasMaxLength(50);

                entity.Property(e => e.FrequencyOfExercise)
                    .IsRequired()
                    .HasColumnName("frequencyOfExercise")
                    .HasMaxLength(50);

                entity.Property(e => e.IntensityLevel)
                    .IsRequired()
                    .HasColumnName("intensityLevel")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeOfExercise)
                    .IsRequired()
                    .HasColumnName("typeOfExercise")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FamilyHistory>(entity =>
            {
                entity.HasKey(e => e.FamilyMemberId);

                entity.Property(e => e.FamilyMemberId).HasColumnName("FamilyMemberID");

                entity.Property(e => e.AgeAtDeath).HasColumnName("ageAtDeath");

                entity.Property(e => e.AgeAtOnset).HasColumnName("ageAtOnset");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.ConditionCauseOfDeath)
                    .IsRequired()
                    .HasColumnName("conditionCauseOfDeath")
                    .HasMaxLength(50);

                entity.Property(e => e.DiseaseDisorder)
                    .IsRequired()
                    .HasColumnName("diseaseDisorder")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyMemberFirstName)
                    .IsRequired()
                    .HasColumnName("familyMemberFirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyMemberLastName)
                    .IsRequired()
                    .HasColumnName("familyMemberLastName")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyMemberType)
                    .IsRequired()
                    .HasColumnName("familyMemberType")
                    .HasMaxLength(50);

                entity.Property(e => e.LivingOrDeceased)
                    .IsRequired()
                    .HasColumnName("livingOrDeceased")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.FeedbackId).HasColumnName("feedbackID");

                entity.Property(e => e.EasyToUnderstand)
                    .IsRequired()
                    .HasColumnName("easyToUnderstand")
                    .HasMaxLength(50);

                entity.Property(e => e.HowArchpointWasFound)
                    .IsRequired()
                    .HasColumnName("howArchpointWasFound")
                    .HasMaxLength(50);

                entity.Property(e => e.SuggestionsForImprovements)
                    .IsRequired()
                    .HasColumnName("suggestionsForImprovements")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HospitalAdmitCard>(entity =>
            {
                entity.HasKey(e => e.HospitalAdmitId);

                entity.Property(e => e.HospitalAdmitId).HasColumnName("hospitalAdmitID");

                entity.Property(e => e.EmergencyContactId).HasColumnName("emergencyContactID");

                entity.Property(e => e.EmployerId).HasColumnName("employerID");

                entity.Property(e => e.InsuranceId).HasColumnName("insuranceID");

                entity.Property(e => e.PatientId).HasColumnName("patientID");

                entity.Property(e => e.PolicyHolderId).HasColumnName("policyHolderID");
            });

            modelBuilder.Entity<Immunizations>(entity =>
            {
                entity.HasKey(e => e.ImmunizationId);

                entity.Property(e => e.ImmunizationId).HasColumnName("immunizationID");

                entity.Property(e => e.AdministeredBy)
                    .IsRequired()
                    .HasColumnName("administeredBy")
                    .HasMaxLength(50);

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.DateLastTetanus)
                    .HasColumnName("dateLastTetanus")
                    .HasColumnType("date");

                entity.Property(e => e.DateReceived)
                    .HasColumnName("dateReceived")
                    .HasColumnType("date");

                entity.Property(e => e.ImmunizationType)
                    .IsRequired()
                    .HasColumnName("immunizationType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InsurancePolicyHolder>(entity =>
            {
                entity.HasKey(e => e.PolicyHolderId);

                entity.Property(e => e.PolicyHolderId).HasColumnName("policyHolderID");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("dateOfBirth")
                    .HasColumnType("date");

                entity.Property(e => e.PolicyHolderFirstName)
                    .IsRequired()
                    .HasColumnName("policyHolderFirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.PolicyHolderLastName)
                    .IsRequired()
                    .HasColumnName("policyHolderLastName")
                    .HasMaxLength(50);

                entity.Property(e => e.PolicyHolderMidInit)
                    .IsRequired()
                    .HasColumnName("policyHolderMidInit")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PolicyHolderSsn).HasColumnName("policyHolderSSN");

                entity.Property(e => e.RealtionshipToPolicyHolder)
                    .IsRequired()
                    .HasColumnName("realtionshipToPolicyHolder")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LegalDocuments>(entity =>
            {
                entity.HasKey(e => e.LegalDocId);

                entity.Property(e => e.LegalDocId).HasColumnName("legalDocID");

                entity.Property(e => e.AttorneyFirstName)
                    .IsRequired()
                    .HasColumnName("attorneyFirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.AttorneyLastName)
                    .IsRequired()
                    .HasColumnName("attorneyLastName")
                    .HasMaxLength(50);

                entity.Property(e => e.AttorneyPhone)
                    .IsRequired()
                    .HasColumnName("attorneyPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.DnrDateLastUpdated)
                    .HasColumnName("dnrDateLastUpdated")
                    .HasColumnType("date");

                entity.Property(e => e.DnrDateSigned)
                    .HasColumnName("dnrDateSigned")
                    .HasColumnType("date");

                entity.Property(e => e.DoNotResuscitateOrder)
                    .IsRequired()
                    .HasColumnName("doNotResuscitateOrder")
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentContactsFirstName)
                    .IsRequired()
                    .HasColumnName("documentContactsFirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentContactsLastName)
                    .IsRequired()
                    .HasColumnName("documentContactsLastName")
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentContactsPhone)
                    .IsRequired()
                    .HasColumnName("documentContactsPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentsLocation)
                    .IsRequired()
                    .HasColumnName("documentsLocation")
                    .HasMaxLength(50);

                entity.Property(e => e.FamilyAwareOfInstructions)
                    .IsRequired()
                    .HasColumnName("familyAwareOfInstructions")
                    .HasMaxLength(50);

                entity.Property(e => e.HealtchCareProxyDateLastUpdated)
                    .HasColumnName("healtchCareProxyDateLastUpdated")
                    .HasColumnType("date");

                entity.Property(e => e.HealthCareProxy)
                    .IsRequired()
                    .HasColumnName("healthCareProxy")
                    .HasMaxLength(50);

                entity.Property(e => e.HealthCareProxyDateSigned)
                    .HasColumnName("healthCareProxyDateSigned")
                    .HasColumnType("date");

                entity.Property(e => e.HealthCareProxyName)
                    .IsRequired()
                    .HasColumnName("healthCareProxyName")
                    .HasMaxLength(50);

                entity.Property(e => e.LivingWill)
                    .IsRequired()
                    .HasColumnName("livingWill")
                    .HasMaxLength(50);

                entity.Property(e => e.LivingWillCopyOnFile)
                    .IsRequired()
                    .HasColumnName("livingWillCopyOnFile")
                    .HasMaxLength(50);

                entity.Property(e => e.LivingWillDateSigned)
                    .HasColumnName("livingWillDateSigned")
                    .HasColumnType("date");

                entity.Property(e => e.LivingWillLastUpdated)
                    .HasColumnName("livingWillLastUpdated")
                    .HasColumnType("date");

                entity.Property(e => e.MedPowerOfAttorneyCopyOnFile)
                    .IsRequired()
                    .HasColumnName("medPowerOfAttorneyCopyOnFile")
                    .HasMaxLength(50);

                entity.Property(e => e.MedPowerOfAttorneyDateLastUpdated)
                    .IsRequired()
                    .HasColumnName("medPowerOfAttorneyDateLastUpdated")
                    .HasMaxLength(50);

                entity.Property(e => e.MedPowerOfAttorneyDateSigned)
                    .IsRequired()
                    .HasColumnName("medPowerOfAttorneyDateSigned")
                    .HasMaxLength(50);

                entity.Property(e => e.MedPowerOfAttorneyName)
                    .IsRequired()
                    .HasColumnName("medPowerOfAttorneyName")
                    .HasMaxLength(50);

                entity.Property(e => e.MedicalPowerOfAttorney)
                    .IsRequired()
                    .HasColumnName("medicalPowerOfAttorney")
                    .HasMaxLength(50);

                entity.Property(e => e.OrganDonorDateSigned)
                    .HasColumnName("organDonorDateSigned")
                    .HasColumnType("date");

                entity.Property(e => e.OrganDonorDocument)
                    .IsRequired()
                    .HasColumnName("organDonorDocument")
                    .HasMaxLength(50);

                entity.Property(e => e.OrganDonorLastUpdate)
                    .HasColumnName("organDonorLastUpdate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<MedCareLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.Property(e => e.LocationId).HasColumnName("locationID");

                entity.Property(e => e.LocationCity)
                    .IsRequired()
                    .HasColumnName("locationCity")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationCountry)
                    .IsRequired()
                    .HasColumnName("locationCountry")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationEmail)
                    .IsRequired()
                    .HasColumnName("locationEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationFax)
                    .IsRequired()
                    .HasColumnName("locationFax")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasColumnName("locationName")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationPhoneNum)
                    .IsRequired()
                    .HasColumnName("locationPhoneNum")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationStateProvince)
                    .IsRequired()
                    .HasColumnName("locationStateProvince")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationStreetAddress)
                    .IsRequired()
                    .HasColumnName("locationStreetAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationZipCode)
                    .IsRequired()
                    .HasColumnName("locationZipCode")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MedicalProvider>(entity =>
            {
                entity.HasKey(e => e.MedProviderId);

                entity.Property(e => e.MedProviderId).HasColumnName("medProviderID");

                entity.Property(e => e.ActiveOrInactive)
                    .IsRequired()
                    .HasColumnName("activeOrInactive")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax).HasColumnName("fax");

                entity.Property(e => e.MedProviderFirstName)
                    .IsRequired()
                    .HasColumnName("medProviderFirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.MedProviderLastName)
                    .IsRequired()
                    .HasColumnName("medProviderLastName")
                    .HasMaxLength(50);

                entity.Property(e => e.MedProviderLocationId).HasColumnName("medProviderLocationID");

                entity.Property(e => e.MedProviderSpecialty)
                    .IsRequired()
                    .HasColumnName("medProviderSpecialty")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");

                entity.HasOne(d => d.MedProviderLocation)
                    .WithMany(p => p.MedicalProvider)
                    .HasForeignKey(d => d.MedProviderLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MedicalPr__medPr__5EBF139D");
            });

            modelBuilder.Entity<MedicationHistory>(entity =>
            {
                entity.HasKey(e => e.MedicationId);

                entity.Property(e => e.MedicationId).HasColumnName("medicationID");

                entity.Property(e => e.CommentsDirections)
                    .IsRequired()
                    .HasColumnName("commentsDirections")
                    .HasColumnType("text");

                entity.Property(e => e.ConditionBeingTreated)
                    .IsRequired()
                    .HasColumnName("conditionBeingTreated")
                    .HasMaxLength(50);

                entity.Property(e => e.DateStarted)
                    .HasColumnName("dateStarted")
                    .HasColumnType("date");

                entity.Property(e => e.DateStopped)
                    .HasColumnName("dateStopped")
                    .HasColumnType("date");

                entity.Property(e => e.DrugStatus)
                    .IsRequired()
                    .HasColumnName("drugStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.MedDosage)
                    .IsRequired()
                    .HasColumnName("medDosage")
                    .HasMaxLength(50);

                entity.Property(e => e.MedFrequency)
                    .IsRequired()
                    .HasColumnName("medFrequency")
                    .HasMaxLength(50);

                entity.Property(e => e.MedProviderId).HasColumnName("medProviderID");

                entity.Property(e => e.MedStrength)
                    .IsRequired()
                    .HasColumnName("medStrength")
                    .HasMaxLength(50);

                entity.Property(e => e.MedicationName)
                    .IsRequired()
                    .HasColumnName("medicationName")
                    .HasMaxLength(50);

                entity.Property(e => e.OtcDrugs)
                    .IsRequired()
                    .HasColumnName("otcDrugs")
                    .HasMaxLength(50);

                entity.Property(e => e.PharmacyNumber)
                    .IsRequired()
                    .HasColumnName("pharmacyNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.PharmacyUsed)
                    .IsRequired()
                    .HasColumnName("pharmacyUsed")
                    .HasMaxLength(50);

                entity.Property(e => e.PrescriptionNumber)
                    .IsRequired()
                    .HasColumnName("prescriptionNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Refills).HasColumnName("refills");

                entity.Property(e => e.VitaminsAndSupplements)
                    .IsRequired()
                    .HasColumnName("vitaminsAndSupplements")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MedProvider)
                    .WithMany(p => p.MedicationHistory)
                    .HasForeignKey(d => d.MedProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medicatio__medPr__619B8048");
            });

            modelBuilder.Entity<MensHealth>(entity =>
            {
                entity.HasKey(e => e.MensHealthHistoryId);

                entity.Property(e => e.MensHealthHistoryId)
                    .HasColumnName("mensHealthHistoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.DateLastAnnualPhysical)
                    .HasColumnName("dateLastAnnualPhysical")
                    .HasColumnType("date");

                entity.Property(e => e.DateLastFecalOccultTest)
                    .HasColumnName("dateLastFecalOccultTest")
                    .HasColumnType("date");

                entity.Property(e => e.DateLastProstateExam)
                    .HasColumnName("dateLastProstateExam")
                    .HasColumnType("date");

                entity.Property(e => e.DateLastPsa)
                    .HasColumnName("dateLastPSA")
                    .HasColumnType("date");

                entity.Property(e => e.DateLastSigmoidColonoscopyExam)
                    .HasColumnName("dateLastSigmoidColonoscopyExam")
                    .HasColumnType("date");

                entity.Property(e => e.DateNextAnnualPhysical)
                    .HasColumnName("dateNextAnnualPhysical")
                    .HasColumnType("date");

                entity.Property(e => e.DateNextFecalOccultTest)
                    .HasColumnName("dateNextFecalOccultTest")
                    .HasColumnType("date");

                entity.Property(e => e.DateNextProstateExam)
                    .HasColumnName("dateNextProstateExam")
                    .HasColumnType("date");

                entity.Property(e => e.DateNextPsatest)
                    .HasColumnName("dateNextPSATest")
                    .HasColumnType("date");

                entity.Property(e => e.DateNextSigmoidColonoscopy)
                    .HasColumnName("dateNextSigmoidColonoscopy")
                    .HasColumnType("date");

                entity.Property(e => e.FamilyHistoryProstateCancer)
                    .IsRequired()
                    .HasColumnName("familyHistoryProstateCancer")
                    .HasMaxLength(50);

                entity.Property(e => e.FecalOccultResults)
                    .IsRequired()
                    .HasColumnName("fecalOccultResults")
                    .HasMaxLength(50);

                entity.Property(e => e.LastProstateExamResults)
                    .IsRequired()
                    .HasColumnName("lastProstateExamResults")
                    .HasMaxLength(50);

                entity.Property(e => e.LastPsaresults)
                    .IsRequired()
                    .HasColumnName("lastPSAResults")
                    .HasMaxLength(50);

                entity.Property(e => e.MensHealthIssues)
                    .IsRequired()
                    .HasColumnName("mensHealthIssues")
                    .HasMaxLength(50);

                entity.Property(e => e.PsaLevelTestNumber).HasColumnName("psaLevelTestNumber");

                entity.Property(e => e.SigmoidColonoscopyResults)
                    .IsRequired()
                    .HasColumnName("sigmoidColonoscopyResults")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MentalHealthHistory>(entity =>
            {
                entity.Property(e => e.MentalHealthHistoryId).HasColumnName("mentalHealthHistoryID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.CurrentMedication)
                    .IsRequired()
                    .HasColumnName("currentMedication")
                    .HasMaxLength(50);

                entity.Property(e => e.CurrentTreatmentForMentalDisorder)
                    .IsRequired()
                    .HasColumnName("currentTreatmentForMentalDisorder")
                    .HasMaxLength(50);

                entity.Property(e => e.MedCareLocation)
                    .IsRequired()
                    .HasColumnName("medCareLocation")
                    .HasMaxLength(50);

                entity.Property(e => e.MedProviderId).HasColumnName("medProviderID");

                entity.Property(e => e.MentalCondDisorder)
                    .IsRequired()
                    .HasColumnName("mentalCondDisorder")
                    .HasMaxLength(50);

                entity.Property(e => e.TreatedInThePast)
                    .IsRequired()
                    .HasColumnName("treatedInThePast")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeOfTreatment)
                    .IsRequired()
                    .HasColumnName("typeOfTreatment")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MedProvider)
                    .WithMany(p => p.MentalHealthHistory)
                    .HasForeignKey(d => d.MedProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MentalHea__medPr__66603565");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.PatientId).HasColumnName("patientID");

                entity.Property(e => e.BloodType)
                    .IsRequired()
                    .HasColumnName("bloodType")
                    .HasMaxLength(3);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.Property(e => e.DoNotResuscitate)
                    .IsRequired()
                    .HasColumnName("doNotResuscitate")
                    .HasMaxLength(3);

                entity.Property(e => e.EmergencyContactInfo)
                    .IsRequired()
                    .HasColumnName("emergencyContactInfo")
                    .HasMaxLength(50);

                entity.Property(e => e.EmploymentInfo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(50);

                entity.Property(e => e.LivingWill)
                    .IsRequired()
                    .HasColumnName("livingWill")
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasColumnName("maritalStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.OrganDonor)
                    .IsRequired()
                    .HasColumnName("organDonor")
                    .HasMaxLength(3);

                entity.Property(e => e.PatientFirstName)
                    .IsRequired()
                    .HasColumnName("patientFirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientLastName)
                    .IsRequired()
                    .HasColumnName("patientLastName")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientMi)
                    .IsRequired()
                    .HasColumnName("patientMI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("phoneNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Race)
                    .IsRequired()
                    .HasColumnName("race")
                    .HasMaxLength(50);

                entity.Property(e => e.Religion)
                    .IsRequired()
                    .HasColumnName("religion")
                    .HasMaxLength(50);

                entity.Property(e => e.StateProvince)
                    .IsRequired()
                    .HasColumnName("stateProvince")
                    .HasMaxLength(50);

                entity.Property(e => e.StreetAddress)
                    .IsRequired()
                    .HasColumnName("streetAddress")
                    .HasMaxLength(100);

                entity.Property(e => e.ZipCode).HasColumnName("zipCode");
            });

            modelBuilder.Entity<SmokingHistoryRisk>(entity =>
            {
                entity.HasKey(e => e.SmokingHistRiskId);

                entity.Property(e => e.SmokingHistRiskId).HasColumnName("smokingHistRiskID");

                entity.Property(e => e.AgeQuit).HasColumnName("ageQuit");

                entity.Property(e => e.AgeStarted).HasColumnName("ageStarted");

                entity.Property(e => e.ChewingSmokelessTobacco)
                    .IsRequired()
                    .HasColumnName("chewingSmokelessTobacco")
                    .HasMaxLength(50);

                entity.Property(e => e.QuittingGoal)
                    .IsRequired()
                    .HasColumnName("quittingGoal")
                    .HasMaxLength(50);

                entity.Property(e => e.Smoker)
                    .IsRequired()
                    .HasColumnName("smoker")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Stdhistory>(entity =>
            {
                entity.ToTable("STDHistory");

                entity.Property(e => e.StdHistoryId).HasColumnName("stdHistoryID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.StdDateOfDiagnosis)
                    .HasColumnName("stdDateOfDiagnosis")
                    .HasColumnType("date");

                entity.Property(e => e.StdDateResolved)
                    .HasColumnName("stdDateResolved")
                    .HasColumnType("date");

                entity.Property(e => e.StdMedication)
                    .IsRequired()
                    .HasColumnName("stdMedication")
                    .HasMaxLength(50);

                entity.Property(e => e.StdStatus)
                    .IsRequired()
                    .HasColumnName("stdStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.StdType)
                    .IsRequired()
                    .HasColumnName("stdType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SurgicalHistory>(entity =>
            {
                entity.HasKey(e => e.SurgeryHistoryId);

                entity.Property(e => e.SurgeryHistoryId).HasColumnName("surgeryHistoryID");

                entity.Property(e => e.AnesthesiaProblemExplanation)
                    .IsRequired()
                    .HasColumnName("anesthesiaProblemExplanation")
                    .HasMaxLength(50);

                entity.Property(e => e.DateOfSurgeryProcedure)
                    .HasColumnName("dateOfSurgeryProcedure")
                    .HasColumnType("date");

                entity.Property(e => e.MedCareLocationId).HasColumnName("medCareLocationID");

                entity.Property(e => e.MedProviderId).HasColumnName("medProviderID");

                entity.Property(e => e.ProblemWithAnesthesia)
                    .IsRequired()
                    .HasColumnName("problemWithAnesthesia")
                    .HasMaxLength(50);

                entity.Property(e => e.SurgeryProcedure)
                    .IsRequired()
                    .HasColumnName("surgeryProcedure")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MedCareLocation)
                    .WithMany(p => p.SurgicalHistory)
                    .HasForeignKey(d => d.MedCareLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SurgicalH__medCa__6EF57B66");

                entity.HasOne(d => d.MedProvider)
                    .WithMany(p => p.SurgicalHistory)
                    .HasForeignKey(d => d.MedProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SurgicalH__medPr__6FE99F9F");
            });

            modelBuilder.Entity<TestsExams>(entity =>
            {
                entity.HasKey(e => e.TestExamId);

                entity.Property(e => e.TestExamId).HasColumnName("testExamID");

                entity.Property(e => e.DateOfTestExam)
                    .HasColumnName("dateOfTestExam")
                    .HasColumnType("date");

                entity.Property(e => e.MedCareLocationId).HasColumnName("medCareLocationID");

                entity.Property(e => e.ReaonForTestExam)
                    .IsRequired()
                    .HasColumnName("reaonForTestExam")
                    .HasMaxLength(50);

                entity.Property(e => e.TestExamResult)
                    .IsRequired()
                    .HasColumnName("testExamResult")
                    .HasMaxLength(50);

                entity.Property(e => e.TestExamType)
                    .IsRequired()
                    .HasColumnName("testExamType")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MedCareLocation)
                    .WithMany(p => p.TestsExams)
                    .HasForeignKey(d => d.MedCareLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TestsExam__medCa__72C60C4A");
            });

            modelBuilder.Entity<TravelHealth>(entity =>
            {
                entity.Property(e => e.TravelHealthId).HasColumnName("travelHealthID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.CountryVisited)
                    .IsRequired()
                    .HasColumnName("countryVisited")
                    .HasMaxLength(50);

                entity.Property(e => e.DateContracted)
                    .HasColumnName("dateContracted")
                    .HasColumnType("date");

                entity.Property(e => e.DateVisited)
                    .HasColumnName("dateVisited")
                    .HasColumnType("date");

                entity.Property(e => e.DiseaseIllnessContracted)
                    .IsRequired()
                    .HasColumnName("diseaseIllnessContracted")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("emailAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.RelationshipToPatient)
                    .IsRequired()
                    .HasColumnName("relationshipToPatient")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFirstName)
                    .IsRequired()
                    .HasColumnName("userFirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.UserLastName)
                    .IsRequired()
                    .HasColumnName("userLastName")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WeightAndMeasurementRisk>(entity =>
            {
                entity.HasKey(e => e.WeightMeasurementRiskId);

                entity.Property(e => e.WeightMeasurementRiskId).HasColumnName("weightMeasurementRiskID");

                entity.Property(e => e.Bmi).HasColumnName("bmi");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text");

                entity.Property(e => e.CurrentWaistSize).HasColumnName("currentWaistSize");

                entity.Property(e => e.DateTaken)
                    .HasColumnName("dateTaken")
                    .HasColumnType("date");

                entity.Property(e => e.Height)
                    .IsRequired()
                    .HasColumnName("height")
                    .HasMaxLength(50);

                entity.Property(e => e.WaistSizeGoal).HasColumnName("waistSizeGoal");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.WeightGoal).HasColumnName("weightGoal");
            });

            modelBuilder.Entity<WomensHealthHistory>(entity =>
            {
                entity.Property(e => e.WomensHealthHistoryId).HasColumnName("womensHealthHistoryID");

                entity.Property(e => e.AgePeriodsStarted).HasColumnName("agePeriodsStarted");

                entity.Property(e => e.BirthControlMethod)
                    .IsRequired()
                    .HasColumnName("birthControlMethod")
                    .HasMaxLength(50);

                entity.Property(e => e.DateLastClinicialBreastExam)
                    .HasColumnName("dateLastClinicialBreastExam")
                    .HasColumnType("date");

                entity.Property(e => e.DateLastMammogram)
                    .HasColumnName("dateLastMammogram")
                    .HasColumnType("date");

                entity.Property(e => e.DateLastPapExam)
                    .HasColumnName("dateLastPapExam")
                    .HasColumnType("date");

                entity.Property(e => e.DateNextBreastExam)
                    .HasColumnName("dateNextBreastExam")
                    .HasColumnType("date");

                entity.Property(e => e.DateNextMammogram)
                    .HasColumnName("dateNextMammogram")
                    .HasColumnType("date");

                entity.Property(e => e.DateNextPapExam)
                    .HasColumnName("dateNextPapExam")
                    .HasColumnType("date");

                entity.Property(e => e.DateOfDiagnosis)
                    .HasColumnName("dateOfDiagnosis")
                    .HasColumnType("date");

                entity.Property(e => e.DateOfSurgeryProcedure)
                    .HasColumnName("dateOfSurgeryProcedure")
                    .HasColumnType("date");

                entity.Property(e => e.DateResolved)
                    .HasColumnName("dateResolved")
                    .HasColumnType("date");

                entity.Property(e => e.HormoneReplacementTherapy)
                    .IsRequired()
                    .HasColumnName("hormoneReplacementTherapy")
                    .HasMaxLength(50);

                entity.Property(e => e.HrtDateStarted)
                    .HasColumnName("hrtDateStarted")
                    .HasColumnType("date");

                entity.Property(e => e.HrtDateStopped)
                    .HasColumnName("hrtDateStopped")
                    .HasColumnType("date");

                entity.Property(e => e.MedCareLocationId).HasColumnName("medCareLocationID");

                entity.Property(e => e.MedCareProviderId).HasColumnName("medCareProviderID");

                entity.Property(e => e.NumOfCsections).HasColumnName("numOfCSections");

                entity.Property(e => e.NumOfElectiveAbortions).HasColumnName("numOfElectiveAbortions");

                entity.Property(e => e.NumOfLiveBirths).HasColumnName("numOfLiveBirths");

                entity.Property(e => e.NumOfMiscarriages).HasColumnName("numOfMiscarriages");

                entity.Property(e => e.NumOfPregnancies).HasColumnName("numOfPregnancies");

                entity.Property(e => e.NumOfPrematureBirths).HasColumnName("numOfPrematureBirths");

                entity.Property(e => e.NumOfStillBirths).HasColumnName("numOfStillBirths");

                entity.Property(e => e.PeriodFlow)
                    .IsRequired()
                    .HasColumnName("periodFlow")
                    .HasMaxLength(50);

                entity.Property(e => e.PeriodProblems)
                    .IsRequired()
                    .HasColumnName("periodProblems")
                    .HasMaxLength(50);

                entity.Property(e => e.PeriodsRegular)
                    .IsRequired()
                    .HasColumnName("periodsRegular")
                    .HasMaxLength(50);

                entity.Property(e => e.PregnancyComplications)
                    .IsRequired()
                    .HasColumnName("pregnancyComplications")
                    .HasColumnType("text");

                entity.Property(e => e.ResultsLastBreastExam)
                    .IsRequired()
                    .HasColumnName("resultsLastBreastExam")
                    .HasMaxLength(50);

                entity.Property(e => e.ResultsLastMammogram)
                    .IsRequired()
                    .HasColumnName("resultsLastMammogram")
                    .HasMaxLength(50);

                entity.Property(e => e.ResultsLastPapExam)
                    .IsRequired()
                    .HasColumnName("resultsLastPapExam")
                    .HasMaxLength(50);

                entity.Property(e => e.StillHavingPeriods)
                    .IsRequired()
                    .HasColumnName("stillHavingPeriods")
                    .HasMaxLength(50);

                entity.Property(e => e.WomensDiseaseDisorder)
                    .IsRequired()
                    .HasColumnName("womensDiseaseDisorder")
                    .HasMaxLength(50);

                entity.Property(e => e.WomensDiseaseDisorderStatus)
                    .IsRequired()
                    .HasColumnName("womensDiseaseDisorderStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.WomensHealthSurgeryProcedure)
                    .IsRequired()
                    .HasColumnName("womensHealthSurgeryProcedure")
                    .HasMaxLength(50);

                entity.HasOne(d => d.MedCareLocation)
                    .WithMany(p => p.WomensHealthHistory)
                    .HasForeignKey(d => d.MedCareLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WomensHea__medCa__7B5B524B");

                entity.HasOne(d => d.MedCareProvider)
                    .WithMany(p => p.WomensHealthHistory)
                    .HasForeignKey(d => d.MedCareProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WomensHea__medCa__7C4F7684");
            });
        }
    }
}
