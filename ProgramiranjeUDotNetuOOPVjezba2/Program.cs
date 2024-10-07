// See https://aka.ms/new-console-template for more information
using ProgramiranjeUDotNetuOOPVjezba2;

Console.WriteLine("Hello, World!");

Library library = new Library();
library.AddBook(new Book("AAA", "Author1"));
library.AddBook(new Book("BBB", "Author1"));
library.AddBook(new Book("CCC", "Author2"));

library.PrintTitles();
library.PrintUniqueAuthors();