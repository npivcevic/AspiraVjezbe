using EF_01;

DataContext dbContext = new DataContext();

dbContext.People.Add(
    new Person() {
        Name = "Jack",
        Age = 20,
        City = "London" }
);
dbContext.People.Add(
    new Person()
    {
        Name = "Anna",
        Age = 30,
        City = "Paris"
    }
);
dbContext.SaveChanges();
dbContext.People.ToList().ForEach(p => p.Print());