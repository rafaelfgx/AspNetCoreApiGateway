using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace GatewayService
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(IApplicationBuilder application)
        {
            application.UseHsts();
            application.UseHttpsRedirection();
            application.UseOcelot().Wait();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOcelot(_configuration).AddDelegatingHandler<Handler>(true);
        }
    }
}
