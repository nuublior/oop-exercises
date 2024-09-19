// Step 1: Function to calculate the area of a circle
double CalculateArea(double radius)
{
    double pi = 3.14;
    return pi * radius * radius; // Formula for area: π * r²
}

// Step 2: Function to calculate the circumference of a circle
double CalculateCircumference(double radius)
{
    double pi = 3.14;
    return 2 * pi * radius; // Formula for circumference: 2 * π * r
}

// Step 3: Main part - Loop through the radii, calculate and print the results
double[] radii = { 1, 3, 5 }; // Array of radii

foreach (double radius in radii)
{
    // Calculate area and circumference for each radius
    double area = CalculateArea(radius);
    double circumference = CalculateCircumference(radius);

    // Output the results
    Console.WriteLine("For a circle with radius " + radius + ":");
    Console.WriteLine(" - Area = " + area);
    Console.WriteLine(" - Circumference = " + circumference);
    Console.WriteLine(); // Blank line for better readability
}
