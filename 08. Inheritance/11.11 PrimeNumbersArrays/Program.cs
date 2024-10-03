namespace _11._11_PrimeNumbersArrays // Correct namespace with dots
{
    class Program
    {
        static void Main()
        {
            int limit = 1000000; // The upper limit for prime numbers
            bool[] isPrime = new bool[limit + 1]; // Array to track prime numbers

            // Step 1: Assume all numbers are prime initially
            for (int i = 2; i <= limit; i++)
            {
                isPrime[i] = true; // We start by assuming all numbers are prime
            }

            // Step 2: Sieve of Eratosthenes algorithm
            for (int i = 2; i * i <= limit; i++) // Loop through numbers starting at 2
            {
                if (isPrime[i]) // If i is prime
                {
                    // Mark all multiples of i as not prime
                    for (int j = i * i; j <= limit; j += i)
                    {
                        isPrime[j] = false; // Mark multiples of i as false (not prime)
                    }
                }
            }

            // Step 3: Find the largest prime
            int largestPrime = 2; // Start by assuming 2 is the largest prime
            for (int i = limit; i >= 2; i--) // Loop backwards to find the largest prime
            {
                if (isPrime[i])
                {
                    largestPrime = i; // Set the largest prime
                    break; // Stop once we've found the largest prime
                }
            }

            // Step 4: Output the largest prime
            Console.WriteLine("The largest prime number under 1,000,000 is: " + largestPrime);
        }
    }
}