using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramiranjeUDotNetuOOPVjezba3
{
    internal class ClassRoom
    {
        private List<Person> people { get; set; } = new List<Person>();

        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public void Intoduction()
        {
            foreach (Person person in people)
            {
                person.Introduce();
            }
        }
    }
}
