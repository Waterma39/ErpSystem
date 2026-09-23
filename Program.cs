using ErpSystem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// 註冊控制器與 Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 註冊 DbContext 資料庫內容類別
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AspnetmvcContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    ));

var app = builder.Build();

// 開發環境啟用 Swagger UI 頁面
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();