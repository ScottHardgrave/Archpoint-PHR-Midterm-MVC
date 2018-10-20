using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class User
    {
        public int UserId { get; set; }

        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string UserFirstName { get; set; }

        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string UserLastName { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Text)]
        public string Password { get; set; }

        [Display(Name = "email address")]
        [DataType(DataType.Text)]
        public string EmailAddress { get; set; }

        [Display(Name = "Username")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Display(Name = "Relationship To Patient")]
        [DataType(DataType.Text)]
        public string RelationshipToPatient { get; set; }
    }
}
