using FinanceManager.Application.Transactions.Commands.CreateTransaction;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FinanceManager.Application.Transactions;
using MediatR;
using FinanceManager.Persistence.Repositories;
using FinanceManager.Domain.Interfaces;
using FinanceManager.Persistence.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options => options
                .UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(x => x.RegisterServicesFromAssemblies(typeof(CreateTransactionCommandHandler).Assembly));

////////////////////////////////////////////////////////////////////////////
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
///////////////////////////////////////////////////////////////////////////

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

