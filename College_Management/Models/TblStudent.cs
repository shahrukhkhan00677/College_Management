using System;
using System.Collections.Generic;

namespace College_Management.Models;

public partial class TblStudent
{
    public int StdId { get; set; }

    public string StdName { get; set; } = null!;

    public string StdEmail { get; set; } = null!;

    public string StdFatherName { get; set; } = null!;

    public string StdGender { get; set; } = null!;

    public string StdCourse { get; set; } = null!;

    public string StdImgPath { get; set; } = null!;

    public string StdAadharNo { get; set; } = null!;

    public string StdAdharImgPath { get; set; } = null!;

    public DateTime StdDateBirth { get; set; }

    public DateTime StdAdmissionDate { get; set; }

    public string StdMobile { get; set; } = null!;

    public string StdState { get; set; } = null!;

    public string StdCity { get; set; } = null!;
}
