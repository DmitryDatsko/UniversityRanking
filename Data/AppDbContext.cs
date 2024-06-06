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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Ukrainian_CI_AS");
    }
}