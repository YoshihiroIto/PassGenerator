using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.Toast;
using CurrieTechnologies.Razor.Clipboard;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace PassGenerator
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddClipboard();
            builder.Services.AddBlazoredToast();

            await builder.Build().RunAsync();
        }
    }
}
