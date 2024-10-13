string basePath = "../../../"; //since this executes in bin/Debug/net8.0 , this matches the project folder

while (true)
{
    Console.Write("Enter a file name which you would like to read: ");
    string? input = Console.ReadLine();

    if (String.IsNullOrEmpty(input))
    {
        Console.WriteLine("Input is empty. Pleaase try again.");
        continue;
    }

    if (input == "exit")
    {
        break;
    }

    if (!File.Exists(basePath + input))
    {
        Console.WriteLine("File not found. Please try again.");
        continue;
    }

    try
    {
        string fileContent = File.ReadAllText(basePath + input);
        Console.WriteLine("File read. Content: \n" + fileContent);
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("(EXCEPTION) File not found. Please try again.");
    }
    catch (Exception)
    {
        Console.WriteLine("Something went wrong. Please try again.");
    }
}
