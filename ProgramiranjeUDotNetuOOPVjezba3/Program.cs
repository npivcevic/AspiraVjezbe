// See https://aka.ms/new-console-template for more information
using ProgramiranjeUDotNetuOOPVjezba3;

Console.WriteLine("Hello, World!");

ClassRoom classRoom = new ClassRoom();
classRoom.AddPerson(new Student("Mate"));
classRoom.AddPerson(new Student("Stipe"));
classRoom.AddPerson(new Profesor("Nikola"));

classRoom.Intoduction();


