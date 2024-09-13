using System;
using System.Collections.Generic;

namespace College_Management.Models;

public partial class TblTeacher
{
    public int TrId { get; set; }

    public string TrName { get; set; } = null!;

    public string TrEmail { get; set; } = null!;

    public string TrFatherName { get; set; } = null!;

    public string TrGender { get; set; } = null!;

    public string TrImgPath { get; set; } = null!;

    public string TrAadharNo { get; set; } = null!;

    public string TrAdharImgPath { get; set; } = null!;

    public DateTime TrDateBirth { get; set; }

    public DateTime TrJoiningDate { get; set; }

    public string TrSalary { get; set; } = null!;

    public string TrMobile { get; set; } = null!;

    public string TrState { get; set; } = null!;

    public string TrCity { get; set; } = null!;
}
