using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class LegalDocuments
    {
        public int LegalDocId { get; set; }
        public string LivingWill { get; set; }
        public DateTime LivingWillDateSigned { get; set; }
        public DateTime LivingWillLastUpdated { get; set; }
        public string LivingWillCopyOnFile { get; set; }
        public string FamilyAwareOfInstructions { get; set; }
        public string MedicalPowerOfAttorney { get; set; }
        public string MedPowerOfAttorneyName { get; set; }
        public string MedPowerOfAttorneyDateSigned { get; set; }
        public string MedPowerOfAttorneyDateLastUpdated { get; set; }
        public string MedPowerOfAttorneyCopyOnFile { get; set; }
        public string HealthCareProxy { get; set; }
        public string HealthCareProxyName { get; set; }
        public DateTime HealthCareProxyDateSigned { get; set; }
        public DateTime HealtchCareProxyDateLastUpdated { get; set; }
        public string DoNotResuscitateOrder { get; set; }
        public DateTime DnrDateSigned { get; set; }
        public DateTime DnrDateLastUpdated { get; set; }
        public string OrganDonorDocument { get; set; }
        public DateTime OrganDonorDateSigned { get; set; }
        public DateTime OrganDonorLastUpdate { get; set; }
        public string DocumentsLocation { get; set; }
        public string DocumentContactsFirstName { get; set; }
        public string DocumentContactsLastName { get; set; }
        public string DocumentContactsPhone { get; set; }
        public string AttorneyFirstName { get; set; }
        public string AttorneyLastName { get; set; }
        public string AttorneyPhone { get; set; }
        public string Comments { get; set; }
    }
}
