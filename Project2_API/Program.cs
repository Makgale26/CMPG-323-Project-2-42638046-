using Microsoft.EntityFrameworkCore;
using Project2_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure DbContext to use SQL Server with connection string from appsettings.json
builder.Services.AddDbContext<sqlDatabaseCmpg323Context>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Swagger setup
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

// No authentication middleware added

app.UseAuthorization();

app.MapControllers();

app.Run();
