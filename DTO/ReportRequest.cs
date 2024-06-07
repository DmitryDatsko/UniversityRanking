namespace UniversityRanking.DTO;

public class ReportRequest
{
    public int MainSubjectId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}