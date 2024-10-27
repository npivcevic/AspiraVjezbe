# Task

Build a console app that uses Entity Framework Core In-Memory database.

- Make a new `Console App` project
- Install `Microsoft.EntityFrameworkCore.InMemory` using `NuGet Package Manager`
- Define a class `Person` that contains the following properties: `Id`, `Name`, `Age` and `City`
- Define a class `DataContext` which inherits from `DbContext`
- Add `DbSet<Person>` property
- Override `OnConfiguring` method and setup using the InMemory database
- Create a few people objects, save them in the database, then read them from the database and print the result.

# Zadatak

Napravi konzolnu aplikaciju koja koristi Entity Framework Core In-Memory bazu podataka.
- Napravi novi projekt `Console App`
- Instaliraj `Microsoft.EntityFrameworkCore.InMemory` koristeći `NuGet Package Manager`
- Definiraj klasu `Person` koja sadrži property-e `Id`, `Name`, `Age` i `City`
- Definiraj klasu `DataContext` koja inherita `DbContext`
- Dodaj `DbSet<Person>` property
- Override-aj `OnConfiguring` metodu i odaberi korištenje InMemory baze podataka
- Kreiraj nekoliko osoba, spremi ih u InMemory bazu podataka i onda ih učitaj iz baze i ispiši 
