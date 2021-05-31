namespace GraphWQPOC.GraphQL.Messaging
{
    public class CarAddedMessage
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int ProductionYear { get; set; }

        public string RegistrationPlate { get; set; }

        public string BodyType { get; set; }

        public int SeatsNo { get; set; }

        public string FuelType { get; set; }

        public int EngineCapacity { get; set; }
    }
}
