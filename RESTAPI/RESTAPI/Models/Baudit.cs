using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class Baudit
    {
        public string? Username { get; set; }
        public DateTime? XnDate { get; set; }
        public string? XnType { get; set; }
        public int? BsecId { get; set; }
        public string? BsecName { get; set; }
        public string? OldSecDesc { get; set; }
        public string? NewSecDesc { get; set; }
        public double? OldCouponRate { get; set; }
        public double? NewCouponRate { get; set; }
        public bool? OldCallable { get; set; }
        public bool? NewCallable { get; set; }
        public DateTime? OldPenUltimateCouponDate { get; set; }
        public DateTime? NewPenUltimateCouponDate { get; set; }
        public string? OldPfcreditRating { get; set; }
        public string? NewPfcreditRating { get; set; }
        public double? OldAskPrice { get; set; }
        public double? NewAskPrice { get; set; }
    }
}
