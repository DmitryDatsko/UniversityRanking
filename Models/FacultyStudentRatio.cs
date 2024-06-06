namespace UniversityRanking.Models;

public class FacultyStudentRatio
{
    public int Id { get; set; }
    public string LogoUrl { get; set; } = string.Empty;
    public string Degree { get; set; } = string.Empty;
    public string Specialization { get; set; }
    public int MaleAmount { get; set; }
    public int FemaleAmount { get; set; }
    public int StudentCount { get; set; }
}