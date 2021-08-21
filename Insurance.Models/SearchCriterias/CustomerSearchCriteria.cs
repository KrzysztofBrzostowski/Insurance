using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Models.SearchCriterias
{
    public class CustomerSearchCriteria
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
    }

    public class VehicleSearchCriteria
    {
        public string PlateNumber { get; set; }
        public string VIN { get; set; }
        public float EngineCapacity { get; set; }
    }
}
