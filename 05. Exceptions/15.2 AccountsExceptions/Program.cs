int[] accounts = { 903, 716, 67 };
int GetAccountNumber()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Enter an account number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
    }
}

void PrintAccountState(int accountId)
{
Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}
while (true)
{
    try
    {
        int accountId = GetAccountNumber();
        PrintAccountState(accountId);
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Error: Invalid account number. Please try again.");
    }
}
