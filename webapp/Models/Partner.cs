using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class Partner
{
    public int PartnerId { get; set; }

    public string Emri { get; set; } = null!;

    public string Pershkrimi { get; set; } = null!;

    public virtual ICollection<Knowledge> Knowledges { get; set; } = new List<Knowledge>();
}
