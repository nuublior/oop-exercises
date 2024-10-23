namespace _14._7_DiscriminantsRootsMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Example values for a, b, and c
            double a = 1;
            double b = -3;
            double c = 2;

            // Call the Discriminant method
            double result = Discriminant(a, b, c);
            Console.WriteLine($"The discriminant for a={a}, b={b}, c={c} is: {result}");

            // Call the Roots method and display the roots
            double[] roots = Roots(a, b, c);
            Console.WriteLine("\nThe roots are: ");
            foreach (double root in roots)
            {
                Console.WriteLine(root);
            }
        }
        
        // Discriminant method
        public static double Discriminant(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }

        // Roots method
        public static double[] Roots(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            double sqrtDiscriminant = Math.Sqrt(discriminant);

            double root1 = (-b + sqrtDiscriminant) / (2 * a);
            double root2 = (-b - sqrtDiscriminant) / (2 * a);

            return new double[] { root1, root2 };
        }
    }
}