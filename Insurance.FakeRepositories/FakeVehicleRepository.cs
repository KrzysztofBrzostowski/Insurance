using Insurance.IRepositories;
using Insurance.Models;
using Insurance.Models.SearchCriterias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.FakeRepositories
{
    public class FakeVehicleRepository : IVehicleRepository
    {
        private List<Vehicle> vehicles;

        public FakeVehicleRepository()
        {
            var customer1 = new Customer() { Id = 1, FirstName = "Jan", LastName = "Kowalski", Pesel = "12345678901" };
            var customer2 = new Customer() { Id = 2, FirstName = "Anna", LastName = "Kowalska", Pesel = "80345678900" };
            var customer3 = new Customer() { Id = 3, FirstName = "Kazimierz", LastName = "Nowak", Pesel = "90345678901" };

            vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle() { Id = 1, PlateNumber = "WUO8910", EngineCapacity = 4.98F, Owner = customer1, Color = "Red", VIN = "151418" });
            vehicles.Add(new Vehicle() { Id = 2, PlateNumber = "WN2510", EngineCapacity = 5.5F, Owner = customer2, Color = "Blue", VIN = "441810" });
            vehicles.Add(new Vehicle() { Id = 3, PlateNumber = "WX7525", EngineCapacity = 3.5F, Owner = customer3, Color = "Yellow", VIN = "482419" });
        }

        public void Add(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public List<Vehicle> Get()
        {
            return vehicles;
        }

        public List<Vehicle> GetVehicleList(VehicleSearchCriteria searchCriteria)
        {
            return vehicles.Where(veh => veh.PlateNumber == searchCriteria.PlateNumber &&
            veh.EngineCapacity == searchCriteria.EngineCapacity && veh.VIN == searchCriteria.VIN).ToList();
        }
    }
}
