using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class EmergencyContact
    {
        public int EmergencyContactId { get; set; }

        [Display(Name = "Is this contact a primary or secondary contact?")]
        [DataType(DataType.Text)]
        public string PrimaryOrSecondaryContact { get; set; }

        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string EmerContactFirstName { get; set; }

        [Display(Name = "Last name")]
        [DataType(DataType.Text)]
        public string EmerContactLastName { get; set; }

        [Display(Name = "Been")]
        [DataType(DataType.Text)]
        public string RelationshipToPatient { get; set; }

        [Display(Name = "Day Phone #")]
        [DataType(DataType.Text)]
        public string EmerContactDayPhone { get; set; }

        [Display(Name = "Evening Phone #")]
        [DataType(DataType.Text)]
        public string EmerContactEveningPhone { get; set; }

        [Display(Name = "Cell #")]
        [DataType(DataType.Text)]
        public string EmerContactCellPhone { get; set; }

        [Display(Name = "email")]
        [DataType(DataType.Text)]
        public string EmerContactEmail { get; set; }

        [Display(Name = "Street Address")]
        [DataType(DataType.Text)]
        public string EmerContactStreetAddress { get; set; }

        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string EmerContactCity { get; set; }

        [Display(Name = "State/Province")]
        [DataType(DataType.Text)]
        public string EmerContactStateProvince { get; set; }

        [Display(Name = "Zip Code")]
        [DataType(DataType.Text)]
        public string EmerContactZip { get; set; }

        [Display(Name = "Country")]
        [DataType(DataType.Text)]
        public string EmerContactCountry { get; set; }
    }
}
