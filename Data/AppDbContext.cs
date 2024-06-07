using Microsoft.EntityFrameworkCore;
using UniversityRanking.Models;

namespace UniversityRanking.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<University> Universities { get; set; }
    public DbSet<AcademicReputation> AcademicReputations { get; set; }
    public DbSet<EmployerReputation> EmployerReputations { get; set; }
    public DbSet<Citation> Citations { get; set; }
    public DbSet<EmploymentResult> EmploymentResults { get; set; }
    public DbSet<FacultyStudentRatio> FacultyStudentRatios { get; set; }
    public DbSet<InternationalTeachersRatio> InternationalTeachersRatios { get; set; }
    public DbSet<ForeignStudentRatio> ForeignStudentRatios { get; set; }
    public DbSet<ResearchNetwork> ResearchNetworks { get; set; }
    public DbSet<StudentStability> StudentStability { get; set; }
    public DbSet<MainSubject> MainSubjects { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Ukrainian_CI_AS");

        modelBuilder.Entity<MainSubject>()
            .HasOne(e => e.AcademicReputations)
            .WithOne(e => e.MainSubject)
            .HasForeignKey<AcademicReputation>(e => e.MainSubjectId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<MainSubject>()
            .HasOne(e => e.EmployerReputation)
            .WithOne(e => e.MainSubject)
            .HasForeignKey<EmployerReputation>(e => e.MainSubjectId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<MainSubject>()
            .HasOne(e => e.Citation)
            .WithOne(e => e.MainSubject)
            .HasForeignKey<Citation>(e => e.MainSubjectId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<MainSubject>()
            .HasOne(e => e.EmploymentResult)
            .WithOne(e => e.MainSubject)
            .HasForeignKey<EmploymentResult>(e => e.MainSubjectId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<MainSubject>()
            .HasOne(e => e.FacultyStudentRatio)
            .WithOne(e => e.MainSubject)
            .HasForeignKey<FacultyStudentRatio>(e => e.MainSubjectId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<MainSubject>()
            .HasOne(e => e.InternationalTeachersRatio)
            .WithOne(e => e.MainSubject)
            .HasForeignKey<InternationalTeachersRatio>(e => e.MainSubjectId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<MainSubject>()
            .HasOne(e => e.ForeignStudentRatio)
            .WithOne(e => e.MainSubject)
            .HasForeignKey<ForeignStudentRatio>(e => e.MainSubjectId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<MainSubject>()
            .HasOne(e => e.ResearchNetwork)
            .WithOne(e => e.MainSubject)
            .HasForeignKey<ResearchNetwork>(e => e.MainSubjectId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<MainSubject>()
            .HasOne(e => e.StudentStability)
            .WithOne(e => e.MainSubject)
            .HasForeignKey<StudentStability>(e => e.MainSubjectId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}