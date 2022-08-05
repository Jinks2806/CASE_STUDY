using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class Eaudit
    {
        public string? Username { get; set; }
        public DateTime? XnDate { get; set; }
        public string? XnType { get; set; }
        public int? EsecId { get; set; }
        public string? EsecName { get; set; }
        public string? OldSecDesc { get; set; }
        public string? NewSecDesc { get; set; }
        public string? OldPriceCurr { get; set; }
        public string? NewPriceCurr { get; set; }
        public double? OldOpenPrice { get; set; }
        public double? NewOpenPrice { get; set; }
        public double? OldClosePrice { get; set; }
        public double? NewClosePrice { get; set; }
        public DateTime? OldDivDecDate { get; set; }
        public DateTime? NewDivDecDate { get; set; }
        public string? OldPfcr { get; set; }
        public string? NewPfcr { get; set; }
    }
}
