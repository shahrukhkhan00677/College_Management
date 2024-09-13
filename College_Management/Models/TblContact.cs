using System;
using System.Collections.Generic;

namespace College_Management.Models;

public partial class TblContact
{
    public int CnId { get; set; }

    public string CnName { get; set; } = null!;

    public string CnFatherName { get; set; } = null!;

    public string CnEmail { get; set; } = null!;

    public string CnGender { get; set; } = null!;

    public string CnMobile { get; set; } = null!;

    public string CnDiscription { get; set; } = null!;
}
