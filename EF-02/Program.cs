using EF_02;

DataContext dbContext = new DataContext();

dbContext.People.Add(
    new Person()
    {
        Name = "Mark",
        Age = 70,
        City = "London",
        Address = "Pickadily Road 45"
    }
);
dbContext.People.Add(
    new Person()
    {
        Name = "Francis",
        Age = 37,
        City = "Paris",
        Address = "Rue de Caffe 32a"
    }
);
dbContext.SaveChanges();
dbContext.People.ToList().ForEach(p => p.Print());