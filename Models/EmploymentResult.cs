namespace UniversityRanking.Models;

public class EmploymentResult
{
    public int Id { get; set; }
    public int MainSubjectId { get; set; }
    public MainSubject MainSubject { get; set; } = null!;
    public double EmploymentRate { get; set; }
    public string LogoUrl { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public double AverageSalary { get; set; }
    public string TopEmployers { get; set; }
    public string EmploymentSectors { get; set; }
    public int SurveyYear { get; set; }
}