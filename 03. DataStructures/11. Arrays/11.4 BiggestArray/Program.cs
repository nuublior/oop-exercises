int[] numbers = { 23, 45, 12, 89, 67, 34, 91, 50 };  // This is our array with numbers

int maxNumber = numbers[0];  // Start by assuming the first number is the biggest
int maxIndex = 0;  // The index of the first number is 0

// Now, let's look at all the numbers in the array
for (int i = 1; i < numbers.Length; i++)
{
    // If the current number is bigger than our maxNumber, update it
    if (numbers[i] > maxNumber)
    {
        maxNumber = numbers[i];  // Update the biggest number
        maxIndex = i;  // Update the index where we found the biggest number
    }
}

// Output the result
Console.WriteLine("The biggest number is: " + maxNumber);
Console.WriteLine("The index of the biggest number is: " + maxIndex);
