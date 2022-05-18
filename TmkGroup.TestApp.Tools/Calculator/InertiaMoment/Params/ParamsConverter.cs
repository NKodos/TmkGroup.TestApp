using System.Text.Json;
using TmkGroup.TestApp.Tools.Calculator.Exceptions;
using TmkGroup.TestApp.Tools.Calculator.Interfaces;

namespace TmkGroup.TestApp.Tools.Calculator.InertiaMoment.Params;

public class ParamsConverter
{
    public T? ConvertFromJson<T>(string jsonString) where T : ICalculatorParams
    {
        try
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<T>(jsonString, options);
        }
        catch (JsonException ex)
        {
            throw new BadParametersException("Не удалось десериализовать параметры калькулятора", ex);
        }
    }
}