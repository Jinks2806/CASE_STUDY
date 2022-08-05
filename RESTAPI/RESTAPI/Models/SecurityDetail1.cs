using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class SecurityDetail1
    {
        public int Sid { get; set; }
        public bool? IsAdrflag { get; set; }
        public string? AdrunderlyingTicker { get; set; }
        public string? AdrunderlyingCurrency { get; set; }
        public float? SharesPerAdr { get; set; }
        public DateTime? Ipodate { get; set; }
        public string? PriceCurrency { get; set; }
        public int? SettleDays { get; set; }
        public double? SharesOutstanding { get; set; }
        public float? VotingRightsPerShare { get; set; }

        public virtual SecuritySummary1 SidNavigation { get; set; } = null!;
    }
}
