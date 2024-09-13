using System;
using System.Collections.Generic;

namespace College_Management.Models;

public partial class TblCity
{
    public int CtId { get; set; }

    public string CtName { get; set; } = null!;

    public int? SId { get; set; }

    public virtual TblState? SIdNavigation { get; set; }
}
