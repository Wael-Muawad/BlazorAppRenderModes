using BlazorAppAutoRender.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.Services.AddTransient<ISomeRandomData, SomeRandomDataClient>();

builder.Services.AddScoped(ht => new HttpClient()
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});


await builder.Build().RunAsync();
