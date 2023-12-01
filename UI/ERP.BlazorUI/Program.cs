using ERP.Application.StudentApp.Interfaces;
using ERP.Application.StudentApp.Students;
using ERP.Application.StudentApp.Students.Interfaces;
using ERP.BlazorUI.Components;
using ERP.Repository.InMemory;
using ERP.Repository.SQLite;
using Microsoft.EntityFrameworkCore;

using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Configuration of EF Core SQLite
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDbContext<StudentDbContext>(opt => opt.UseSqlite(configuration.GetConnectionString("StudentDatabase"),
     b => b.MigrationsAssembly("ERP.Repository.SQLite")));



// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();

builder.Services.AddSingleton<IStudentRepository, StudentRepositoryIM>();
builder.Services.AddScoped<IViewStudentsByNameUseCase, ViewStudentsByNameUseCase>();
builder.Services.AddScoped<IAddStudentUseCase, AddStudentUseCase>();
builder.Services.AddScoped<IViewStudentById, ViewStudentById>();
builder.Services.AddScoped<IEditStudentUseCase, EditStudentUseCase>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
