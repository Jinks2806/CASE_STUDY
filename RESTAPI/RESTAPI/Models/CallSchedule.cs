using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class CallSchedule
    {
        public int Sid { get; set; }
        public DateTime? CallDate { get; set; }
        public double? CallPrice { get; set; }

        public virtual SecuritySummary SidNavigation { get; set; } = null!;
    }
}
