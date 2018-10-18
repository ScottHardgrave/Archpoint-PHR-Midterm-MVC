using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class Immunizations
    {
        public int ImmunizationId { get; set; }
        public string ImmunizationType { get; set; }
        public DateTime DateReceived { get; set; }
        public string AdministeredBy { get; set; }
        public DateTime DateLastTetanus { get; set; }
        public string Comments { get; set; }
    }
}
