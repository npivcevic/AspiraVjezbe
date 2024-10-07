using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramiranjeUDotNetuOOPVjezba4
{
    internal class Vehicle
    {

        public string Brand { get; set; }

        public int Speed { get; set; }

        public Vehicle (string name, int speed)
        {
            Brand = name;
            Speed = speed;
        }

        public virtual void Drive()
        {
            Console.WriteLine($"Vehicle {Brand} is driving at the speed {Speed}.");
        }
    }
}
