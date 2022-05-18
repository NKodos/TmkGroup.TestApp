using TmkGroup.TestApp.Tools.Calculator.InertiaMoment;

namespace TmkGroup.TestApp.Tools.Calculator.Interfaces;

public interface ICalculatorWithJsonParams
{
    InertiaMomentResult Calculate(string jsonParams);
}