using System;

public class Pin
{
    const int CRITICAL_AMOUNT = 350;
    const int MAX_TRANSACTIONS = 4;
    private int time2pin = MAX_TRANSACTIONS;
    private Random random = new Random();

    bool Expend(int amount)
    {
        // Introduce 20% chance of requiring a PIN
        bool randomPinRequest = random.Next(1, 101) <= 20;

        if (time2pin == 0 || amount > CRITICAL_AMOUNT || randomPinRequest)
        {
            time2pin = MAX_TRANSACTIONS;
            return true;
        }
        return --time2pin == 0;
    }

    public static void Main(string[] args)
    {
        Pin pin = new Pin();

        // Simulate 100 transactions to check the 20% probability behavior
        int pinRequestCount = 0;
        for (int i = 0; i < 100; i++)
        {
            bool give_pin = pin.Expend(42);
            if (give_pin)
            {
                pinRequestCount++;
            }
            Console.WriteLine(i + ": 42 -> " + give_pin);
        }
        Console.WriteLine($"\nTotal PIN requests: {pinRequestCount} (Expected ~20%)");
    }
}