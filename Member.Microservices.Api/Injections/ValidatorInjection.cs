using FluentValidation;

namespace Member.Microservices.Api.Injections;

public static class ValidatorsInjection
{
    public static void AddValidators(this IServiceCollection services)
    {
        //services.AddScoped<IValidator<UserDto>, UserDtoValidator>();
    }
}

