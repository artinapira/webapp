using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class PacientNote
{
    public int NoteId { get; set; }

    public string Pershkrimi { get; set; } = null!;

    public int PacientiId { get; set; }

    public virtual Pacienti Pacienti { get; set; } = null!;
}
