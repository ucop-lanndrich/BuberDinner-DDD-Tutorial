using Microsoft.Extensions.DependencyInjection;

using BuberDinner.Application.Authentication.Commands.Register;
using BuberDinner.Application.Authentication.Common;
using BuberDinner.Application.Common.Behaviors;

using ErrorOr;

using MediatR;
using FluentValidation;
using System.Reflection;

namespace BuberDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);

        services.AddScoped(
            typeof(IPipelineBehavior<,>),
            typeof(ValidationBehavior<,>));

        // services.AddScoped<
        //     IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>,
        //     ValidateRegisterCommandBehavior>();

        // services.AddScoped<
        //     IValidator<RegisterCommand>,
        //     RegisterCommandValidator>();

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
}
