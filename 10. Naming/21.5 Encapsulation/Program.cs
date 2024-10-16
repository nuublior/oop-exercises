namespace _21._5_Encapsulation
{
    class TestCircle
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1.24, 2.83, 12.7);
            Console.WriteLine("x=" + c.Center.X + " y=" + c.Center.Y + " d=" + c.Diameter);

            // Modify properties through getters and setters
            c.Diameter *= 1.37; // Modify diameter
            c.Center.X += 0.65; // Modify x-coordinate using Coordinate property
            Console.WriteLine("x=" + c.Center.X + " y=" + c.Center.Y + " d=" + c.Diameter);
        }
    }
}