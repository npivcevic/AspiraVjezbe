using Exceptions_02;

BankAccount bankAccount = new BankAccount();

while (true)
{
    try
    {
        Console.Write("Select an action: d - deposit, w - withdraw, v - view balance, e - exit: ");

        string? input = Console.ReadLine();
        decimal amount;

        switch (input)
        {
            case "d":
                if (!readAmountFromInput(out amount))
                {
                    continue;
                }
                if (amount <= 0)
                {
                    Console.WriteLine("Unable to deposit a negative amount. Please try again.");
                    continue;
                }
                bankAccount.Deposit(amount);
                break;
            case "w":
                if (!readAmountFromInput(out amount))
                {
                    continue;
                }
                if (amount <= 0)
                {
                    Console.WriteLine("Unable to withdraw a negative amount. Please try again.");
                    continue;
                }
                if (amount > bankAccount.Balance)
                {
                    Console.WriteLine("Insuficient funds. Please try a different amount.");
                    continue;
                }
                bankAccount.Withdraw(amount);
                break;
            case "v":
                Console.WriteLine("Current balance: " + bankAccount.Balance);
                break;
            case "e":
                Console.WriteLine("Thank you for using the bank account system. Goodbye!");
                return;
            default:
                Console.WriteLine("Command not recognized");
                break;
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Something went wrong. Please try again.");
    }
}


static bool readAmountFromInput(out decimal amount)
{
    while (true)
    {
        Console.WriteLine("Enter amount:");
        string? stringInput = Console.ReadLine();
        if (stringInput == "abort")
        {
            amount = 0;
            return false;
        }
        bool success = decimal.TryParse(stringInput, out amount);

        if (!success)
        {
            Console.WriteLine("Inncorect format. Please try again or type 'abort' to return to previous menu.");
            continue;
        }

        return true;
    }

}