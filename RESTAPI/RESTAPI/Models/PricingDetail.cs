using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class PricingDetail
    {
        public int Sid { get; set; }
        public double? OpenPrice { get; set; }
        public double? ClosePrice { get; set; }
        public double? Volume { get; set; }
        public double? LastPrice { get; set; }
        public double? AskPrice { get; set; }
        public double? BidPrice { get; set; }
        public double? Peratio { get; set; }

        public virtual SecuritySummary1 SidNavigation { get; set; } = null!;
    }
}
