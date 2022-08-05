using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class ReferenceDatum1
    {
        public int Sid { get; set; }
        public string? IssueCountry { get; set; }
        public string? Exchange { get; set; }
        public string? Issuer { get; set; }
        public string? IssueCurrency { get; set; }
        public string? TradingCurrency { get; set; }
        public string? BbgindustrySubGroup { get; set; }
        public string? BbgindustryGroup { get; set; }
        public string? BbgindustrySector { get; set; }
        public string? IncorporationCountry { get; set; }
        public string? RiskCurrency { get; set; }

        public virtual SecuritySummary1 SidNavigation { get; set; } = null!;
    }
}
