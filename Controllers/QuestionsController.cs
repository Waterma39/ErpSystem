using ErpSystem.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ErpSystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuestionsController : ControllerBase
{
    private readonly AspnetmvcContext _context;

    public QuestionsController(AspnetmvcContext context)
    {
        _context = context;
    }

    // 1. 展示：全表查詢 (Get All)
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var list = await _context.Questions.ToListAsync();
        return Ok(list);
    }

    // 2. 展示：關鍵字條件篩選查詢 (Search)
    [HttpGet("search")]
    public async Task<IActionResult> Search([FromQuery] string? keyword)
    {
        var query = _context.Questions.AsQueryable();

        if (!string.IsNullOrWhiteSpace(keyword))
        {
            query = query.Where(q => q.QuestionText.Contains(keyword));
        }

        var result = await query.ToListAsync();
        return Ok(result);
    }
}