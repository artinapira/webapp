using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class Inventory
{
    public int ItemId { get; set; }

    public string Emri { get; set; } = null!;

    public virtual ICollection<Stafi> Stafis { get; set; } = new List<Stafi>();
}
