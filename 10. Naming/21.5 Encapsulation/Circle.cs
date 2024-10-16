namespace _21._5_Encapsulation
{
    public class Circle
    {
        private Coordinate center; // Using Coordinate to represent (x, y)
        private double diameter; // Diameter

        public Circle(double x, double y, double radius)
        {
            this.center = new Coordinate(x, y); // Initialize Coordinate with x and y
            this.diameter = radius * 2; // Set diameter as twice the radius
        }

        public Coordinate Center // Property to access the Coordinate object
        {
            get { return center; }
        }

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
    }
}