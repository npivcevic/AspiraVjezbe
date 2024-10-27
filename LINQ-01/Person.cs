using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_01
{
    internal class Person
    {
        public string Name { get; set; } = "";

        public int Age { get; set; }

        public string City { get; set; } = "";

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, City: {City}");
        }
    }
}
