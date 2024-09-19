// Defining the enum
enum Direction
{
    North,
    South,
    East,
    West
}

// Using the enum in a simple way
class Program
{
    static void Main()
    {
        // Create a variable of type Direction and assign it a value
        Direction myDirection = Direction.North;

        // Output the value of myDirection
        Console.WriteLine("The direction is: " + myDirection);
    }
}
