# Task

Build a console app that uses Entity Framework Core SQLite database.

- Make a new `Console App` project
- Using `NuGet Package Manager` install:
	- `Microsoft.EntityFrameworkCore.Sqlite` 
	- `Microsoft.EntityFrameworkCore.Tools`
	- `Microsoft.EntityFrameworkCore.Design`
- Define a class `Person` that contains the following properties: `Id`, `Name`, `Age` and `City`
- Define a class `DataContext` which inherits from `DbContext`
- Add `DbSet<Person>` property
- Override `OnConfiguring` method and setup using the Sqlite database
- Open the `Package Manager Console`, create the initial migration using `Add-Migration` and run the migration using `Update-Database`
- Create a few people objects, save them in the database, then read them from the database and print the result.
- Stop the application and run again to make sure the data persist
- In the class `Person` add a new property `Address`
- Create a new migration `AddAddressToPerson`, run the migration, check the app still works and can correctly handle Addresses.

# Zadatak

Napravi konzolnu aplikaciju koja koristi Entity Framework Core SQLite bazu podataka.
- Napravi novi projekt `Console App`
- Koristeći `NuGet Package Manager` instaliraj:
	- `Microsoft.EntityFrameworkCore.Sqlite` 
	- `Microsoft.EntityFrameworkCore.Tools`
	- `Microsoft.EntityFrameworkCore.Design`
- Definiraj klasu `Person` koja sadrži property-e `Id`, `Name`, `Age` i `City`
- Definiraj klasu `DataContext` koja inherita `DbContext`
- Dodaj `DbSet<Person>` property
- Override-aj `OnConfiguring` metodu i odaberi korištenje SQLite baze podataka
- Otvori `Package Manager Console`, kreiraj inicijalnu migraciju koristeći `Add-Migration` i pokreni migraciju koristeći `Update-Database` 
- U datoteci `program.cs` inicijaliziraj `DataContext`, napravi nekoliko osoba, spremi u bazu podataka. Učitaj sve osobe iz baze podataka i ispiši.
- Zaustavi aplikaciju i ponovno je pokreni kako bi se uvjerili da su podaci sada spremljeni i nakon gašenja aplikacije.
- U klasi `Person `nadodaj novi string property `Address`
- Kreiraj novu migraciju `AddAddressToPerson`, pokreni migraciju, provjeri ispravnost aplikacije i unosa / ispisa novog polja

