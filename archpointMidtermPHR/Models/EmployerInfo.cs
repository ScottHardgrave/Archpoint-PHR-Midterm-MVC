using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class EmployerInfo
    {
        public int EmployerId { get; set; }
        public string EmployerName { get; set; }
        public string EmployerAddress { get; set; }
        public string EmployerCity { get; set; }
        public string EmployerStateProvince { get; set; }
        public string EmployerZip { get; set; }
        public string EmployerPhone { get; set; }
    }
}
