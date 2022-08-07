using Microsoft.EntityFrameworkCore;
using RESTAPI.Models;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration; //allows to access and set up the config
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CaseStudy_Grp3Context>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));



var domain = "_domain";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: domain, policy =>
    {
        policy.WithOrigins("*");
    });
});



var app = builder.Build();

//app.UseCors(domain);
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
    services.AddSingleton<CaseStudy_Grp3Context>();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

