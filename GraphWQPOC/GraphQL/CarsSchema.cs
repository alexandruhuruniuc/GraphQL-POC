using GraphQL.Types;
using GraphWQPOC.GraphQL.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;
using GraphWQPOC.GraphQL.Mutations;

namespace GraphWQPOC.GraphQL
{
    public class CarsSchema : Schema
    {
        public CarsSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<CarQuery>();
            Mutation = provider.GetRequiredService<CarMutation>();
        }
    }
}
