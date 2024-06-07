namespace UniversityRanking.Models;

public class MainSubject
{
    public int Id { get; set; }
    public string LogoUrl { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<Report> Reports { get; set; } = new List<Report>();
} 