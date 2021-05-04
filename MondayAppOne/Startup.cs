using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using MondayLibs.Providers;
using Zell.UiPathAutomation.Orchestrator;
using Zell.UiPathAutomation.Other.Models;
using MondayAppOne.Services;
using System.Net.Http;
using System.Configuration;
using MondayLibs.Services;

namespace MondayAppOne
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // Resolve server error (JsonException: A possible object cycle was detected which is not supported) when initializing UiPathWebApi110
            services.AddControllers()
                    .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );

            services.AddScoped<IMondayDataProvider, MondayDataProvider>();
            services.AddScoped((s) => new GraphQLHttpClient(Configuration["MondayAPI:Host"], new NewtonsoftJsonSerializer()));
            services.AddScoped<IUiPathOrchestratorService, UiPathOrchestratorService>();      
            services.AddScoped<ITokenCustom, TokenCustom>();
            services.AddScoped((s) => new TokenRequest(Configuration["OrchestratorAPI:ClientId"], Configuration["OrchestratorAPI:UserKey"]));
            services.AddScoped((s) => new Uri(Configuration["OrchestratorAPI:Host"]));

            services.AddScoped<IStorageService, SubscriptionStorageService>();
            services.AddScoped<ITokenVerificationService, JwtTokenVerificationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
