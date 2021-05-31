using GraphWQPOC.Data;
using GraphWQPOC.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GraphWQPOC.GraphQL;
using GraphWQPOC.GraphQL.Types;
using GraphWQPOC.GraphQL.Queries;
using Microsoft.Extensions.Logging;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphWQPOC.GraphQL.Messaging;
using GraphWQPOC.GraphQL.Mutations;
using GraphWQPOC.GraphQL.Subscriptions;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace GraphWQPOC
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<CarsDbContext>(options =>
                options.UseSqlServer(_config["ConnectionStrings:Cars"]));

            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.AddScoped<CarRepository>();
            services.AddScoped<CarQuery>();
            services.AddScoped<CarMutation>();
            services.AddScoped<CarsSchema>();
            services.AddScoped<CarType>();
            services.AddScoped<CarInputType>();
            services.AddScoped<CarSubscription>();
            services.AddScoped<CarAddedMessageType>();
            services.AddScoped<CarAddedMessage>();
            services.AddSingleton<CarMessageService>();

            services.AddGraphQL((options, provider) =>
                {
                    options.EnableMetrics = true;
                    var logger = provider.GetRequiredService<ILogger<Startup>>();
                    options.UnhandledExceptionDelegate = ctx =>
                        logger.LogError("{Error} occurred", ctx.OriginalException.Message);
                })
                .AddSystemTextJson() // For .NET Core 3+
                .AddNewtonsoftJson() // For everything else
                .AddErrorInfoProvider(opt => opt.ExposeExceptionStackTrace = true)
                .AddWebSockets()
                .AddDataLoader();
        }

        public void Configure(IApplicationBuilder app, CarsDbContext dbContext)
        {
            app.UseWebSockets();
            app.UseGraphQLWebSockets<CarsSchema>("/graphql");
            app.UseGraphQL<CarsSchema>();
            app.UseGraphQLPlayground(new PlaygroundOptions());
            dbContext.Seed();
        }
    }
}
