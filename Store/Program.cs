using Application;
using Infrastructure;
using Infrastructure.Context;
using Infrastructure.SeedData;
using Microsoft.EntityFrameworkCore;
using Store;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(optinos =>
{
    optinos.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
});

builder.Services.AddWebServiceCollecton();
builder.Services.AddScoped<SeedData>();
//builder.Services.AddInfrastructureService();
builder.Services.ApplicationServices();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var seeder = services.GetRequiredService<SeedData>();
        seeder.Seed();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"ÎØÇ ÏÑ Seed ˜ÑÏä Ï?ÊÇ: {ex.Message}");
    }
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseCors(p => p.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));
app.UseStaticFiles();
app.MapControllers();

app.Run();
