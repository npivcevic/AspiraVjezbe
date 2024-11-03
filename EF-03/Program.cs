using EF_03;

DataContext dbContext = new DataContext();

PersonRepository personRepository = new PersonRepository(dbContext);

await personRepository.Create(new Person() { Name = "Jack", Age = 20, City = "Paris" });
await personRepository.Create(new Person() { Name = "Anna", Age = 30, City = "London" });
await personRepository.Create(new Person() { Name = "Mark", Age = 50, City = "Milan" });

(await personRepository.GetAll()).ForEach(x => x.Print());

await personRepository.Delete(1);

(await personRepository.GetAll()).ForEach(x => x.Print());

await personRepository.Update(new Person() { Id = 2, Name = "Anna", Age = 30, City = "Berlin" });

(await personRepository.GetAll()).ForEach(x => x.Print());
