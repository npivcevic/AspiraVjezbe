// See https://aka.ms/new-console-template for more information
using ProgramiranjeUDotNetuOOPVjezba4;

Console.WriteLine("Hello, World!");

Road road = new Road();
Car bmw = new Car("BMW");

road.AddVehicle(new Car("Porsche"));
road.AddVehicle(new Car("Audi"));
road.AddVehicle(bmw);
road.AddVehicle(new Bicycle("BMX"));

road.Go();
road.Go();
road.Go();
bmw.Refuel();
road.Go();
