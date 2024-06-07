namespace UniversityRanking.Models;

public class MainSubject
{
    public int Id { get; set; }
    public string LogoUrl { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public AcademicReputation AcademicReputations { get; set; } = null!;
    public EmployerReputation EmployerReputation { get; set; } = null!;
    public Citation Citation { get; set; } = null!;
    public EmploymentResult EmploymentResult { get; set; } = null!;
    public FacultyStudentRatio FacultyStudentRatio { get; set; } = null!;
    public InternationalTeachersRatio InternationalTeachersRatio { get; set; } = null!;
    public ForeignStudentRatio ForeignStudentRatio { get; set; } = null!;
    public ResearchNetwork ResearchNetwork { get; set; } = null!;
    public StudentStability StudentStability { get; set; } = null!;
} 