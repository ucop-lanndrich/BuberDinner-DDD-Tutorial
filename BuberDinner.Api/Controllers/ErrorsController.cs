namespace BuberDinner.Api.Controllers;

using Microsoft.AspNetCore.Mvc;

public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        Exception? exception = HttpContext
            .Features
            .Get<Microsoft.AspNetCore.Diagnostics.IExceptionHandlerFeature>()?
            .Error;
        return Problem(statusCode: 500, title: exception?.Message);
    }
}