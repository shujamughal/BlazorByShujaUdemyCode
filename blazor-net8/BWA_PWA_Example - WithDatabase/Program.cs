using BWA_PWA_Example.Models.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BWA_PWA_Example
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<NoteRepository>(new NoteRepository("Data Source=(localdb)\\ProjectModels;Initial Catalog=MyDB;Integrated Security=True;"));

            await builder.Build().RunAsync();
        }
    }
}
