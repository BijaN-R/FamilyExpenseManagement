using Application.Services;
using Contracts.Repositories;
using Contracts.Services;
using DataAccess;
using DataAccess.AutoMapper;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);


// Read appsettings.json configuration
builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

// Add services to the container.

builder.Services.AddDbContext<ExpenseManagerDbContext>(options =>
{
    options.LogTo(msg => Debug.WriteLine(msg)).EnableSensitiveDataLogging();
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}
    );

builder.Services.AddControllers();

builder.Services.AddScoped<IFamilyMembersRepository, FamilyMembersRepository>();
builder.Services.AddScoped<IBankAccountRepository, BankAccountRepository>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IBankAccountService, BankAccountService>();

builder.Services.AddAutoMapper(typeof(BankAccountProfile));
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
