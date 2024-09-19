// Step 1: Create an array to store the temperatures for the week

double[] temperatures = { 21.5, 23.7, 19.6, 22.5, 25.3, 21.7, 18.9 };

// Step 2: Loop through the array to calculate differences between consecutive days

for (int i = 0; i < temperatures.Length - 1; i++) // We stop at Length - 1 to avoid out-of-bounds access

{
	
	// Step 3: Calculate the temperature difference between consecutive days
	
	double difference = temperatures[i + 1] - temperatures[i];
	
	// Step 4: Output the temperature difference for consecutive days
	
	Console.WriteLine("Temperature difference between day " + (i + 1) + " and day " + (i + 2) + " is " + difference); 
	
	
}