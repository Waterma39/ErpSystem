using System.Text;
using ErpSystem.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ErpSystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CitysController : ControllerBase
{
    private readonly AspnetmvcContext _context;

    public CitysController(AspnetmvcContext context)
    {
        _context = context;
    }

    // 1. 傳回標準 JSON 資料
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var list = await _context.Citys.ToListAsync();
        return Ok(list);
    }

    // 2. 傳回 HTML 表格網格（還原 SSMS 表格畫面）
    [HttpGet("grid")]
    public async Task<IActionResult> GetGrid()
    {
        var list = await _context.Citys.ToListAsync();

        var sb = new StringBuilder();
        sb.Append("<html><head><meta charset='utf-8'/><style>");
        sb.Append("table { border-collapse: collapse; width: 100%; font-family: sans-serif; }");
        sb.Append("th, td { border: 1px solid #ccc; padding: 6px 10px; text-align: left; }");
        sb.Append("th { background-color: #f2f2f2; }");
        sb.Append("tr:nth-child(even) { background-color: #f9f9f9; }");
        sb.Append("</style></head><body>");
        sb.Append("<h2>縣市資料清單</h2>");
        sb.Append("<table>");
        sb.Append("<tr><th>Id</th><th>SortNo</th><th>CityName</th><th>Latitude</th><th>Longitude</th><th>Remark</th></tr>");

        foreach (var item in list)
        {
            sb.Append($"<tr>");
            sb.Append($"<td>{item.Id}</td>");
            sb.Append($"<td>{item.SortNo}</td>");
            sb.Append($"<td>{item.CityName}</td>");
            sb.Append($"<td>{item.Latitude}</td>");
            sb.Append($"<td>{item.Longitude}</td>");
            sb.Append($"<td>{item.Remark}</td>");
            sb.Append($"</tr>");
        }

        sb.Append("</table></body></html>");

        return Content(sb.ToString(), "text/html; charset=utf-8");
    }
}