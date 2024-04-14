using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class Ankesat
{
    public int AnkesaId { get; set; }

    public string Ankesa { get; set; } = null!;

    public int StafiId { get; set; }

    public int PacientiId { get; set; }

    public virtual Pacienti Pacienti { get; set; } = null!;

    public virtual Stafi Stafi { get; set; } = null!;
}
