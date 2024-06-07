namespace UniversityRanking.Models;

public class ForeignStudentRatio
{
    public int Id { get; set; }
    public int MainSubjectId { get; set; }
    public MainSubject MainSubject { get; set; } = null!;
    public string LogoUrl { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string StudentCountries { get; set; } = string.Empty;
    public string SuperiorCountry { get; set; } = string.Empty;
    public int StudentAmount { get; set; }
    public int InternationalStudentAmount { get; set; }
    public string UsefullUrl { get; set; } = string.Empty;
}