
using LINQ_01;

List<Person> people = new List<Person>()
    {
        new Person() { Name = "John", Age = 20, City = "London" },
        new Person() { Name = "Anna", Age = 24, City = "London" },
        new Person() { Name = "Felicia", Age = 40, City = "London" },
        new Person() { Name = "Mark", Age = 55, City = "Paris" },
        new Person() { Name = "Josh", Age = 14, City = "Paris" },
        new Person() { Name = "Malcolm", Age = 67, City = "Berlin" },
        new Person() { Name = "Wendy", Age = 32, City = "Berlin" },
        new Person() { Name = "Laura", Age = 39, City = "Madrid" },
        new Person() { Name = "Mary", Age = 18, City = "Lisbon" },
    };


// Print 3 oldest persons
Console.WriteLine("3 oldest people:");
people
    .OrderByDescending(p => p.Age)
    .Take(3)
    .ToList()
    .ForEach(p => p.Print());


// print page 2 of the people list (2 per page) younger than 50
Console.WriteLine("Page 2 of people list younger than 50:");
int page = 2;
int pageSize = 2;
people
    .Where(p => p.Age < 50)
    .Skip((page-1) * pageSize)
    .Take(pageSize)
    .ToList()
    .ForEach (p => p.Print());

// get the average age of people in London
Console.WriteLine("Average age of people in London:");
Console.WriteLine(
    people
        .Where(p => p.City == "London")
        .Average(p => p.Age)
);


// Check if there is at least one person from Paris
Console.WriteLine("At least one person from Paris?");
Console.WriteLine(
    people
        .Where(p => p.City == "Paris")
        .Any()
);

// Number of people in each city
Console.WriteLine("Number of people in each city:");
people
    .GroupBy(p => p.City)
    .Select(group =>
    new
        {
            City = group.Key,
            Count = group.Count()
        }
    )
    .ToList()
    .ForEach(group =>
        Console.WriteLine(
            $"City: {group.City}, Count: {group.Count}")
        );
