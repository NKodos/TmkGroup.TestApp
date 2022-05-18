using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TmkGroup.TestApp.Tools.Calculator.Exceptions;

namespace TmkGroup.TestApp.Web.ExceptionFilters;

public class BadParametersExceptionFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        if (context.Exception is BadParametersException)
        {
            context.Result = new BadRequestObjectResult($"{context.Exception.Message} " +
                                                      $"\nStackTrace: {context.Exception.StackTrace}");
        }
    }
}