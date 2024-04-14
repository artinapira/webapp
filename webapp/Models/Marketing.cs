using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class Marketing
{
    public int MarketingId { get; set; }

    public byte[]? Img { get; set; }

    public string Pershkrimi { get; set; } = null!;

    public virtual ICollection<SherbimiShtese> Sherbimis { get; set; } = new List<SherbimiShtese>();

    public virtual ICollection<Stafi> Stafis { get; set; } = new List<Stafi>();
}
