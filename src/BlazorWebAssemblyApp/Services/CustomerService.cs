using Domain.Models;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp.Services;

public interface ICustomerService
{
    Task<IEnumerable<Customer>?> GetAll();
}

public class CustomerService : ICustomerService
{
    private HttpClient http;

    public CustomerService(HttpClient http)
    {
        this.http = http;
    }

    public Task<IEnumerable<Customer>?> GetAll()
    {
        return http.GetFromJsonAsync<IEnumerable<Customer>>("api/customers");
    }
}
