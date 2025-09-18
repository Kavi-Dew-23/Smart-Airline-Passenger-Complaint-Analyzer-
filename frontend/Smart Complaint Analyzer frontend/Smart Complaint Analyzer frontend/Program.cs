using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Smart_Complaint_Analyzer_frontend;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://dewapura-smart-airline-passenger-complaint-analyzer.hf.space/")
});

builder.Services.AddScoped<ModelApiService>();

await builder.Build().RunAsync();

