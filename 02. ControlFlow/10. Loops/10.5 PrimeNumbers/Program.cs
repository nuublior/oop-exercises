// Loop through numbers from 2 to 1,000,000
int largestPrime = 2; // Start by assuming the smallest prime is 2

for (int num = 2; num < 1000000; num++)
{
    bool is_prime = true;

    // Check if num is divisible by any number from 2 to sqrt(num)
    for (int i = 2; i * i <= num; i++)
    {
        if (num % i == 0)
        {
            is_prime = false;
            break; // If divisible, it's not a prime, so exit the loop
        }
    }

    // If it is prime, store it as the largest prime
    if (is_prime)
    {
        largestPrime = num;
    }
}

// Output the largest prime found
Console.WriteLine("The largest prime number under 1,000,000 is: " + largestPrime);
