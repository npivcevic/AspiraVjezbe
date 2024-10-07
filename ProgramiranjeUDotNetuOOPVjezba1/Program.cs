// See https://aka.ms/new-console-template for more information
using ProgramiranjeUDotNetuOOPVjezba1;

Console.WriteLine("Hello, World!");

PhoneBook phoneBook = new PhoneBook();

phoneBook.AddContact(new Contact("Nikola"));
phoneBook.AddContact(new Contact("Mate", "12341234 1234"));
phoneBook.AddContact(new Contact("Stipe", "4123 4 1234 21"));

phoneBook.PrintAll();

Console.ReadLine();