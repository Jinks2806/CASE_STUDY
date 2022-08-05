using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class Risk1
    {
        public int Sid { get; set; }
        public double? TwentyDaverageVolume { get; set; }
        public double? Beta { get; set; }
        public double? ShortInterest { get; set; }
        public double? Ytdreturn { get; set; }
        public double? NinetyDpriceVolatility { get; set; }

        public virtual SecuritySummary1 SidNavigation { get; set; } = null!;
    }
}
