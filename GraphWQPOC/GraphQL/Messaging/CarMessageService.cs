using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using GraphWQPOC.Data.Entities;

namespace GraphWQPOC.GraphQL.Messaging
{
    public class CarMessageService
    {
        private readonly ISubject<CarAddedMessage> _messageStream = new ReplaySubject<CarAddedMessage>(1);

        public CarAddedMessage AddCarAddedMessage(Car car)
        {
            var message = new CarAddedMessage
            {
                BodyType = car.BodyType,
                Color = car.Color,
                EngineCapacity = car.EngineCapacity,
                FuelType = car.FuelType,
                Make = car.Make,
                Model = car.Model,
                ProductionYear = car.ProductionYear,
                RegistrationPlate = car.RegistrationPlate,
                SeatsNo = car.SeatsNo
            };

            _messageStream.OnNext(message);

            return message;
        }

        public IObservable<CarAddedMessage> GetMessages()
        {
            return _messageStream.AsObservable();
        }
    }
}
