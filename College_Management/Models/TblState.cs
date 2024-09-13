using System;
using System.Collections.Generic;

namespace College_Management.Models;

public partial class TblState
{
    public int StId { get; set; }

    public string StName { get; set; } = null!;

    public virtual ICollection<TblCity> TblCities { get; set; } = new List<TblCity>();
}
