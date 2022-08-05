using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class PricingAnalytic
    {
        public int Sid { get; set; }
        public double? AskPrice { get; set; }
        public double? HighPrice { get; set; }
        public double? LowPrice { get; set; }
        public double? OpenPrice { get; set; }
        public double? Volume { get; set; }
        public double? BidPrice { get; set; }
        public double? LastPrice { get; set; }

        public virtual SecuritySummary SidNavigation { get; set; } = null!;
    }
}
