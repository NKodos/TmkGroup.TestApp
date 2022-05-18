using Microsoft.AspNetCore.Mvc;
using TmkGroup.TestApp.Web.ExceptionFilters;
using TmkGroup.TestApp.Web.Models;
using InertiaMomentCalculator = TmkGroup.TestApp.Web.Calculator.InertiaMomentCalculator;


namespace TmkGroup.TestApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [NotFoundCalculatorExceptionFilter]
    [BadParametersExceptionFilter]
    public class InertiaMomentController : ControllerBase
    {
        [HttpGet("{type}")]
        public InertiaMoment Get(string type, [FromQuery] string paramJson)
        {
            var calculator = new InertiaMomentCalculator(type, paramJson);
            return calculator.Calculate();
        }
    }
}