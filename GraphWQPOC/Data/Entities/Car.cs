using System.ComponentModel.DataAnnotations;

namespace GraphWQPOC.Data.Entities
{
    public class Car
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Make { get; set; }

        [StringLength(100)]
        public string Model { get; set; }

        [StringLength(40)]
        public string Color { get; set; }

        [Range(1850, 2050)]
        public int ProductionYear { get; set; }

        [StringLength(10)]
        public string RegistrationPlate { get; set; }

        [StringLength(20)]
        public string BodyType { get; set; }

        [Range(1,100)]
        public int SeatsNo { get; set; }

        [StringLength(30)]
        public string FuelType { get; set; }

        [Range(0,20000)]
        public int EngineCapacity { get; set; }
    }
}
