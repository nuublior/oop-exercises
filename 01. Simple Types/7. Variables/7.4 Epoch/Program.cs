// Store the Unix Epoch (January 1, 1970) as a DateTime object
DateTime unixEpoch = new DateTime(1970, 1, 1);

// Get the current date and time
DateTime currentTime = DateTime.Now;

// Calculate the difference in seconds between the current time and the Unix Epoch
TimeSpan timeSinceEpoch = currentTime - unixEpoch;

// Calculate the total seconds
double totalSeconds = timeSinceEpoch.TotalSeconds;

// Calculate the number of years since the epoch (365 days assumed in a year)
int years = (int)(totalSeconds / (365 * 24 * 60 * 60));

// Calculate the remaining days after counting full years
int remainingDays = (int)((totalSeconds % (365 * 24 * 60 * 60)) / (24 * 60 * 60));

// Output the total seconds, years, and remaining days
Console.WriteLine("Seconds since 1 January 1970: " + totalSeconds);
Console.WriteLine("Years since 1 January 1970: " + years);
Console.WriteLine("Days within the current year: " + remainingDays);


