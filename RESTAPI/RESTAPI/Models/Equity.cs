using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class Equity
    {
        public int SecId { get; set; }
        public string SecurityName { get; set; } = null!;
        public string? SecurityDescription { get; set; }
        public bool? HasPosition { get; set; }
        public bool? IsActive { get; set; }
        public int? RoundLotSize { get; set; }
        public string BbguniqueName { get; set; } = null!;
        public string? Cusip { get; set; }
        public string? Isin { get; set; }
        public string? Sedol { get; set; }
        public string? Bbgticker { get; set; }
        public string? BbguniqueId { get; set; }
        public string? BbgglobalId { get; set; }
        public string? TickerExchange { get; set; }
        public bool? IsAdrflag { get; set; }
        public string? AdrunderlyingTicker { get; set; }
        public string? AdrunderlyingCurrency { get; set; }
        public float? SharesPerAdr { get; set; }
        public DateTime? Ipodate { get; set; }
        public string? PriceCurrency { get; set; }
        public int? SettleDays { get; set; }
        public double? SharesOutstanding { get; set; }
        public float? VotingRightsPerShare { get; set; }
        public double? TwentyDaverageVolume { get; set; }
        public double? Beta { get; set; }
        public double? ShortInterest { get; set; }
        public double? Ytdreturn { get; set; }
        public double? NinetyDpriceVolatility { get; set; }
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
        public double? OpenPrice { get; set; }
        public double? ClosePrice { get; set; }
        public double? Volume { get; set; }
        public double? LastPrice { get; set; }
        public double? AskPrice { get; set; }
        public double? BidPrice { get; set; }
        public double? Peratio { get; set; }
        public DateTime? DeclaredDate { get; set; }
        public DateTime? ExDate { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? PayDate { get; set; }
        public double? Amount { get; set; }
        public int? Frequency { get; set; }
        public string? DividendType { get; set; }
    }
}
