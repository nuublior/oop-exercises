// Step 1: Define an array with the radii of the circles
int[] radiuses = { 1, 3, 5 }; 

// Step 2: Define the value of pi
double pi = 3.14; 

// Step 3: Use a foreach loop to go through each radius in the radiuses array
foreach (int r in radiuses) 
{
    // Step 4: For each radius, calculate the area using the formula pi * r * r
    // Step 5: Output the radius and the calculated area in a readable format
    Console.WriteLine("r=" + r + " -> area=" + (pi * r * r)); 
}
