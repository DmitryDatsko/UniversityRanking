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

    [HttpGet("get-report/{id}")]
    public async Task<IActionResult> GetReport(int id)
    {
        var mainSubject = await _context.MainSubjects
            .Where(ms => ms.Id == id)
            .SingleOrDefaultAsync();

        if (mainSubject == null)
        {
            return NotFound("Main subject id incorrect");
        }

        var reports = await _context.Reports.Where(r => r.MainSubjectId == id)
            .ToListAsync();

        byte[] pdfBytes = PdfParser.FromReportToPdf(new ReportParser
        {
            MainSubject = mainSubject,
            Report = reports
        });

        return File(pdfBytes, "application/pdf", $"{mainSubject.Title}_report");
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