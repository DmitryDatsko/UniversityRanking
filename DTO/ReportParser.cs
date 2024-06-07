using UniversityRanking.Models;

namespace UniversityRanking.DTO;

public class ReportParser
{
    public ICollection<Report> Report { get; set; } = null!;
    public MainSubject MainSubject { get; set; } = null!;
}