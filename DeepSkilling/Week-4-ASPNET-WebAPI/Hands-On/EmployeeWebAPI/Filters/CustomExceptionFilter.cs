using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeWebAPI.Filters;

public class CustomExceptionFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        // Log exception details to a file
        string logPath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "exception-log.txt"
        );

        string logMessage =
            $"Date: {DateTime.Now}\n" +
            $"Exception: {context.Exception.Message}\n" +
            $"Stack Trace: {context.Exception.StackTrace}\n" +
            "----------------------------------------\n";

        File.AppendAllText(logPath, logMessage);

        // Return HTTP 500 response
        context.Result = new ObjectResult(new
        {
            Message = "An unexpected error occurred.",
            Error = context.Exception.Message
        })
        {
            StatusCode = StatusCodes.Status500InternalServerError
        };

        context.ExceptionHandled = true;
    }
}
