namespace UniversityRanking.Models;

public class AcademicReputation
{
    public int Id { get; set; }
    public string LogoUrl { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public double AcademicReputationScore { get; set; }
    public double FacultyQuality { get; set; }
    public double ResearchOutput { get; set; }
    public double StudentSatisfaction { get; set; }
    public double InternationalCollaboration { get; set; }
    public string AwardsAndRecognitions { get; set; }
    public int Year { get; set; }
}
