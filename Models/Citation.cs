namespace UniversityRanking.Models;

public class Citation
{
    public int Id { get; set; }
    public string LogoUrl { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int CitationCount { get; set; }
    public int PublicationCount { get; set; }
    public int HIndex { get; set; }
    public int Year { get; set; }
}