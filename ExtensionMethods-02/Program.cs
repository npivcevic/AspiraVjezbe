// See https://aka.ms/new-console-template for more information

using ExtensionMethods_02;

Product p = new Product() { Name = "Candy", Price=20};
Console.WriteLine($"Product: {p.Name}, Price: {p.Price}");
p.ApplyDiscount(10);
Console.WriteLine($"Product: {p.Name}, Price: {p.Price}");
