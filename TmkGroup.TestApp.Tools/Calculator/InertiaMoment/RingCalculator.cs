using TmkGroup.TestApp.Tools.Calculator.InertiaMoment.Params;

namespace TmkGroup.TestApp.Tools.Calculator.InertiaMoment;

public class RingCalculator : InertiaMomentCalculator<RingParams>
{
    protected override InertiaMomentResult Execute(RingParams paramsObject)
    {
        Validate(paramsObject);

        var c = paramsObject.D1 / paramsObject.D2;
        var xy = Math.PI * Math.Pow(paramsObject.D2, 4) / 64 * (1 - Math.Pow(c, 4));

        return new InertiaMomentResult(xy);
    }

    private void Validate(RingParams paramsObject)
    {
        if (paramsObject.D2 < paramsObject.D1)
        {
            (paramsObject.D1, paramsObject.D2) = (paramsObject.D2, paramsObject.D1);
        }
    }
}