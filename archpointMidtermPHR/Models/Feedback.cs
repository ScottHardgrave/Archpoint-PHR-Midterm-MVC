using System;
using System.Collections.Generic;

namespace archpointMidtermPHR.Models
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public string HowArchpointWasFound { get; set; }
        public string EasyToUnderstand { get; set; }
        public string SuggestionsForImprovements { get; set; }
    }
}
