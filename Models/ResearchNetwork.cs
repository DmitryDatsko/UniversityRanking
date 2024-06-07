namespace UniversityRanking.Models;

public class ResearchNetwork
{
    public int Id { get; set; }
    public int MainSubjectId { get; set; }
    public MainSubject MainSubject { get; set; } = null!;
    public string LogoUrl { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Members { get; set; } = string.Empty;
    public string CollaboratingOrganizations { get; set; } = string.Empty;
}