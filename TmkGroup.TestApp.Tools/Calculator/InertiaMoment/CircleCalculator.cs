using TmkGroup.TestApp.Tools.Calculator.InertiaMoment.Params;

namespace TmkGroup.TestApp.Tools.Calculator.InertiaMoment;

public class CircleCalculator : InertiaMomentCalculator<CircleParams>
{
    protected override InertiaMomentResult Execute(CircleParams paramsObject)
    {
        var xy = Math.PI * Math.Pow(paramsObject.D, 4) / 64;
        
        return new InertiaMomentResult(xy);
    }
}