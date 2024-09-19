int monthNumber = 12; // This is the number of the month. You can change it to test different months.
int daysInMonth;

// Check which month it is and set the number of days
if (monthNumber == 1) {
    daysInMonth = 31; // January
} else if (monthNumber == 2) {
    daysInMonth = 28; // February (non-leap year)
} else if (monthNumber == 3) {
    daysInMonth = 31; // March
} else if (monthNumber == 4) {
    daysInMonth = 30; // April
} else if (monthNumber == 5) {
    daysInMonth = 31; // May
} else if (monthNumber == 6) {
    daysInMonth = 30; // June
} else if (monthNumber == 7) {
    daysInMonth = 31; // July
} else if (monthNumber == 8) {
    daysInMonth = 31; // August
} else if (monthNumber == 9) {
    daysInMonth = 30; // September
} else if (monthNumber == 10) {
    daysInMonth = 31; // October
} else if (monthNumber == 11) {
    daysInMonth = 30; // November
} else if (monthNumber == 12) {
    daysInMonth = 31; // December
} else {
    Console.WriteLine("Invalid month number!"); // Just in case you put in a number that's not a month
    daysInMonth = 0; // We set this to 0 if there's an invalid month
}

// Print out the result
Console.WriteLine("The month has " + daysInMonth + " days.");
