using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Solution;

namespace Program;
public class Program
{
    public static void Main(string[] args)
    {
            var builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddSingleton<IService, Service>();
            builder.Services.AddSingleton<IClient, Client>();

            var app = builder.Build();

            var client = app.Services.GetRequiredService<IClient>();
            client.Start();

            app.Run();
    }
}