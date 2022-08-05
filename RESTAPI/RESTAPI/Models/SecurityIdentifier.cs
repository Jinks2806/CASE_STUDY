using System;
using System.Collections.Generic;

namespace RESTAPI.Models
{
    public partial class SecurityIdentifier
    {
        public int Sid { get; set; }
        public string? Isin { get; set; }
        public string? Bbgticker { get; set; }
        public string? BbguniqueId { get; set; }
        public string? Cusip { get; set; }
        public string? Sedol { get; set; }

        public virtual SecuritySummary SidNavigation { get; set; } = null!;
    }
}
