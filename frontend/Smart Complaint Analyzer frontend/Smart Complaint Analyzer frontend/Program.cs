using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Smart_Complaint_Analyzer_frontend;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//model with backend in hugging face

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://127.0.0.1:8000/") 
});

builder.Services.AddScoped<ModelApiService>();

await builder.Build().RunAsync();
