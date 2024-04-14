using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class Pacienti
{
    public int PacientiId { get; set; }

    public string EmriMbiemri { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public DateOnly? DataLindjes { get; set; }

    public string? Gjinia { get; set; }

    public virtual ICollection<Ankesat> Ankesats { get; set; } = new List<Ankesat>();

    public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

    public virtual ICollection<PacientNote> PacientNotes { get; set; } = new List<PacientNote>();

    public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    public virtual ICollection<Terminet> Terminets { get; set; } = new List<Terminet>();

    public virtual ICollection<Vlersimet> Vlersimets { get; set; } = new List<Vlersimet>();
}
