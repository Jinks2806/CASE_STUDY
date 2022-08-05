using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class SecuritySummary1
    {
        public int SecId { get; set; }
        public string SecurityName { get; set; } = null!;
        public string? SecurityDescription { get; set; }
        public bool? HasPosition { get; set; }
        public bool? IsActive { get; set; }
        public int? RoundLotSize { get; set; }
        public string BbguniqueName { get; set; } = null!;

        public virtual DividendHistory DividendHistory { get; set; } = null!;
        public virtual PricingDetail PricingDetail { get; set; } = null!;
        public virtual ReferenceDatum1 ReferenceDatum1 { get; set; } = null!;
        public virtual RegulatoryDetail1 RegulatoryDetail1 { get; set; } = null!;
        public virtual Risk1 Risk1 { get; set; } = null!;
        public virtual SecurityDetail1 SecurityDetail1 { get; set; } = null!;
        public virtual SecurityIdentifier1 SecurityIdentifier1 { get; set; } = null!;
    }
}
