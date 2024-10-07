using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramiranjeUDotNetuOOPVjezba3
{
    internal class Profesor : Person
    {
        public Profesor(string name): base(name) { }

        public override void Introduce()
        {
            Console.WriteLine("Hello, I'm a profesor and my name is " + Name);
        }
    }
}
