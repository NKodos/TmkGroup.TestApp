using TmkGroup.TestApp.Tools.Calculator.InertiaMoment.Params;

namespace TmkGroup.TestApp.Tools.Calculator.InertiaMoment;

public class SquareCalculator : InertiaMomentCalculator<SquareParams>
{
    protected override InertiaMomentResult Execute(SquareParams paramsObject)
    {
        var xy = Math.Pow(paramsObject.B, 4) / 12;
        
        return new InertiaMomentResult(xy);
    }
}