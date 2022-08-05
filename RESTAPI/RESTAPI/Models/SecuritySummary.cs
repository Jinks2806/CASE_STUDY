using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class SecuritySummary
    {
        public int SecId { get; set; }
        public string SecurityName { get; set; } = null!;
        public string? SecurityDescription { get; set; }
        public string? AssestType { get; set; }
        public string? InvestmentType { get; set; }
        public double? TradingFactor { get; set; }
        public double? PricingFactor { get; set; }

        public virtual CallSchedule CallSchedule { get; set; } = null!;
        public virtual PricingAnalytic PricingAnalytic { get; set; } = null!;
        public virtual PutSchedule PutSchedule { get; set; } = null!;
        public virtual ReferenceDatum ReferenceDatum { get; set; } = null!;
        public virtual RegulatoryDetail RegulatoryDetail { get; set; } = null!;
        public virtual Risk Risk { get; set; } = null!;
        public virtual SecurityDetail SecurityDetail { get; set; } = null!;
        public virtual SecurityIdentifier SecurityIdentifier { get; set; } = null!;
    }
}
