using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TmkGroup.TestApp.Tools.Calculator.Exceptions;

namespace TmkGroup.TestApp.Web.ExceptionFilters;

public class NotFoundCalculatorExceptionFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        if (context.Exception is NotFoundCalculatorException)
        {
            context.Result = new NotFoundObjectResult($"{context.Exception.Message} " +
                                                      $"\nStackTrace: {context.Exception.StackTrace}");
        }
    }
}