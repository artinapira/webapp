using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class MedicalRecord
{
    public int RecordId { get; set; }

    public string Pershkrimi { get; set; } = null!;

    public string Simptomat { get; set; } = null!;

    public string Diagnoza { get; set; } = null!;

    public string Rezultati { get; set; } = null!;

    public int PacientiId { get; set; }

    public virtual Pacienti Pacienti { get; set; } = null!;

    public virtual ICollection<Terapium> Terapia { get; set; } = new List<Terapium>();
}
