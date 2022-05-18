using System.Text.Json.Nodes;
using Microsoft.Extensions.Configuration;
using TmkGroup.TestApp.Client;


var config = GetConfiguration();
var client = new InertiaMomentClient(config);

Console.Write("Введите тип трубы: ");
var type = Console.ReadLine();

Console.WriteLine("Введите параметры в формате ключ/значение:");
var json = GetSsonParams();

var result = await client.GetResultAsync(type, json.ToJsonString());

Console.Write(result);
Console.ReadKey();


IConfiguration GetConfiguration()
{
    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false);

    return builder.Build();
}

JsonObject GetSsonParams()
{
    var json = new JsonObject();

    do
    {
        var key = Console.ReadLine();
        var value = double.Parse(Console.ReadLine());

        if (key != null)
        {
            json.Add(key, value);
        }

        Console.WriteLine("Нажмите Enter, чтобы продолжить добавление, иначе ввод будет остановлен");

    } while (Console.ReadKey().Key == ConsoleKey.Enter);

    return json;
}