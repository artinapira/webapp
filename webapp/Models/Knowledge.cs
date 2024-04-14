using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class Knowledge
{
    public int KnowledgeId { get; set; }

    public string Pershkrimi { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();

    public virtual ICollection<Stafi> Stafis { get; set; } = new List<Stafi>();
}
