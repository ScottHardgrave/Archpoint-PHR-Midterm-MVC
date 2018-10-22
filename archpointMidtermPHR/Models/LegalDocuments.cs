using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class LegalDocuments
    {
        public int LegalDocId { get; set; }

        [Display(Name = "Living Will Set Up?")]
        [DataType(DataType.Text)]
        public string LivingWill { get; set; }

        [Display(Name = "Date signed:")]
        [DataType(DataType.Date)]
        public DateTime LivingWillDateSigned { get; set; }

        [Display(Name = "Last updated:")]
        [DataType(DataType.Date)]
        public DateTime LivingWillLastUpdated { get; set; }

        [Display(Name = "Do you have a copy on file?")]
        [DataType(DataType.Text)]
        public string LivingWillCopyOnFile { get; set; }

        [Display(Name = "Is your family aware of the will's instructions?")]
        [DataType(DataType.Text)]
        public string FamilyAwareOfInstructions { get; set; }

        [Display(Name = "Do you have a Medical Power Of Attorney?")]
        [DataType(DataType.Text)]
        public string MedicalPowerOfAttorney { get; set; }

        [Display(Name = "Power Of Attorney Name")]
        [DataType(DataType.Text)]
        public string MedPowerOfAttorneyName { get; set; }

        [Display(Name = "Date attorney signed")]
        [DataType(DataType.Date)]
        public string MedPowerOfAttorneyDateSigned { get; set; }

        [Display(Name = "Medical Power Of Attorney Last updated?")]
        [DataType(DataType.Text)]
        public string MedPowerOfAttorneyDateLastUpdated { get; set; }

        [Display(Name = "Do you have a copy of the medical power of attorney on file?")]
        [DataType(DataType.Text)]
        public string MedPowerOfAttorneyCopyOnFile { get; set; }

        [Display(Name = "Health Care Proxy?")]
        [DataType(DataType.Text)]
        public string HealthCareProxy { get; set; }

        [Display(Name = "Health Care Proxy Name")]
        [DataType(DataType.Text)]
        public string HealthCareProxyName { get; set; }

        [Display(Name = "Date health care proxy signed")]
        [DataType(DataType.Date)]
        public DateTime HealthCareProxyDateSigned { get; set; }

        [Display(Name = "Date health care proxy last updated")]
        [DataType(DataType.Date)]
        public DateTime HealtchCareProxyDateLastUpdated { get; set; }

        [Display(Name = "Do Not Resuscitate Order?")]
        [DataType(DataType.Text)]
        public string DoNotResuscitateOrder { get; set; }

        [Display(Name = "DNR date signed")]
        [DataType(DataType.Date)]
        public DateTime DnrDateSigned { get; set; }

        [Display(Name = "DNR date last updated")]
        [DataType(DataType.Date)]
        public DateTime DnrDateLastUpdated { get; set; }

        [Display(Name = "Organ Donor?")]
        [DataType(DataType.Text)]
        public string OrganDonorDocument { get; set; }

        [Display(Name = "Organ Donor date signed")]
        [DataType(DataType.Date)]
        public DateTime OrganDonorDateSigned { get; set; }

        [Display(Name = "Organ Donor Last Updated")]
        [DataType(DataType.Date)]
        public DateTime OrganDonorLastUpdate { get; set; }

        [Display(Name = "Documents location")]
        [DataType(DataType.Text)]
        public string DocumentsLocation { get; set; }

        [Display(Name = "Document Contacts First Name")]
        [DataType(DataType.Text)]
        public string DocumentContactsFirstName { get; set; }

        [Display(Name = "Document Contacts Last name")]
        [DataType(DataType.Text)]
        public string DocumentContactsLastName { get; set; }

        [Display(Name = "Document Contacts Phone #")]
        [DataType(DataType.Text)]
        public string DocumentContactsPhone { get; set; }

        [Display(Name = "Attorney First Name")]
        [DataType(DataType.Text)]
        public string AttorneyFirstName { get; set; }

        [Display(Name = "Attorney Last Name")]
        [DataType(DataType.Text)]
        public string AttorneyLastName { get; set; }

        [Display(Name = "Attorney hone #")]
        [DataType(DataType.Text)]
        public string AttorneyPhone { get; set; }


        public string Comments { get; set; }
    }
}
