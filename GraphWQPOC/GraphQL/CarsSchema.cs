using GraphQL.Types;
using GraphWQPOC.GraphQL.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;
using GraphWQPOC.GraphQL.Mutations;
using GraphWQPOC.GraphQL.Subscriptions;

namespace GraphWQPOC.GraphQL
{
    public class CarsSchema : Schema
    {
        public CarsSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<CarQuery>();
            Mutation = provider.GetRequiredService<CarMutation>();
            Subscription = provider.GetRequiredService<CarSubscription>();
        }
    }
}
