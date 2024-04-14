using System;
using System.Collections.Generic;

namespace webapp.Models;

public partial class Vlersimet
{
    public int VlersimiId { get; set; }

    public int Sherbimi { get; set; }

    public int Sjellja { get; set; }

    public int StafiId { get; set; }

    public int PacientiId { get; set; }

    public virtual Pacienti Pacienti { get; set; } = null!;

    public virtual Stafi Stafi { get; set; } = null!;
}
