using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramiranjeUDotNetuOOPVjezba4
{
    internal class Car: Vehicle
    {
        public int FuelLevel { get; set; } = 2;

        public Car(string brand) : base(brand, 10) { }

        public override void Drive()
        {
            if (FuelLevel <= 0)
            {
                Console.WriteLine($"Car {Brand} is out of fuel.");
                return;
            }

            FuelLevel--;
            base.Drive();
        }

        public void Refuel()
        {
            FuelLevel = 2;
        }
    }
}
