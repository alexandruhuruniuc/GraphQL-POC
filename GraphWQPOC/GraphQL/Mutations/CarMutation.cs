using GraphQL;
using GraphQL.Types;
using GraphWQPOC.Data.Entities;
using GraphWQPOC.GraphQL.Types;
using GraphWQPOC.Repositories;

namespace GraphWQPOC.GraphQL.Mutations
{
    public class CarMutation : ObjectGraphType
    {
        public CarMutation(CarRepository repo)
        {
            FieldAsync<CarType>(
                "createCar",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CarInputType>> {Name = "car"}),
                resolve: async context =>
                {
                    var car = context.GetArgument<Car>("car");
                    return await repo.AddCar(car);
                });
        }
    }
}
