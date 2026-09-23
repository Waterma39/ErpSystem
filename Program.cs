using ErpSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// 1. 綁定 Railway 動態 PORT (預設 8080)
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://*:{port}");

// 2. 取得連線字串
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 3. 使用固定版本號，避免 AutoDetect 連線失敗導致程式崩潰
var serverVersion = new MySqlServerVersion(new Version(8, 0, 36));

builder.Services.AddDbContext<AspnetmvcContext>(options =>
    options.UseMySql(connectionString, serverVersion));

// 註冊控制器與 Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 啟用 Swagger 介面
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();