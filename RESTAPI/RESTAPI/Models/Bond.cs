using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class Bond
    {
        public int SecId { get; set; }
        public string SecurityName { get; set; } = null!;
        public string? SecurityDescription { get; set; }
        public string? AssestType { get; set; }
        public string? InvestmentType { get; set; }
        public double? TradingFactor { get; set; }
        public double? PricingFactor { get; set; }
        public string? Isin { get; set; }
        public string? Cusip { get; set; }
        public string? Sedol { get; set; }
        public string? Bbgticker { get; set; }
        public string? BbguniqueId { get; set; }
        public DateTime? FirstCouponDate { get; set; }
        public string? CouponCap { get; set; }
        public string? CouponFloor { get; set; }
        public int? CouponFrequency { get; set; }
        public double? CouponRate { get; set; }
        public string? CouponType { get; set; }
        public string? FloatSpread { get; set; }
        public bool? IsCallable { get; set; }
        public bool? IsFixToFloat { get; set; }
        public bool? IsPutable { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? LastResetDate { get; set; }
        public DateTime? MaturityDate { get; set; }
        public int? MaxCallNoticeD { get; set; }
        public int? MaxPutNoticeD { get; set; }
        public DateTime? PenUltimateCouponDate { get; set; }
        public int? ResetFrequency { get; set; }
        public bool? HasPosition { get; set; }
        public double? Duration { get; set; }
        public double? ThirtyDvolatility { get; set; }
        public double? NinetyDvolatility { get; set; }
        public double? ThirtyDaverageVolume { get; set; }
        public double? Convexity { get; set; }
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
        public string? BbgindustryGroup { get; set; }
        public string? BbgindustrySubGroup { get; set; }
        public string? Bbgsector { get; set; }
        public string? IssueCountry { get; set; }
        public string? IssueCurrency { get; set; }
        public string? Issuer { get; set; }
        public string? RiskCurrency { get; set; }
        public DateTime? PutDate { get; set; }
        public double? PutPrice { get; set; }
        public double? AskPrice { get; set; }
        public double? HighPrice { get; set; }
        public double? LowPrice { get; set; }
        public double? OpenPrice { get; set; }
        public double? Volume { get; set; }
        public double? BidPrice { get; set; }
        public double? LastPrice { get; set; }
        public DateTime? CallDate { get; set; }
        public double? CallPrice { get; set; }
        public int? IsActive { get; set; }
    }
}
