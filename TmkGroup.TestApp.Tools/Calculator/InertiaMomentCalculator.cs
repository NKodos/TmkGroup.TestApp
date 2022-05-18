using TmkGroup.TestApp.Tools.Calculator.InertiaMoment;
using TmkGroup.TestApp.Tools.Calculator.InertiaMoment.Params;
using TmkGroup.TestApp.Tools.Calculator.Interfaces;

namespace TmkGroup.TestApp.Tools.Calculator;

public abstract class InertiaMomentCalculator<T> : ICalculatorWithJsonParams where T : ICalculatorParams
{
    public InertiaMomentResult Calculate(string jsonParams)
    {
        var paramsObject = DeserializeParams(jsonParams);
        return Execute(paramsObject);
    }

    public InertiaMomentResult Calculate(T paramsObject)
    {
        return Execute(paramsObject);
    }

    protected abstract InertiaMomentResult Execute(T paramsObject);

    private T? DeserializeParams(string paramsJson)
    {
        var converter = new ParamsConverter();
        return converter.ConvertFromJson<T>(paramsJson);
    }
}