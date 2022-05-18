namespace TmkGroup.TestApp.Tools.Calculator.Exceptions;

public class NotFoundCalculatorException : Exception
{
    public NotFoundCalculatorException(string message) 
        : base(message) { }

    public NotFoundCalculatorException(string message, Exception innerException) 
        : base(message, innerException) { }
}