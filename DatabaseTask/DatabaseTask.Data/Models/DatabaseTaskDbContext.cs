using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data.Models;

public partial class DatabaseTaskDbContext : DbContext
{
    public DatabaseTaskDbContext()
    {
    }

    public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnonymousFeedback> AnonymousFeedbacks { get; set; }

    public virtual DbSet<Child> Children { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeAccess> EmployeeAccesses { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<HealthCheck> HealthChecks { get; set; }

    public virtual DbSet<JobTitle> JobTitles { get; set; }

    public virtual DbSet<Loan> Loans { get; set; }

    public virtual DbSet<SickLeaf> SickLeaves { get; set; }

    public virtual DbSet<Vacation> Vacations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=np:\\\\.\\pipe\\LOCALDB#340910D3\\tsql\\query;Database=DatabaseTaskDb;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnonymousFeedback>(entity =>
        {
            entity.HasKey(e => e.FeedbackId);

            entity.Property(e => e.FeedbackId).HasColumnName("Feedback_ID");
        });

        modelBuilder.Entity<Child>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId1, "IX_Children_Employee_ID1");

            entity.Property(e => e.ChildId).HasColumnName("Child_ID");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployeeId1).HasColumnName("Employee_ID1");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);

            entity.HasOne(d => d.EmployeeId1Navigation).WithMany(p => p.Children).HasForeignKey(d => d.EmployeeId1);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .HasColumnName("Department_Name");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasIndex(e => e.DepartmentId1, "IX_Employees_Department_ID1");

            entity.HasIndex(e => e.JobTitleJobTitleId, "IX_Employees_JobTitleJob_Title_ID");

            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");
            entity.Property(e => e.DepartmentId1).HasColumnName("Department_ID1");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.JobTitleId).HasColumnName("Job_Title_ID");
            entity.Property(e => e.JobTitleJobTitleId).HasColumnName("JobTitleJob_Title_ID");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(25);
            entity.Property(e => e.SocialSecurityNumber).HasMaxLength(20);

            entity.HasOne(d => d.DepartmentId1Navigation).WithMany(p => p.Employees).HasForeignKey(d => d.DepartmentId1);

            entity.HasOne(d => d.JobTitleJobTitle).WithMany(p => p.Employees).HasForeignKey(d => d.JobTitleJobTitleId);
        });

        modelBuilder.Entity<EmployeeAccess>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId1, "IX_EmployeeAccesses_Employee_ID1");

            entity.Property(e => e.EmployeeAccessId).HasColumnName("Employee_Access_ID");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployeeId1).HasColumnName("Employee_ID1");

            entity.HasOne(d => d.EmployeeId1Navigation).WithMany(p => p.EmployeeAccesses).HasForeignKey(d => d.EmployeeId1);
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.Property(e => e.EquipmentId).HasColumnName("Equipment_ID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<HealthCheck>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId1, "IX_HealthChecks_Employee_ID1");

            entity.Property(e => e.HealthCheckId).HasColumnName("Health_Check_ID");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployeeId1).HasColumnName("Employee_ID1");

            entity.HasOne(d => d.EmployeeId1Navigation).WithMany(p => p.HealthChecks).HasForeignKey(d => d.EmployeeId1);
        });

        modelBuilder.Entity<JobTitle>(entity =>
        {
            entity.Property(e => e.JobTitleId).HasColumnName("Job_Title_ID");
            entity.Property(e => e.JobTitleName)
                .HasMaxLength(100)
                .HasColumnName("Job_title_name");
        });

        modelBuilder.Entity<Loan>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId1, "IX_Loans_Employee_ID1");

            entity.HasIndex(e => e.EquipmentId1, "IX_Loans_Equipment_ID1");

            entity.Property(e => e.LoanId).HasColumnName("Loan_ID");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployeeId1).HasColumnName("Employee_ID1");
            entity.Property(e => e.EquipmentId).HasColumnName("Equipment_ID");
            entity.Property(e => e.EquipmentId1).HasColumnName("Equipment_ID1");

            entity.HasOne(d => d.EmployeeId1Navigation).WithMany(p => p.Loans).HasForeignKey(d => d.EmployeeId1);

            entity.HasOne(d => d.EquipmentId1Navigation).WithMany(p => p.Loans).HasForeignKey(d => d.EquipmentId1);
        });

        modelBuilder.Entity<SickLeaf>(entity =>
        {
            entity.HasKey(e => e.SickLeaveId);

            entity.HasIndex(e => e.EmployeeId1, "IX_SickLeaves_Employee_ID1");

            entity.Property(e => e.SickLeaveId).HasColumnName("Sick_leave_ID");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployeeId1).HasColumnName("Employee_ID1");

            entity.HasOne(d => d.EmployeeId1Navigation).WithMany(p => p.SickLeaves).HasForeignKey(d => d.EmployeeId1);
        });

        modelBuilder.Entity<Vacation>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId1, "IX_Vacations_Employee_ID1");

            entity.Property(e => e.VacationId).HasColumnName("Vacation_ID");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployeeId1).HasColumnName("Employee_ID1");
            entity.Property(e => e.ExtraChildDayVacation).HasColumnName("Extra_Child_Day_Vacation");

            entity.HasOne(d => d.EmployeeId1Navigation).WithMany(p => p.Vacations).HasForeignKey(d => d.EmployeeId1);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
