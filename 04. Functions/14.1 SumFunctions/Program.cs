// Step 1: Create the Sum method that takes two integers as input and returns their sum
int Sum(int a, int b)
{
    return a + b;
}

// Step 2: Create the main method to demonstrate how to use the Sum method
// This part will be used to call the Sum method and print the result
Console.WriteLine("Enter first number: ");
int num1 = int.Parse(Console.ReadLine()); // Getting first input from the user

Console.WriteLine("Enter second number: ");
int num2 = int.Parse(Console.ReadLine()); // Getting second input from the user

int result = Sum(num1, num2); // Call the Sum method with the two inputs
Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + result); // Display the result
