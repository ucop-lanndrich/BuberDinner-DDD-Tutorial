using System.Net;
// using System.Text.Json;
// using System.Text.Json.Serialization;
// using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BuberDinner.Api.Middleware;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var code = HttpStatusCode.InternalServerError; // 500 if unexpected

        // if (exception is NotFoundException) code = HttpStatusCode.NotFound;
        // else if (exception is UnauthorizedException) code = HttpStatusCode.Unauthorized;
        // else if (exception is ForbiddenException) code = HttpStatusCode.Forbidden;
        // else if (exception is BadRequestException) code = HttpStatusCode.BadRequest;

        var result = JsonConvert.SerializeObject(new { error = "An error occurred while processing your request." });
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)code;
        return context.Response.WriteAsync(result);
    }
}