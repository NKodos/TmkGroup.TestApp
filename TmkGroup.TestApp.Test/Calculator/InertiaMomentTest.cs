using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TmkGroup.TestApp.Tools.Calculator.InertiaMoment;
using TmkGroup.TestApp.Tools.Calculator.InertiaMoment.Params;

namespace TmkGroup.TestApp.Test.Calculator;

[TestClass]
public class InertiaMomentTest
{
    [TestMethod]
    public void RectangleCalculator()
    {
        var calculator = new RectangleCalculator();
        var param = new RectangleParams {B = 5, H = 3};

        var result = calculator.Calculate(param);

        Assert.AreEqual(result.X, 11.25);
        Assert.AreEqual(result.Y, 31.25);
    }

    [TestMethod]
    public void CircleCalculator()
    {
        var calculator = new CircleCalculator();
        var param = new CircleParams { D = 15};

        var result = calculator.Calculate(param);

        Assert.AreEqual(result.X, result.Y);
        Assert.AreEqual(Math.Round(result.X, 2), 2485.05);
    }

    [TestMethod]
    public void SquareCalculator()
    {
        var calculator = new SquareCalculator();
        var param = new SquareParams { B = 5 };

        var result = calculator.Calculate(param);

        Assert.AreEqual(result.X, result.Y);
        Assert.AreEqual(Math.Round(result.X, 2), 52.08);
    }

    [TestMethod]
    public void RingCalculator()
    {
        var calculator = new RingCalculator();
        var param = new RingParams { D1 = 10, D2 = 8};

        var result = calculator.Calculate(param);

        Assert.AreEqual(result.X, result.Y);
        Assert.AreEqual(Math.Round(result.X, 2), 289.81);
    }

    [TestMethod]
    public void IsoscelesTriangleCalculator()
    {
        var calculator = new IsoscelesTriangleCalculator();
        var param = new IsoscelesTriangleParams { H = 10, B = 6 };

        var result = calculator.Calculate(param);

        Assert.AreEqual(Math.Round(result.X, 2), 166.67);
        Assert.AreEqual(result.Y, 2, 45);
    }
}