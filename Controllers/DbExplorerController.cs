using System.Text;
using ErpSystem.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ErpSystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DbExplorerController : ControllerBase
{
    private readonly AspnetmvcContext _context;

    public DbExplorerController(AspnetmvcContext context)
    {
        _context = context;
    }

    // 1. 取得資料庫中「所有資料表名稱」與 API 查詢路由清單
    [HttpGet]
    public IActionResult GetAllTables()
    {
        var tables = _context.Model.GetEntityTypes().Select(e => new
        {
            EntityName = e.ClrType.Name,
            TableName = e.GetTableName(),
            ApiUrl = $"/api/dbexplorer/{e.GetTableName()}"
        });

        return Ok(tables);
    }

    // 2. 萬能資料查詢：傳入任意資料表名稱，動態撈取資料
    [HttpGet("{tableName}")]
    public async Task<IActionResult> GetTableData(string tableName)
    {
        var entityType = _context.Model.GetEntityTypes()
            .FirstOrDefault(e => string.Equals(e.GetTableName(), tableName, StringComparison.OrdinalIgnoreCase)
                              || string.Equals(e.ClrType.Name, tableName, StringComparison.OrdinalIgnoreCase));

        if (entityType == null)
        {
            return NotFound($"找不到名為 '{tableName}' 的資料表");
        }

        var targetTableName = entityType.GetTableName();
        if (string.IsNullOrEmpty(targetTableName))
        {
            return BadRequest("無法解析資料表名稱");
        }

        // 使用通用 SQL 查詢避免泛型型別推斷失敗
        var connection = _context.Database.GetDbConnection();
        await connection.OpenAsync();

        using var command = connection.CreateCommand();
        command.CommandText = $"SELECT * FROM `{targetTableName}`";
        using var reader = await command.ExecuteReaderAsync();

        var result = new List<Dictionary<string, object?>>();
        while (await reader.ReadAsync())
        {
            var row = new Dictionary<string, object?>();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var columnName = reader.GetName(i);
                var value = reader.IsDBNull(i) ? null : reader.GetValue(i);
                row[columnName] = value;
            }
            result.Add(row);
        }

        return Ok(result);
    }

    // 3. 萬能視覺化儀表板：單一網頁點選檢視所有資料表內容
    [HttpGet("dashboard")]
    public IActionResult GetDashboard()
    {
        var tables = _context.Model.GetEntityTypes()
            .Select(e => e.GetTableName())
            .Where(t => t != null)
            .OrderBy(t => t)
            .ToList();

        var sb = new StringBuilder();
        sb.Append("<html><head><meta charset='utf-8'/><title>ERP 資料庫總覽儀表板</title>");
        sb.Append("<style>");
        sb.Append("body { font-family: 'Microsoft JhengHei', sans-serif; margin: 0; padding: 20px; display: flex; height: 90vh; }");
        sb.Append("#sidebar { width: 280px; border-right: 2px solid #e0e0e0; padding-right: 15px; overflow-y: auto; }");
        sb.Append("#content { flex: 1; padding-left: 20px; overflow: auto; }");
        sb.Append("ul { list-style: none; padding: 0; margin: 0; }");
        sb.Append("li { padding: 8px 12px; margin: 4px 0; background: #f8f9fa; border-radius: 4px; cursor: pointer; border: 1px solid #ddd; }");
        sb.Append("li:hover { background: #e2e6ea; font-weight: bold; }");
        sb.Append("table { border-collapse: collapse; width: 100%; margin-top: 15px; font-size: 14px; }");
        sb.Append("th, td { border: 1px solid #ccc; padding: 8px 10px; text-align: left; }");
        sb.Append("th { background-color: #007bff; color: white; position: sticky; top: 0; }");
        sb.Append("tr:nth-child(even) { background-color: #f2f2f2; }");
        sb.Append("</style></head><body>");

        sb.Append("<div id='sidebar'><h3>資料庫資料表清單</h3><ul>");
        foreach (var t in tables)
        {
            sb.Append($"<li onclick=\"loadTable('{t}')\">{t}</li>");
        }
        sb.Append("</ul></div>");

        sb.Append("<div id='content'><h2 id='title'>點擊左側資料表名稱以進行檢視</h2><div id='tableContainer'></div></div>");

        sb.Append("<script>");
        sb.Append("async function loadTable(name) {");
        sb.Append("  document.getElementById('title').innerText = '資料表：' + name;");
        sb.Append("  document.getElementById('tableContainer').innerHTML = '<p>讀取中...</p>';");
        sb.Append("  try {");
        sb.Append("    const res = await fetch('/api/dbexplorer/' + name);");
        sb.Append("    const data = await res.json();");
        sb.Append("    if (!data || data.length === 0) { document.getElementById('tableContainer').innerHTML = '<p>此資料表目前尚無紀錄</p>'; return; }");
        sb.Append("    let html = '<table><thead><tr>';");
        sb.Append("    Object.keys(data[0]).forEach(k => html += '<th>' + k + '</th>');");
        sb.Append("    html += '</tr></thead><tbody>';");
        sb.Append("    data.forEach(row => {");
        sb.Append("      html += '<tr>';");
        sb.Append("      Object.values(row).forEach(v => html += '<td>' + (v === null ? '' : v) + '</td>');");
        sb.Append("      html += '</tr>';");
        sb.Append("    });");
        sb.Append("    html += '</tbody></table>';");
        sb.Append("    document.getElementById('tableContainer').innerHTML = html;");
        sb.Append("  } catch (err) { document.getElementById('tableContainer').innerHTML = '<p>讀取失敗：' + err + '</p>'; }");
        sb.Append("}");
        sb.Append("</script>");

        sb.Append("</body></html>");

        return Content(sb.ToString(), "text/html; charset=utf-8");
    }
}