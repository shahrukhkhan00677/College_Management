using System;
using System.Collections.Generic;

namespace College_Management.Models;

public partial class TblPreRegistration
{
    public int PreId { get; set; }

    public string PreName { get; set; } = null!;

    public string OreEmail { get; set; } = null!;

    public string PreFatherName { get; set; } = null!;

    public string PreGender { get; set; } = null!;

    public DateTime PreDateBirth { get; set; }

    public string PreCourse { get; set; } = null!;

    public string PreMobile { get; set; } = null!;

    public string PreState { get; set; } = null!;

    public string PreCity { get; set; } = null!;
}
