// Start with -5°C and end at 40°C, increasing by 0.5°C each time
for (double celsius = -5.0; celsius <= 40.0; celsius += 0.5)
{
    // Convert Celsius to Fahrenheit using the formula
    double fahrenheit = 32 + (9.0 / 5.0) * celsius;
    
    // Print the Celsius and Fahrenheit values in a table format
    Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
}
