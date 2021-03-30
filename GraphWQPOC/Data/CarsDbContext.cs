using GraphWQPOC.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphWQPOC.Data
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
