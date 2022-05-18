namespace TmkGroup.TestApp.Tools.Calculator.InertiaMoment;

public class InertiaMomentResult
{
    public InertiaMomentResult(double xy)
    {
        X = Y = xy;
    }

    public InertiaMomentResult(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }

    public double Y { get; }
}