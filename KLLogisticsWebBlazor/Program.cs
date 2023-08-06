using KLLogisticsWebBlazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using MudBlazor.Services;

//Register Syncfusion license 
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTkyMjc4OEAzMjMxMmUzMjJlMzNNaWoyMUtJWVNzczYzQXl1RlMyb0dxTkdmMFlkUHVJNnNpdlhxeUpsdUIwPQ==");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();
builder.Services.AddSyncfusionBlazor();
await builder.Build().RunAsync();
