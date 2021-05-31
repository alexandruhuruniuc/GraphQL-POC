using GraphQL;
using GraphQL.Types;
using GraphWQPOC.Data.Entities;
using GraphWQPOC.GraphQL.Messaging;
using GraphWQPOC.GraphQL.Types;
using GraphWQPOC.Repositories;

namespace GraphWQPOC.GraphQL.Mutations
{
    public class CarMutation : ObjectGraphType
    {
        public CarMutation(CarRepository repo, CarMessageService messageService)
        {
            FieldAsync<CarType>(
                "createCar",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CarInputType>> {Name = "car"}),
                resolve: async context =>
                {
                    var car = context.GetArgument<Car>("car");
                    await repo.AddCar(car);
                    messageService.AddCarAddedMessage(car);

                    return car;
                });
        }
    }
}
