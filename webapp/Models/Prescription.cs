using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class Prescription
{
    public int PrescriptionId { get; set; }

    public string Diagnoza { get; set; } = null!;

    public string Medicina { get; set; } = null!;

    public int PacientiId { get; set; }

    public virtual Pacienti Pacienti { get; set; } = null!;

    public virtual ICollection<Terapium> Terapia { get; set; } = new List<Terapium>();
}
