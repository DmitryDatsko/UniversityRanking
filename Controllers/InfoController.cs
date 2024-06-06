using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityRanking.Data;

namespace UniversityRanking.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InfoController : ControllerBase
{
    private readonly AppDbContext _context;

    public InfoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("mainUniversity")]
    public async Task<IActionResult> GetMainUniversity()
    {
        var universities = await _context.Universities.ToListAsync();

        return Ok(universities);
    }
    
    [HttpGet("academic-reputation")]
    public async Task<IActionResult> GetAcademicReputation()
    {
        var data = await _context.AcademicReputations.ToListAsync();

        return Ok(data);
    }
    
    [HttpGet("employer-reputation")]
    public async Task<IActionResult> GetEmployerReputation()
    {
        var data = await _context.EmployerReputations.ToListAsync();

        return Ok(data);
    }
    
    [HttpGet("citation")]
    public async Task<IActionResult> GetCitation()
    {
        var data = await _context.Citations.ToListAsync();

        return Ok(data);
    }
    
    [HttpGet("employer-results")]
    public async Task<IActionResult> GetEmploymentResults()
    {
        var data = await _context.EmploymentResults.ToListAsync();

        return Ok(data);
    }
    
    [HttpGet("faculty-ratio")]
    public async Task<IActionResult> GetFacultyRatio()
    {
        var data = await _context.FacultyStudentRatios.ToListAsync();

        return Ok(data);
    }
    
    [HttpGet("international-teachers")]
    public async Task<IActionResult> GetInternationalTeachers()
    {
        var data = await _context.InternationalTeachersRatios.ToListAsync();

        return Ok(data);
    }
    
    [HttpGet("foreign-student")]
    public async Task<IActionResult> GetForeignStudent()
    {
        var data = await _context.ForeignStudentRatios.ToListAsync();

        return Ok(data);
    }
    
    [HttpGet("research-network")]
    public async Task<IActionResult> GetResearchNetwork()
    {
        var data = await _context.ResearchNetworks.ToListAsync();

        return Ok(data);
    }
    
    [HttpGet("student-stability")]
    public async Task<IActionResult> GetStudentStability()
    {
        var data = await _context.StudentStability.ToListAsync();

        return Ok(data);
    }
}