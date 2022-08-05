using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class PutSchedule
    {
        public int Sid { get; set; }
        public DateTime? PutDate { get; set; }
        public double? PutPrice { get; set; }

        public virtual SecuritySummary SidNavigation { get; set; } = null!;
    }
}
