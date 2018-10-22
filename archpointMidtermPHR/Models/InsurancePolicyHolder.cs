using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class InsurancePolicyHolder
    {
        public int PolicyHolderId { get; set; }

        [Display(Name = "Policy Holder First Name")]
        [DataType(DataType.Text)]
        public string PolicyHolderFirstName { get; set; }

        [Display(Name = "Policy Holder Middle Initial")]
        [DataType(DataType.Text)]
        public string PolicyHolderMidInit { get; set; }

        [Display(Name = "Policy Holder last name")]
        [DataType(DataType.Text)]
        public string PolicyHolderLastName { get; set; }

        [Display(Name = "Relationship To Policy holder")]
        [DataType(DataType.Text)]
        public string RealtionshipToPolicyHolder { get; set; }

        [Display(Name = "Policy Holder D.O.B.")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Policy Holder SSN")]
        [DataType(DataType.Text)]
        public int PolicyHolderSsn { get; set; }
    }
}
