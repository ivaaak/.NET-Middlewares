using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Middleware.Demo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPrinter, Printer>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMiddleware<CustomMiddleware>();

            app.Run(async context => await context.Response.WriteAsync("ending now..."));
        }
    }
}
