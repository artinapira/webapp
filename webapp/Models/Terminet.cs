using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class Terminet
{
    public int TerminiId { get; set; }

    public DateOnly? DataT { get; set; }

    public TimeOnly? Ora { get; set; }

    public string Ceshtja { get; set; } = null!;

    public int StafiId { get; set; }

    public int PacientiId { get; set; }

    public virtual Pacienti Pacienti { get; set; } = null!;

    public virtual Stafi Stafi { get; set; } = null!;
}
