using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramiranjeUDotNetuOOPVjezba4
{
    internal class Road
    {
        private List<Vehicle> VehicleList { get; set; } = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            VehicleList.Add(vehicle);
        }

        public void Go()
        {
            foreach (Vehicle vehicle in VehicleList)
            {
                vehicle.Drive();
            }
        }
    }
}
