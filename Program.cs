using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SearchDemonSlayerAPI;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registra o HttpClient com o endereço base da API de Demon Slayer
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://www.demonslayer-api.com/")
});

await builder.Build().RunAsync();
