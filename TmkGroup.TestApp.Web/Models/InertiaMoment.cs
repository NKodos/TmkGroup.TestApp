namespace TmkGroup.TestApp.Web.Models;

public class InertiaMoment
{
    public InertiaMoment(double xy)
    {
        X = Y = xy;
    }

    public InertiaMoment(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }

    public double Y { get; }
}