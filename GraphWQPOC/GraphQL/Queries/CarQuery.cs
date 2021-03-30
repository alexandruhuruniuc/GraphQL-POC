using GraphQL.Types;
using GraphWQPOC.GraphQL.Types;
using GraphWQPOC.Repositories;
using GraphQL;

namespace GraphWQPOC.GraphQL.Queries
{
    public class CarQuery : ObjectGraphType
    {
        public CarQuery(CarRepository carRepository)
        {
            Field<ListGraphType<CarType>>(
                "cars",
                resolve: context => carRepository.GetAll());

            Field<ListGraphType<CarType>>(
                "carsByColor",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "color" }),
                resolve: context =>
                {
                    var color = context.GetArgument<string>("color");
                    return carRepository.GetByColor(color);
                });
        }
    }
}
