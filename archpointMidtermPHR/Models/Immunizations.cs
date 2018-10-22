using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class Immunizations
    {
        public int ImmunizationId { get; set; }

        [Display(Name = "Type of immunization?")]
        [DataType(DataType.Text)]
        public string ImmunizationType { get; set; }

        [Display(Name = "Date received:")]
        [DataType(DataType.Date)]
        public DateTime DateReceived { get; set; }

        [Display(Name = "Admministering Medical Provider:")]
        [DataType(DataType.Text)]
        public string AdministeredBy { get; set; }

        [Display(Name = "Date of last tetanus shot")]
        [DataType(DataType.Text)]
        public DateTime DateLastTetanus { get; set; }
        public string Comments { get; set; }
    }
}
