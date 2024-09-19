// Step 1: Define a method to calculate the square root manually up to 7 decimal places
double sqrt(double number)
{
    double guess = 0;
    double increment = 1; // This is the "step" we use to try different digits

    // Step 2: Iterate through each of the 7 decimal places
    for (int decimalPlace = 0; decimalPlace < 7; decimalPlace++)
    {
        // Step 3: Try each digit (from 0.0000001 to 10000000)
        while ((guess + increment) * (guess + increment) <= number)
        {
            guess += increment;
        }

        // Step 4: Refine guess by reducing the increment for the next decimal place
        increment /= 10;
    }

    return guess;
}

// Step 5: Main method to demonstrate usage
double number = 27; // Try to calculate sqrt of 25, which should be 5
double result = sqrt(number);
Console.WriteLine("The square root of " + number + " is " + result);
