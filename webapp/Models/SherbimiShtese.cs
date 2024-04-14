using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class SherbimiShtese
{
    public int SherbimiId { get; set; }

    public string Emri { get; set; } = null!;

    public string Pershkrimi { get; set; } = null!;

    public decimal? Cmimi { get; set; }

    public virtual ICollection<Marketing> Marketings { get; set; } = new List<Marketing>();
}
