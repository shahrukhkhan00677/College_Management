using System;
using System.Collections.Generic;

namespace College_Management.Models;

public partial class TblJobRegistration
{
    public int JreId { get; set; }

    public string JreName { get; set; } = null!;

    public string JreEmail { get; set; } = null!;

    public string JreFatherName { get; set; } = null!;

    public string JreGender { get; set; } = null!;

    public DateTime JreDateBirth { get; set; }

    public string JreQualification { get; set; } = null!;

    public string JrePassOut { get; set; } = null!;

    public string JreExperience { get; set; } = null!;

    public string JreResumePath { get; set; } = null!;

    public string JreMobile { get; set; } = null!;

    public string JreState { get; set; } = null!;

    public string JreCity { get; set; } = null!;
}
