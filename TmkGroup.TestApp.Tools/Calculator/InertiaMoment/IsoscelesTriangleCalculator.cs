using TmkGroup.TestApp.Tools.Calculator.InertiaMoment.Params;

namespace TmkGroup.TestApp.Tools.Calculator.InertiaMoment;

public class IsoscelesTriangleCalculator : InertiaMomentCalculator<IsoscelesTriangleParams>
{
    protected override InertiaMomentResult Execute(IsoscelesTriangleParams paramsObject)
    {
        var x = paramsObject.B * Math.Pow(paramsObject.H, 3) / 36;
        var y = paramsObject.H * Math.Pow(paramsObject.B, 3) / 48;

        return new InertiaMomentResult(x, y);
    }
}