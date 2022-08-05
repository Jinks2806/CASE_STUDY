using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class SecurityDetail
    {
        public int Sid { get; set; }
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

        public virtual SecuritySummary SidNavigation { get; set; } = null!;
    }
}
