using Microsoft.EntityFrameworkCore;
using UniversityRanking.Models;

namespace UniversityRanking.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<University> Universities { get; set; }
    public DbSet<Report> Reports { get; set; }
    public DbSet<MainSubject> MainSubjects { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Ukrainian_CI_AS");

        modelBuilder.Entity<MainSubject>()
            .HasMany(e => e.Reports)
            .WithOne(e => e.MainSubject)
            .HasForeignKey(e => e.MainSubjectId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}