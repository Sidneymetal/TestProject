using Microsoft.EntityFrameworkCore;
using TestAikoProject.Lib.Date.Repository;
using TestAikoProject.Lib.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TestAikoContext>(conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("data.beckup")).UseSnakeCaseNamingConvention());

builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddScoped<IEquipmentRepository, EquipmentRepository>();
builder.Services.AddScoped<IEquipmentModelRepository, EquipmentModelRepository>();
builder.Services.AddScoped<IEquipmentModelStateHourlyEarningRepository, EquipmentModelStateHourlyEarningRepository>();
builder.Services.AddScoped<IEquipmentPositionHistoryRepository, EquipmentPositionHistoryRepository>();
builder.Services.AddScoped<IEquipmentStateHistoryRepository, EquipmentStateHistoryRepository>();
builder.Services.AddScoped<IEquipmentStateRepository, EquipmentStateRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
