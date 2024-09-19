// Step 1: Define a recursive method to calculate the factorial
int Factorial(int n)
{
    // Base case: if the number is 0 or 1, return 1
    if (n == 0 || n == 1)
    {
        return 1;
    }

    // Recursive case: multiply the number by the factorial of the number minus one
    return n * Factorial(n - 1);
}

// Step 2: Main method to call the Factorial method and display the result
int number = 4; // Example: calculate factorial of 4
int result = Factorial(number); // Call the recursive method

// Step 3: Output the result
Console.WriteLine("The factorial of " + number + " is " + result);
