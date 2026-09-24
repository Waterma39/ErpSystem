using ErpSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. 綁定 Railway 動態 PORT (預設 8080)
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

// 2. 取得連線字串與設定 MySQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var serverVersion = new MySqlServerVersion(new Version(8, 0, 36));

builder.Services.AddDbContext<AspnetmvcContext>(options =>
    options.UseMySql(connectionString, serverVersion));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 強制在所有環境啟用開發者例外頁面
app.UseDeveloperExceptionPage();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();

// 3. 自動建立資料庫結構（若 Table 不存在則自動建表）
using (var scope = app.Services.CreateScope())
{
    try
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<AspnetmvcContext>();
        dbContext.Database.EnsureCreated();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[DB Error] 資料庫初始化失敗: {ex.Message}");
    }
}

// 4. 啟用 Swagger UI 方便 API 測試與除錯
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();