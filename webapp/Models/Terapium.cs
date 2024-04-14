using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class Terapium
{
    public int TerapiaId { get; set; }

    public string Emri { get; set; } = null!;

    public string Pershkrimi { get; set; } = null!;

    public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    public virtual ICollection<MedicalRecord> Records { get; set; } = new List<MedicalRecord>();
}
