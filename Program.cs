using Microsoft.EntityFrameworkCore;
using rugby_stat_tracker.Data;
using rugby_stat_tracker.Interfaces;
using rugby_stat_tracker.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// NOTE: configure api to reject incorrect accept value
builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
});
// NOTE: Tailors error messages with addiontal info (Responses)
//builder.Services.AddProblemDetails(options =>
//{
//    options.CustomizeProblemDetails = ctx =>
//    {
//        ctx.ProblemDetails.Extensions.Add("additionalInfo", "Additional Info");
//        ctx.ProblemDetails.Extensions.Add("server",
//            Environment.MachineName);
//    };
//});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();

var app = builder.Build();

//<-------------------------------------------->

// Configure the HTTP request pipeline. (Middleware)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapControllers();

app.Run();
