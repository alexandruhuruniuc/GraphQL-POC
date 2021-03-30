using GraphQL.Types;

namespace GraphWQPOC.GraphQL.Types
{
    public class CarInputType : InputObjectGraphType
    {
        public CarInputType()
        {
            Name = "carInput";
            Field<NonNullGraphType<StringGraphType>>("make");
            Field<NonNullGraphType<StringGraphType>>("model");
            Field<NonNullGraphType<IntGraphType>>("productionYear");
            Field<NonNullGraphType<StringGraphType>>("fuelType");
            Field<NonNullGraphType<StringGraphType>>("color");
            Field<NonNullGraphType<StringGraphType>>("bodyType");
            Field<NonNullGraphType<IntGraphType>>("engineCapacity");
            Field<NonNullGraphType<StringGraphType>>("registrationPlate");
            Field<NonNullGraphType<IntGraphType>>("seatsNo");
        }
    }
}
