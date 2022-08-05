using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class RegulatoryDetail
    {
        public int Sid { get; set; }
        public string? PfassetClasses { get; set; }
        public string? Pfcountry { get; set; }
        public string? PfcreditRating { get; set; }
        public string? Pfcurrency { get; set; }
        public string? Pfinstrument { get; set; }
        public string? PfliquidityProfile { get; set; }
        public string? Pfmaturity { get; set; }
        public string? Pfnaicscode { get; set; }
        public string? Pfregion { get; set; }
        public string? Pfsector { get; set; }
        public string? PfsubAssetClass { get; set; }

        public virtual SecuritySummary SidNavigation { get; set; } = null!;
    }
}
