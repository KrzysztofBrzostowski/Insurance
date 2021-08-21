namespace Insurance.Models
{
    public class Vehicle : Base
    {
        public string PlateNumber { get; set; }
        public string VIN { get; set; }
        public float EngineCapacity { get; set; }
        public string Color { get; set; }
        public Customer Owner { get; set; }
    }
}
