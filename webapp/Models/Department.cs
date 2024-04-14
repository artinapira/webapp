using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string Emri { get; set; } = null!;

    public string Pershkrimi { get; set; } = null!;

    public virtual ICollection<Stafi> Stafis { get; set; } = new List<Stafi>();
}
