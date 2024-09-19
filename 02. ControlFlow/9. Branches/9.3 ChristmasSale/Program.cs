int secondsSinceNewYear = 21816000;
double price = 599.95;

// Convert seconds to days
int daysSinceNewYear = secondsSinceNewYear / (24 * 60 * 60);

// Define if it's Christmas (between Dec 24 and Dec 30)
bool isChristmas = (daysSinceNewYear >= 354 && daysSinceNewYear <= 360);

// Calculate the final price
double finalPrice = price;

if (isChristmas)
{
    finalPrice = price * 0.70; // Apply 30% discount
}

// Output the final price
Console.WriteLine("The final price is: " + finalPrice);
