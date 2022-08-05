using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class VuEquityInfo
    {
        public int SecId { get; set; }
        public string? SecurityDescription { get; set; }
        public bool? IsActive { get; set; }
        public string? PriceCurrency { get; set; }
        public double? SharesOutstanding { get; set; }
        public double? OpenPrice { get; set; }
        public double? ClosePrice { get; set; }
        public DateTime? DeclaredDate { get; set; }
        public string? PfcreditRating { get; set; }
    }
}
