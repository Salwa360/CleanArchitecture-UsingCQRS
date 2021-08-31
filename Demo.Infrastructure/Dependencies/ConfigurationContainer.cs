using Demo.Infrastructure.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;

namespace Demo.Infrastructure.Dependencies
{
    public static class ConfigurationContainer
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app , ILoggerFactory loggerFactory)
        {
            app.UseMiddleware<CustomExceptionMiddleware>();
           // loggerFactory.AddSerilog();
        }
        

    }
}
