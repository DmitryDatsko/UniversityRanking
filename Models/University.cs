namespace UniversityRanking.Models;

public class University
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime FoundationDate { get; set; }
    public string Logo { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Telephone { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string MissionStatement { get; set; } = string.Empty;
    public string UniversityAccreditingBody { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string InstitutionalPerimeterInclusions  { get; set; } = string.Empty;
    public string InstitutionalPerimeterExclusions  { get; set; } = string.Empty;
}