namespace _21._1_Kittens;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            // Create a new Kitten object with a cuteness value based on the loop index
            Kitten kitten = new Kitten(i + 1.0);

            // Optionally, print out the current count of Kitten objects
            Console.WriteLine("Kitten created with cuteness: " + (i + 1.0));
        }

        // After the loop, you could also print out the total count if needed
        Console.WriteLine("Total number of kittens created: " + Kitten.Count);
    }
}