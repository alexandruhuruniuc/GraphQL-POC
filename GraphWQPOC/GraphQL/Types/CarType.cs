using GraphQL.Types;
using GraphWQPOC.Data.Entities;

namespace GraphWQPOC.GraphQL.Types
{
    public class CarType : ObjectGraphType<Car>
    {
        public CarType()
        {
            Field(c => c.Make).Description("Car make. e.g. Volvo, BMW, Mercedes-Benz");
            Field(c => c.Model).Description("Car model. e.g S60, C Class");
            Field(c => c.ProductionYear).Description("Production Year");
            Field(c => c.FuelType).Description("Fuel Type. e.q Diesel, Gasoline, Gasoline Hybrid");
            Field(c => c.Color).Description("Car color");
            Field(c => c.BodyType).Description("Body type. e.g. SUV, Sedan, Hatchback");
            Field(c => c.EngineCapacity).Description("Car engine capacity in cmc");
            Field(c => c.RegistrationPlate).Description("Registration Plate. e.q IS50HHH");
            Field(c => c.SeatsNo).Description("Number of seats");
        }
    }
}
