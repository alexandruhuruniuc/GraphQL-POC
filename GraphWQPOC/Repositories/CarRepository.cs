using GraphWQPOC.Data;
using GraphWQPOC.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphWQPOC.Repositories
{
    public class CarRepository
    {
        private readonly CarsDbContext _dbContext;

        public CarRepository(CarsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Car> GetAll()
        {
            return _dbContext.Cars;
        }

        public IEnumerable<Car> GetByColor(string color)
        {
            return _dbContext.Cars.Where(c => c.Color.ToLower() == color.ToLower());
        }

        public async Task<Car> AddCar(Car car)
        {
            await _dbContext.Cars.AddAsync(car);
            await _dbContext.SaveChangesAsync();

            return await Task.FromResult(car);
        }
    }
}
