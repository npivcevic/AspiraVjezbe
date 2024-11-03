# Task

Build a console app that uses Entity Framework Core SQL Server database.

- Make a new `Console App` project
- Using `NuGet Package Manager` install:
	- `Microsoft.EntityFrameworkCore.SqlServer` 
	- `Microsoft.EntityFrameworkCore.Tools`
	- `Microsoft.EntityFrameworkCore.Design`
- Define a class `Person` that contains the following properties: `Id`, `Name`, `Age` and `City`
- Define a class `DataContext` which inherits from `DbContext`
- Add `DbSet<Person>` property
- Override `OnConfiguring` method and setup using the SqlServer database
- Open the `Package Manager Console`, create the initial migration using `Add-Migration` and run the migration using `Update-Database`
- Create the class `PersonRepository` which contains the following methods:
	- `Get(int Id)` -> retrives one person from the db using the suplied ID
	- `GetAll()` -> retrieves all people from the database
	- `Create(Person person)` -> saves the supplied person to the database
	- `Delete(int Id)` -> deletes the person with that matching ID
	- `Update(Person person)` -> updates the supplied person in the database
- Call all of the above functions from `program.cs`
- Make sure to use async calls!

# Zadatak

Napravi konzolnu aplikaciju koja koristi Entity Framework Core SQL Server bazu podataka.
- Napravi novi projekt `Console App`
- Koristeći `NuGet Package Manager` instaliraj:
	- `Microsoft.EntityFrameworkCore.SqlServer` 
	- `Microsoft.EntityFrameworkCore.Tools`
	- `Microsoft.EntityFrameworkCore.Design`
- Definiraj klasu `Person` koja sadrži property-e `Id`, `Name`, `Age` i `City`
- Definiraj klasu `DataContext` koja inherita `DbContext`
- Dodaj `DbSet<Person>` property
- Override-aj `OnConfiguring` metodu i odaberi korištenje Sql Server baze podataka
- Otvori `Package Manager Console`, kreiraj inicijalnu migraciju koristeći `Add-Migration` i pokreni migraciju koristeći `Update-Database` 
- Napravi klasu `PersonRepository` koja sadrži sljedeće metode:
	- `Get(int Id)` -> dohvaća jednu osobu po id-u
	- `GetAll()` -> dohvaća sve osobe iz baze podataka
	- `Create(Person person)` -> sprema novu osobu u bazu podataka
	- `Delete(int Id)` -> briše osobu iz baze podataka
	- `Update(Person person)` -> ažuirira osobu u bazi podataka
- Pozovi sve navedene metode u `program.cs`
- Obavezno koristi Async pozive!

