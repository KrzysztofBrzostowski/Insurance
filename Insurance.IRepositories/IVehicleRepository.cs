using Insurance.Models;
using Insurance.Models.SearchCriterias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.IRepositories
{
    public interface IVehicleRepository
    {
        List<Vehicle> Get();

        List<Vehicle> GetVehicleList(VehicleSearchCriteria searchCriteria);

        void Add(Vehicle vehicle);
    }
}
