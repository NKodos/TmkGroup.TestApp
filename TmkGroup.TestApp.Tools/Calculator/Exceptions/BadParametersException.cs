namespace TmkGroup.TestApp.Tools.Calculator.Exceptions;

public class BadParametersException : Exception
{
    public BadParametersException(string message) 
        : base(message) { }

    public BadParametersException(string message, Exception innerException) 
        : base(message, innerException) { }
}