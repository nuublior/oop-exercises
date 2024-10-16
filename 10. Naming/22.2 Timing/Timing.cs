namespace _22._2_Timing;

public class Timing
{
    public static double Fun(double x, double y)
    {
        if (y <= 1)
        {
            return x;
        }
        else
        {
            double result = Fun(x, y - 1) * Fun(x, y - 1);  // Ensure each recursion is controlled
            return result;
        }
    }

}