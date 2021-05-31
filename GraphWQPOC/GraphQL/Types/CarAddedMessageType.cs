using GraphQL.Types;
using GraphWQPOC.GraphQL.Messaging;

namespace GraphWQPOC.GraphQL.Types
{
    public class CarAddedMessageType : ObjectGraphType<CarAddedMessage>
    {
        public CarAddedMessageType()
        {
            Field(x => x.Make);
            Field(x => x.Model);
            Field(x => x.ProductionYear);
            Field(x => x.FuelType);
            Field(x => x.Color);
            Field(x => x.BodyType);
            Field(x => x.EngineCapacity);
            Field(x => x.RegistrationPlate);
            Field(x => x.SeatsNo);
        }
    }
}
