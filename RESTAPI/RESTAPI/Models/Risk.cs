using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class Risk
    {
        public int Sid { get; set; }
        public double? Duration { get; set; }
        public double? ThirtyDvolatility { get; set; }
        public double? NinetyDvolatility { get; set; }
        public double? Convexity { get; set; }
        public double? ThirtyDaverageVolume { get; set; }

        public virtual SecuritySummary SidNavigation { get; set; } = null!;
    }
}
