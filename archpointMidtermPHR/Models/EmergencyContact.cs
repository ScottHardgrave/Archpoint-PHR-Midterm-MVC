using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class EmergencyContact
    {
        public int EmergencyContactId { get; set; }
        public string PrimaryOrSecondaryContact { get; set; }
        public string EmerContactFirstName { get; set; }
        public string EmerContactLastName { get; set; }
        public string RelationshipToPatient { get; set; }
        public string EmerContactDayPhone { get; set; }
        public string EmerContactEveningPhone { get; set; }
        public string EmerContactCellPhone { get; set; }
        public string EmerContactEmail { get; set; }
        public string EmerContactStreetAddress { get; set; }
        public string EmerContactCity { get; set; }
        public string EmerContactStateProvince { get; set; }
        public string EmerContactZip { get; set; }
        public string EmerContactCountry { get; set; }
    }
}
