using System;
using System.Collections.Generic;

namespace College_Management.Models;

public partial class TblAdmin
{
    public int AdId { get; set; }

    public string AdUsername { get; set; } = null!;

    public string AdPassword { get; set; } = null!;
}
