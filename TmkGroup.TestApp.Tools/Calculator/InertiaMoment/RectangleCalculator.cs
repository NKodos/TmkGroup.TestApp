using TmkGroup.TestApp.Tools.Calculator.InertiaMoment.Params;

namespace TmkGroup.TestApp.Tools.Calculator.InertiaMoment;

public class RectangleCalculator : InertiaMomentCalculator<RectangleParams>
{
    protected override InertiaMomentResult Execute(RectangleParams paramsObject)
    {
        var x = paramsObject.B * Math.Pow(paramsObject.H, 3) / 12;
        var y = paramsObject.H * Math.Pow(paramsObject.B, 3) / 12;

        return new InertiaMomentResult(x, y);
    }
}