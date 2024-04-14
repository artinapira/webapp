using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class Stafi
{
    public int StafiId { get; set; }

    public string EmriMbiemri { get; set; } = null!;

    public string Degree { get; set; } = null!;

    public TimeOnly? Orari { get; set; }

    public decimal Paga { get; set; }

    public int DepartmentId { get; set; }

    public virtual ICollection<Ankesat> Ankesats { get; set; } = new List<Ankesat>();

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Terminet> Terminets { get; set; } = new List<Terminet>();

    public virtual ICollection<Vlersimet> Vlersimets { get; set; } = new List<Vlersimet>();

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<Knowledge> Knowledges { get; set; } = new List<Knowledge>();

    public virtual ICollection<Marketing> Marketings { get; set; } = new List<Marketing>();
}
