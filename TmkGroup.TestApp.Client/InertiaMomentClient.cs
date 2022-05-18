using Microsoft.Extensions.Configuration;

namespace TmkGroup.TestApp.Client;

public class InertiaMomentClient
{
    private readonly IConfiguration _configuration;

    public InertiaMomentClient(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<string> GetResultAsync(string type, string toJsonString)
    {
        var connectionWeb = _configuration["Connections:Web"];
        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();

        var stringTask = client.GetStringAsync($"{connectionWeb}/api/InertiaMoment/{type}?paramJson={toJsonString}");
        return await stringTask;
    }
}