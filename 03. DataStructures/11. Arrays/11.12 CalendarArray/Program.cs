// Step 1: Arrays for normal year and leap year
int[] normalYear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
int[] leapYear = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

// Step 2: Loop through years from 2000 to 2020
for (int year = 2000; year <= 2020; year++) 
{
    // Step 3: Check if it's a leap year (if divisible by 4)
    bool isLeapYear = (year % 4 == 0);

    // Use pointer to choose the correct array
    int[] pointer = isLeapYear ? leapYear : normalYear;

    // Step 4: Print the number of days in each month for the current year
    Console.WriteLine("Year: " + year);
    for (int month = 0; month < 12; month++) 
    {
        Console.WriteLine("Month " + (month + 1) + " has " + pointer[month] + " days.");
    }
    Console.WriteLine(); // Just to add space between years
}
