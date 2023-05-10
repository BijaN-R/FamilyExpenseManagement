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

//اینجکت ریپازیتوری‌ها
builder.Services.AddScoped<IFamilyMembersRepository, FamilyMembersRepository>();
builder.Services.AddScoped<IBankAccountRepository, BankAccountRepository>();
builder.Services.AddScoped<ITransactionCategoriesRepository, TransactionCategoriesRepository>();
builder.Services.AddScoped<ITransactionsRepository, TransactionRepository>();
//اینجکت سرویس‌ها
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IBankAccountService, BankAccountService>();
builder.Services.AddScoped<ITransactionCategoriesService, TransactionCategoriesService>();
builder.Services.AddScoped<ITransactionsService, TransactionService>();

//اینجکت AutoMapper
builder.Services.AddAutoMapper(typeof(BankAccountProfile));
builder.Services.AddAutoMapper(typeof(TransactionCategoryProfile));
builder.Services.AddAutoMapper(typeof(TransactionProfile));

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
