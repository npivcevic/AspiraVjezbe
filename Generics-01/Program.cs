using Generics_01;

Cabinet<string> cabinet = new Cabinet<string>(5);

cabinet.AddItem("hammer", 1);

//cabinet.RemoveItem(1);
string? s = cabinet.RemoveItem(1);

if (s != null)
{
    Console.WriteLine(s);
} else
{
    Console.WriteLine("Shelf is empty!");
}