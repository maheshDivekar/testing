using Microsoft.AspNetCore.Http;
using ServiceLayer.AbstractServices;
using ServiceLayer.ConcreteServices;
using RepositoryLayer.IRepository;
using RepositoryLayer.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Service Injected
builder.Services.AddScoped(typeof(IAuthenticateRepository), typeof(AuthenticateRepository));
builder.Services.AddScoped<IAuthenticate, Authenticate>();
//builder.Services.AddScoped<ICustomService<Resultss>, ResultService>();
//builder.Services.AddScoped<ICustomService<Departments>, DepartmentsService>();
//builder.Services.AddScoped<ICustomService<SubjectGpas>, SubjectGpasService>();
#endregion

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
