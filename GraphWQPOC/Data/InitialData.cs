using GraphWQPOC.Data.Entities;
using System.Linq;

namespace GraphWQPOC.Data
{
    public static class InitialData
    {
        public static void Seed(this CarsDbContext dbContext)
        {
            if (!dbContext.Cars.Any())
            {
                dbContext.Cars.Add(new Car
                {
                    Id = 1,
                    Make = "Peugeot",
                    Model = "407",
                    Color = "Blue",
                    BodyType = "Sedan",
                    FuelType = "Diesel",
                    ProductionYear = 2005,
                    RegistrationPlate = "IS14CAR",
                    SeatsNo = 5,
                    EngineCapacity = 1598
                });

                dbContext.Cars.Add(new Car
                {
                    Id = 2,
                    Make = "Hyundai",
                    Model = "Tucson",
                    Color = "Sunset Red",
                    BodyType = "SUV",
                    FuelType = "Gasoline",
                    ProductionYear = 2020,
                    RegistrationPlate = "IS30CAR",
                    SeatsNo = 5,
                    EngineCapacity = 1598
                });

                dbContext.Cars.Add(new Car
                {
                    Id = 3,
                    Make = "Hyundai",
                    Model = "i30",
                    Color = "White",
                    BodyType = "Hatchback",
                    FuelType = "Gasoline",
                    ProductionYear = 2014,
                    RegistrationPlate = "IS68CAR",
                    SeatsNo = 5,
                    EngineCapacity = 1398
                });

                dbContext.Cars.Add(new Car
                {
                    Id = 4,
                    Make = "Hyundai",
                    Model = "Tucson",
                    Color = "Amazon Grey",
                    BodyType = "SUV",
                    FuelType = "Gasoline Hybrid",
                    ProductionYear = 2020,
                    RegistrationPlate = "IS77CAR",
                    SeatsNo = 5,
                    EngineCapacity = 1598
                });

                dbContext.Cars.Add(new Car
                {
                    Id = 5,
                    Make = "VW",
                    Model = "Bora",
                    Color = "Black",
                    BodyType = "Sedan",
                    FuelType = "Gasoline",
                    ProductionYear = 2001,
                    RegistrationPlate = "SV12CAR",
                    SeatsNo = 5,
                    EngineCapacity = 1592
                });

                dbContext.SaveChanges();
            }
        }
    }
}
