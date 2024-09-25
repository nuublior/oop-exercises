using System;

class QuadraticEquation
{
    // Method to calculate the discriminant
    static double Discriminant(double a, double b, double c)
    {
        return (b * b) - (4 * a * c);
    }

    // Method to calculate the roots
    static double[] Roots(double a, double b, double c)
    {
        double disc = Discriminant(a, b, c);
        double[] roots = new double[2];

        // If discriminant is positive, there are two real roots
        if (disc > 0)
        {
            roots[0] = (-b + Math.Sqrt(disc)) / (2 * a);
            roots[1] = (-b - Math.Sqrt(disc)) / (2 * a);
        }
        // If discriminant is zero, there's one real root
        else if (disc == 0)
        {
            roots[0] = roots[1] = -b / (2 * a);
        }
        // If discriminant is negative, there are no real roots (for simplicity, we return NaN)
        else
        {
            roots[0] = roots[1] = double.NaN; // Not a Number
        }

        return roots;
    }

    // Main method to call roots and print the results
    public static void Main(string[] args)
    {
        // Coefficients for the quadratic equation
        double a = 1;
        double b = -3;
        double c = 2;

        // Call the Roots method
        double[] result = Roots(a, b, c);

        // Print the results
        Console.WriteLine("Root 1: " + result[0]);
        Console.WriteLine("Root 2: " + result[1]);
    }
}
