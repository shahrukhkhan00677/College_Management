using System;
using System.Collections.Generic;

namespace College_Management.Models;

public partial class TblFeedback
{
    public int FbId { get; set; }

    public string FbName { get; set; } = null!;

    public string FbFatherName { get; set; } = null!;

    public string FbEmail { get; set; } = null!;

    public string FbGender { get; set; } = null!;

    public string FbMobile { get; set; } = null!;

    public string FbFeedback { get; set; } = null!;
}
