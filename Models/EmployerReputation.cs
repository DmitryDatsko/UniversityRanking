namespace UniversityRanking.Models;

public class EmployerReputation
{
    public int Id { get; set; }
    public int MainSubjectId { get; set; }
    public MainSubject MainSubject { get; set; } = null!;
    public string LogoUrl { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string EvidenceUrl { get; set; } = string.Empty;
    public double ExpenditurePerEmployees { get; set; }
    public double EmployerReputationScore { get; set; }
    public string EmployerFeedback { get; set; } = string.Empty;
    public double JobPlacementRate { get; set; }
    public double AverageSalary { get; set; }
    public int Year { get; set; }
}