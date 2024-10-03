double celsius = -5.0;  // Start at -5°C
do
{
    // Convert Celsius to Fahrenheit using the formula
    double fahrenheit = 32 + (9.0 / 5.0) * celsius;

    // Print the Celsius and Fahrenheit values
    Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

    // Increment Celsius by 0.5
    celsius += 0.5;
}
while (celsius <= 40.0);  // Continue until we reach 40°C
