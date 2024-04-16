using Forum.Application.Services;
using Forum.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Forum.Application
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddApplicationLayer(
            this IServiceCollection services)
        {
            services.AddScoped<UserService>();
            services.AddScoped<CommentService>();
            services.AddScoped<TopicService>();
            services.AddScoped<AuthenticationService>();
            _ = services.AddSingleton<PasswordService>();

            return services;
        }
    }
}
