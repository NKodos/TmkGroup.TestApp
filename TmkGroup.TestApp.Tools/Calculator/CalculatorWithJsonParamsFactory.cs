using TmkGroup.TestApp.Tools.Calculator.Exceptions;
using TmkGroup.TestApp.Tools.Calculator.Interfaces;

namespace TmkGroup.TestApp.Tools.Calculator;

public static class CalculatorWithJsonParamsFactory
{
    public static ICalculatorWithJsonParams GetInertiaMomentCalculator(string type)
    {
        var ns = typeof(CalculatorWithJsonParamsFactory).Namespace;

        var calculatorTypeName = $"{ns}.InertiaMoment.{type.Trim()}Calculator";
        var calculatorType = Type.GetType(calculatorTypeName);

        if (calculatorType is null)
        {
            throw new NotFoundCalculatorException($"Не удалось найти калькулятор с именем: {calculatorTypeName}");
        }

        var instance = (ICalculatorWithJsonParams) Activator.CreateInstance(calculatorType)!;

        return instance;
    }
}