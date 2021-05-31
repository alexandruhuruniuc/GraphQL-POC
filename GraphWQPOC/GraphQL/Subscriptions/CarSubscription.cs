using GraphQL.Resolvers;
using GraphQL.Types;
using GraphWQPOC.GraphQL.Messaging;
using GraphWQPOC.GraphQL.Types;

namespace GraphWQPOC.GraphQL.Subscriptions
{
    public class CarSubscription : ObjectGraphType
    {
        public CarSubscription(CarMessageService messageService)
        {
            Name = "subscription";

            AddField(new EventStreamFieldType
            {
                Name = "carAdded",
                Type = typeof(CarAddedMessageType),
                Resolver = new FuncFieldResolver<CarAddedMessage>(m => m.Source as CarAddedMessage),
                Subscriber = new EventStreamResolver<CarAddedMessage>(m=> messageService.GetMessages())
            });
        }
    }
}
