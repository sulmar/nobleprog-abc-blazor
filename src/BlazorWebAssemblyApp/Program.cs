using BlazorWebAssemblyApp;
using BlazorWebAssemblyApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7081") });

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddSingleton<ApplicationState>(); // Registered

builder.Services.AddCascadingValue<ApplicationState>(f => f.GetRequiredService<ApplicationState>());
builder.Services.AddCascadingValue<int>(f => 20);
builder.Services.AddCascadingValue<string>("n", f => "Contor");
builder.Services.AddCascadingValue<string>("t", f => "dark");

await builder.Build().RunAsync();
