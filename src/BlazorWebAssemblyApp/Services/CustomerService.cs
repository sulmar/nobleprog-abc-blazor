using Domain.Models;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp.Services;

// Generic Template
public interface IEntityService<T>
    where T : class
{
    Task<IEnumerable<T>?> GetAll();
}

public interface ICustomerService : IEntityService<Customer>
{
    Task<Customer> GetByEmail(string email);
}


public interface IProductService : IEntityService<Product>
{
}

// Primary Constructor .NET 9
public class CustomerService(HttpClient http) : ICustomerService
{    
    public Task<IEnumerable<Customer>?> GetAll() => http.GetFromJsonAsync<IEnumerable<Customer>>("api/customers");

    public Task<Customer> GetByEmail(string email)
    {
        throw new NotImplementedException();
    }
}


public class ProductService(HttpClient http) : IProductService
{
    public Task<IEnumerable<Product>?> GetAll() => http.GetFromJsonAsync<IEnumerable<Product>>("api/products");
}

