using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityRanking.Data;
using UniversityRanking.DTO;
using UniversityRanking.Models;
using UniversityRanking.Services.PdfParser;

namespace UniversityRanking.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReportController : ControllerBase
{
    private readonly AppDbContext _context;

    public ReportController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("get-report")]
    public async Task<IActionResult> GetReport()
    {
        var mainSubject = await _context.MainSubjects
            .OrderBy(ms => ms.Id)
            .ToListAsync();

        var reports = await _context.Reports
            .OrderBy(r => r.MainSubjectId)
            .ToListAsync();

        byte[] pdfBytes = PdfParser.FromReportToPdf(new ReportParser
        {
            MainSubject = mainSubject,
            Report = reports
        });

        return File(pdfBytes, "application/pdf", $"report");
    }
    
    [HttpPost("create-report")]
    public async Task<IActionResult> CreateReport([FromBody] ReportRequest request)
    {
        var mainSubject = await _context.MainSubjects
            .Where(ms => ms.Id == request.MainSubjectId)
            .SingleOrDefaultAsync();

        if (mainSubject == null)
        {
            return NotFound("Main subject id incorrect");
        }
        
        var data = new Report
        {
            MainSubject = mainSubject,
            MainSubjectId = request.MainSubjectId,
            Title = request.Title,
            Date = request.Date,
            Description = request.Description
        };

        await _context.Reports.AddAsync(data);
        await _context.SaveChangesAsync();

        return Ok(data);
    }
}