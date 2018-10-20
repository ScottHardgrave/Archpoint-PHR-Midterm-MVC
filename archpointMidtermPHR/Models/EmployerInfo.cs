using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace archpointMidtermPHR.Models
{
    public partial class EmployerInfo
    {
        public int EmployerId { get; set; }

        [Display(Name = "Employer Name")]
        [DataType(DataType.Text)]
        public string EmployerName { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.Text)]
        public string EmployerAddress { get; set; }

        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string EmployerCity { get; set; }

        [Display(Name = "State/Province")]
        [DataType(DataType.Text)]
        public string EmployerStateProvince { get; set; }


        [Display(Name = "Zip Code")]
        [DataType(DataType.Text)]
        public string EmployerZip { get; set; }

        [Display(Name = "Phone #")]
        [DataType(DataType.Text)]
        public string EmployerPhone { get; set; }
    }
}
