using Contracts;
using LoggerService;

namespace CompanyEmployees.Extensions
{
    public static class ServiceExtensions
    {
        // CORS
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                // Decide which origins, methods or headers to allow : builder.AllowAnyOrigin() or .AllowAnyMethod() or .AllowAnyHeader()
                builder.WithOrigins("https://example.com")
                .WithMethods("POST", "GET") // or PUT, DELETE
                .WithHeaders("accept", "content-type"));
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {
            });

        // Logger
        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

    }
}
