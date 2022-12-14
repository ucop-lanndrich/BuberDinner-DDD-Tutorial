namespace BuberDinner.Domain.Common.Errors;
using ErrorOr;

public static partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCredentials => Error.Validation(
            code: "Auth.InvalidCredentials",
            description: "Way to forget your credentials, idiot.  Wow.");
    }
}