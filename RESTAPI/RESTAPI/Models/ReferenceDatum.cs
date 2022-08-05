using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class ReferenceDatum
    {
        public int Sid { get; set; }
        public string? BbgindustryGroup { get; set; }
        public string? BbgindustrySubGroup { get; set; }
        public string? Bbgsector { get; set; }
        public string? IssueCountry { get; set; }
        public string? IssueCurrency { get; set; }
        public string? Issuer { get; set; }
        public string? RiskCurrency { get; set; }

        public virtual SecuritySummary SidNavigation { get; set; } = null!;
    }
}
