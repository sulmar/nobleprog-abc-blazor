using Domain.Models;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp.Pages.Customers;

public partial class List
{

    // [Inject]
    // private HttpClient Http { get; set; } 

    private IEnumerable<Customer>? customers;

    protected override async Task OnInitializedAsync()
    {
        customers = await Http.GetFromJsonAsync<IEnumerable<Customer>>("api/customers");
    }

}
