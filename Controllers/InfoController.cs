using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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

    [HttpGet("get-all-subjects")]
    public async Task<IActionResult> GetAllSubjects()
    {
        var subjects = await _context.MainSubjects.ToListAsync();

        if (subjects.IsNullOrEmpty())
        {
            return NotFound("Main subjects not found");
        }
        
        return Ok(subjects);
    }
    
    [HttpGet("mainUniversity")]
    public async Task<IActionResult> GetMainUniversity()
    {
        var universities = await _context.Universities.ToListAsync();

        return Ok(universities);
    }

    [HttpGet("get-subject-by-id/{id}")]
    public async Task<IActionResult> GetSubjectById(int id)
    {
        var data = await _context.MainSubjects.Include(i => i.AcademicReputations)
            .Include(i => i.EmployerReputation)
            .Include(i => i.Citation)
            .Include(i => i.EmploymentResult)
            .Include(i => i.ForeignStudentRatio)
            .Include(i => i.InternationalTeachersRatio)
            .Include(i => i.ForeignStudentRatio)
            .Include(i => i.ResearchNetwork)
            .Include(i => i.StudentStability)
            .Where(ms =>
                ms.AcademicReputations.MainSubjectId == id ||
                ms.EmployerReputation.MainSubjectId == id ||
                ms.Citation.MainSubjectId == id ||
                ms.EmploymentResult.MainSubjectId == id ||
                ms.ForeignStudentRatio.MainSubjectId == id ||
                ms.InternationalTeachersRatio.MainSubjectId == id ||
                ms.ForeignStudentRatio.MainSubjectId == id ||
                ms.ResearchNetwork.MainSubjectId == id ||
                ms.StudentStability.MainSubjectId == id)
            .SingleOrDefaultAsync();

        if (data != null)
        {
            return Ok(data);
        }

        return NotFound();
    }
}