namespace UniversityRanking.Models;

public class Report
{
    public int Id { get; set; }
    public int MainSubjectId { get; set; }
    public MainSubject MainSubject { get; set; } = null!;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}