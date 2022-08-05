using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class DividendHistory
    {
        public int Sid { get; set; }
        public DateTime? DeclaredDate { get; set; }
        public DateTime? ExDate { get; set; }
        public DateTime? RecordDate { get; set; }
        public DateTime? PayDate { get; set; }
        public double? Amount { get; set; }
        public int? Frequency { get; set; }
        public string? DividendType { get; set; }

        public virtual SecuritySummary1 SidNavigation { get; set; } = null!;
    }
}
