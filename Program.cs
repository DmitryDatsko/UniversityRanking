using Microsoft.EntityFrameworkCore;
using UniversityRanking.Data;
using UniversityRanking.DbInitializer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddTransient<IDbInitializer, DbInitializer>();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


SeedDatabase();

app.Run();

void SeedDatabase()
{
    using var scope = app.Services.CreateScope();
    var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
    dbInitializer.Initialize();
}