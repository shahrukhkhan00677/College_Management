using System;
using System.Collections.Generic;

namespace College_Management.Models;

public partial class TblComplane
{
    public int CmId { get; set; }

    public string CmName { get; set; } = null!;

    public string CmEmail { get; set; } = null!;

    public string CmFatherName { get; set; } = null!;

    public string CmGender { get; set; } = null!;

    public string CmMobile { get; set; } = null!;

    public string CmDiscription { get; set; } = null!;
}
