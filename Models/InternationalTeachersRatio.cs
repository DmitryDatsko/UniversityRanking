namespace UniversityRanking.Models;

public class InternationalTeachersRatio
{
    public int Id { get; set; }
    public string LogoUrl { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string TeacherCountries { get; set; } = string.Empty;
    public string SuperiorCountry { get; set; } = string.Empty;
    public int TeachersAmount { get; set; }
    public int InternationalTeacherAmount { get; set; }
}