// 1.- Usings to work with EntityFramework
using Microsoft.EntityFrameworkCore;
using University_API_Backend.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// 2.- Connection with SQL Server
const string CONNECTIONNAME = "UniversityDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// 3.- Add context to services of builder
builder.Services.AddDbContext<UniversityDBContext>(optionsAction: options => options.UseSqlServer(connectionString));

// Add services to the container.

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
