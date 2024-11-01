using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;

public abstract class Client
{
    protected static readonly HttpClient HttpClient;

    static Client()
    {
        HttpClient = new HttpClient();
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        HttpClient.BaseAddress = new Uri(config["BaseUri"]);
        HttpClient.DefaultRequestHeaders.Accept.Clear();
        HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
}
