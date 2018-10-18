using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string RelationshipToPatient { get; set; }
    }
}
