// Input the month number
int month = 12;  // Test with any month, for example 4 for April, 10 for October

// Check the month and print the corresponding holiday or "Hårdt arbejde"
if (month == 10)
{
    Console.WriteLine("Efterårsferie");  // October holiday
}
else if (month == 12)
{
    Console.WriteLine("Juleferie");  // December holiday (Christmas)
}
else if (month == 4)
{
    Console.WriteLine("Påskeferie");  // April holiday (Easter)
}
else if (month == 7 || month == 8)
{
    Console.WriteLine("Sommerferie");  // Summer holidays in July and August
}
else
{
    Console.WriteLine("Hårdt arbejde");  // For months without holidays
}
