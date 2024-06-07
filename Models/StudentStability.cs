﻿namespace UniversityRanking.Models;

public class StudentStability
{
    public int Id { get; set; }
    public int MainSubjectId { get; set; }
    public MainSubject MainSubject { get; set; } = null!;
    public string CountryName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int TotalStudents { get; set; }
    public string LogoUrl { get; set; } = string.Empty;
    public int StudentsRemaining { get; set; }
    public int StudentsMoved { get; set; }
    public string OtherDetails { get; set; } = string.Empty;
}