using TmkGroup.TestApp.Tools.Calculator;
using TmkGroup.TestApp.Web.Models;

namespace TmkGroup.TestApp.Web.Calculator
{
    public class InertiaMomentCalculator
    {
        private readonly string _type;
        private readonly string _paramJson;

        public InertiaMomentCalculator(string type, string paramJson)
        {
            _type = type;
            _paramJson = paramJson;
        }

        public InertiaMoment Calculate()
        {
            var calculator = CalculatorWithJsonParamsFactory.GetInertiaMomentCalculator(_type);
            var result = calculator.Calculate(_paramJson);

            return new InertiaMoment(result.X, result.Y);
        }
    }
}