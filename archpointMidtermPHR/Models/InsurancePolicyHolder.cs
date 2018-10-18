using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class InsurancePolicyHolder
    {
        public int PolicyHolderId { get; set; }
        public string PolicyHolderFirstName { get; set; }
        public string PolicyHolderMidInit { get; set; }
        public string PolicyHolderLastName { get; set; }
        public string RealtionshipToPolicyHolder { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PolicyHolderSsn { get; set; }
    }
}
