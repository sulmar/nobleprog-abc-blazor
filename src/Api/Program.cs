using Bogus;
using Domain.Abstractions;
using Domain.Models;
using Infrastructure;
using Infrastructure.Fakers;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICustomerRepository, InMemoryCustomerRepository>();
builder.Services.AddScoped<Faker<Customer>, CustomerFaker>();
builder.Services.AddScoped<IEnumerable<Customer>>(sp =>
{
    var faker = sp.GetRequiredService<Faker<Customer>>();

    return faker.Generate(100);

});


builder.Services.AddScoped<IProductRepository, InMemoryProductRepository>();
builder.Services.AddScoped<Faker<Product>, ProductFaker>();
builder.Services.AddScoped<IEnumerable<Product>>(sp => sp.GetRequiredService<Faker<Product>>().Generate(20));

builder.Services.AddScoped<IMessageSender, FakeMessageSender>();


builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
{
    policy.WithOrigins("https://localhost:7282")
    .WithMethods("GET")
    .AllowAnyHeader();

    // policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));
    
 
var app = builder.Build();

app.UseCors();

app.MapGet("/", () => "Hello Api!");

// Minimal Api

app.MapGet("/api/customers", async (ICustomerRepository repository)
    => await repository.GetAllAsync() ); // F9

app.MapGet("/api/customers/{id}", async (ICustomerRepository repository, int id)
    => await repository.GetByIdAsync(id)); // F9

app.MapGet("/api/products", async (IProductRepository repository)
    => await repository.GetAllAsync());

app.Run();
