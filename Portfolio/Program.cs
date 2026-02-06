using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Services;
using Portfolio.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// MudBlazor
builder.Services.AddMudServices();
MudGlobal.InputDefaults.Variant = Variant.Outlined;
MudGlobal.InputDefaults.Margin = Margin.Dense;
MudGlobal.Rounded = true;
MudGlobal.GridDefaults.Spacing = 3;

builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();