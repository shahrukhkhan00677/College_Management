using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace College_Management.Models;

public partial class CollegeManagementProjectContext : DbContext
{
    public CollegeManagementProjectContext()
    {
    }

    public CollegeManagementProjectContext(DbContextOptions<CollegeManagementProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAdmin> TblAdmins { get; set; }

    public virtual DbSet<TblCity> TblCities { get; set; }

    public virtual DbSet<TblComplane> TblComplanes { get; set; }

    public virtual DbSet<TblContact> TblContacts { get; set; }

    public virtual DbSet<TblFeedback> TblFeedbacks { get; set; }

    public virtual DbSet<TblJobRegistration> TblJobRegistrations { get; set; }

    public virtual DbSet<TblPreRegistration> TblPreRegistrations { get; set; }

    public virtual DbSet<TblState> TblStates { get; set; }

    public virtual DbSet<TblStudent> TblStudents { get; set; }

    public virtual DbSet<TblTeacher> TblTeachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAdmin>(entity =>
        {
            entity.HasKey(e => e.AdId).HasName("PK__tbl_admi__CAA4A627D83FD94C");

            entity.ToTable("tbl_admin");

            entity.Property(e => e.AdId).HasColumnName("ad_id");
            entity.Property(e => e.AdPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad_password");
            entity.Property(e => e.AdUsername)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad_username");
        });

        modelBuilder.Entity<TblCity>(entity =>
        {
            entity.HasKey(e => e.CtId).HasName("PK__tbl_city__33D47D0984E1222F");

            entity.ToTable("tbl_city");

            entity.Property(e => e.CtId).HasColumnName("ct_id");
            entity.Property(e => e.CtName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ct_name");
            entity.Property(e => e.SId).HasColumnName("s_id");

            entity.HasOne(d => d.SIdNavigation).WithMany(p => p.TblCities)
                .HasForeignKey(d => d.SId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__tbl_city__s_id__6477ECF3");
        });

        modelBuilder.Entity<TblComplane>(entity =>
        {
            entity.HasKey(e => e.CmId).HasName("PK__tbl_comp__682312ECF8F2E509");

            entity.ToTable("tbl_complane");

            entity.Property(e => e.CmId).HasColumnName("cm_id");
            entity.Property(e => e.CmDiscription)
                .IsUnicode(false)
                .HasColumnName("cm_discription");
            entity.Property(e => e.CmEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cm_email");
            entity.Property(e => e.CmFatherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cm_father_name");
            entity.Property(e => e.CmGender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cm_gender");
            entity.Property(e => e.CmMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cm_mobile");
            entity.Property(e => e.CmName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cm_name");
        });

        modelBuilder.Entity<TblContact>(entity =>
        {
            entity.HasKey(e => e.CnId).HasName("PK__tbl_cont__84F0C32A78506020");

            entity.ToTable("tbl_contact");

            entity.Property(e => e.CnId).HasColumnName("cn_id");
            entity.Property(e => e.CnDiscription)
                .IsUnicode(false)
                .HasColumnName("cn_discription");
            entity.Property(e => e.CnEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cn_email");
            entity.Property(e => e.CnFatherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cn_father_name");
            entity.Property(e => e.CnGender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cn_gender");
            entity.Property(e => e.CnMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cn_mobile");
            entity.Property(e => e.CnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cn_name");
        });

        modelBuilder.Entity<TblFeedback>(entity =>
        {
            entity.HasKey(e => e.FbId).HasName("PK__tbl_feed__A81DB82D36E73DEC");

            entity.ToTable("tbl_feedback");

            entity.Property(e => e.FbId).HasColumnName("fb_id");
            entity.Property(e => e.FbEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fb_email");
            entity.Property(e => e.FbFatherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fb_father_name");
            entity.Property(e => e.FbFeedback)
                .IsUnicode(false)
                .HasColumnName("fb_feedback");
            entity.Property(e => e.FbGender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fb_gender");
            entity.Property(e => e.FbMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fb_mobile");
            entity.Property(e => e.FbName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fb_name");
        });

        modelBuilder.Entity<TblJobRegistration>(entity =>
        {
            entity.HasKey(e => e.JreId).HasName("PK__tbl_job___C5B42068DB29120A");

            entity.ToTable("tbl_job_registration");

            entity.Property(e => e.JreId).HasColumnName("jre_id");
            entity.Property(e => e.JreCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jre_city");
            entity.Property(e => e.JreDateBirth)
                .HasColumnType("datetime")
                .HasColumnName("jre_date_birth");
            entity.Property(e => e.JreEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jre_email");
            entity.Property(e => e.JreExperience)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jre_experience");
            entity.Property(e => e.JreFatherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jre_father_name");
            entity.Property(e => e.JreGender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jre_gender");
            entity.Property(e => e.JreMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jre_mobile");
            entity.Property(e => e.JreName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jre_name");
            entity.Property(e => e.JrePassOut)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jre_passOut");
            entity.Property(e => e.JreQualification)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jre_qualification");
            entity.Property(e => e.JreResumePath)
                .IsUnicode(false)
                .HasColumnName("jre_resume_path");
            entity.Property(e => e.JreState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jre_state");
        });

        modelBuilder.Entity<TblPreRegistration>(entity =>
        {
            entity.HasKey(e => e.PreId).HasName("PK__tbl_pre___E0CCC60DCA569348");

            entity.ToTable("tbl_pre_registration");

            entity.Property(e => e.PreId).HasColumnName("pre_id");
            entity.Property(e => e.OreEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ore_email");
            entity.Property(e => e.PreCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pre_city");
            entity.Property(e => e.PreCourse)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pre_course");
            entity.Property(e => e.PreDateBirth)
                .HasColumnType("datetime")
                .HasColumnName("pre_date_birth");
            entity.Property(e => e.PreFatherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pre_father_name");
            entity.Property(e => e.PreGender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pre_gender");
            entity.Property(e => e.PreMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pre_mobile");
            entity.Property(e => e.PreName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pre_name");
            entity.Property(e => e.PreState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pre_state");
        });

        modelBuilder.Entity<TblState>(entity =>
        {
            entity.HasKey(e => e.StId).HasName("PK__tbl_stat__A85E81CF7A5D9314");

            entity.ToTable("tbl_state");

            entity.Property(e => e.StId).HasColumnName("st_id");
            entity.Property(e => e.StName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("st_name");
        });

        modelBuilder.Entity<TblStudent>(entity =>
        {
            entity.HasKey(e => e.StdId).HasName("PK__tbl_stud__0B0245BAA6A7EE34");

            entity.ToTable("tbl_student");

            entity.Property(e => e.StdId).HasColumnName("std_id");
            entity.Property(e => e.StdAadharNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("std_aadharNo");
            entity.Property(e => e.StdAdharImgPath)
                .IsUnicode(false)
                .HasColumnName("std_adhar_img_path");
            entity.Property(e => e.StdAdmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("std_admission_date");
            entity.Property(e => e.StdCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("std_city");
            entity.Property(e => e.StdCourse)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("std_course");
            entity.Property(e => e.StdDateBirth)
                .HasColumnType("datetime")
                .HasColumnName("std_date_birth");
            entity.Property(e => e.StdEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("std_email");
            entity.Property(e => e.StdFatherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("std_Father_name");
            entity.Property(e => e.StdGender)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("std_gender");
            entity.Property(e => e.StdImgPath)
                .IsUnicode(false)
                .HasColumnName("std_img_path");
            entity.Property(e => e.StdMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("std_mobile");
            entity.Property(e => e.StdName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("std_name");
            entity.Property(e => e.StdState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("std_state");
        });

        modelBuilder.Entity<TblTeacher>(entity =>
        {
            entity.HasKey(e => e.TrId).HasName("PK__tbl_teac__ABDBAB188850004E");

            entity.ToTable("tbl_teacher");

            entity.Property(e => e.TrId).HasColumnName("tr_id");
            entity.Property(e => e.TrAadharNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tr_aadharNo");
            entity.Property(e => e.TrAdharImgPath)
                .IsUnicode(false)
                .HasColumnName("tr_adhar_img_path");
            entity.Property(e => e.TrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tr_city");
            entity.Property(e => e.TrDateBirth)
                .HasColumnType("datetime")
                .HasColumnName("tr_date_birth");
            entity.Property(e => e.TrEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tr_email");
            entity.Property(e => e.TrFatherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tr_Father_name");
            entity.Property(e => e.TrGender)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tr_gender");
            entity.Property(e => e.TrImgPath)
                .IsUnicode(false)
                .HasColumnName("tr_img_path");
            entity.Property(e => e.TrJoiningDate)
                .HasColumnType("datetime")
                .HasColumnName("tr_joining_date");
            entity.Property(e => e.TrMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tr_mobile");
            entity.Property(e => e.TrName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tr_name");
            entity.Property(e => e.TrSalary)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tr_salary");
            entity.Property(e => e.TrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tr_state");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
