using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Smart_Complaint_Analyzer_frontend;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//model with backend in hugging face

var hfSpaceUrl = "https://dewapura-smart-airline-passenger-complaint-analyzer.hf.space/";

// localhost during development, hf.space in production:
var apiBase = builder.HostEnvironment.IsDevelopment()
    ? "http://127.0.0.1:8000/"        // local backend while developing
    : hfSpaceUrl;                     // deployed backend (Hugging Face Space)


builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(apiBase) 
});

builder.Services.AddScoped<ModelApiService>();

await builder.Build().RunAsync();

