
using Delegates_01;

List<Person> people = new List<Person>
{
    new Person() { Name = "John", Age = 18 },
    new Person() { Name = "Frank", Age = 38 },
    new Person() { Name = "Anna", Age = 50 },
    new Person() { Name = "Felicia", Age = 22 },
    new Person() { Name = "Mike", Age = 90 },
    new Person() { Name = "Karen", Age = 54 },
};

List<Person> olderThen30 = people.Where(p => p.Age >= 30).ToList();
List<string> names = olderThen30.Select(p => p.Name).ToList();

Console.WriteLine("People over 30:");
names.ForEach(name => Console.WriteLine(name));