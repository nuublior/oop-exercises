namespace _21._1_Kittens;
public class Kitten
{
    private double cuteness;
    private static int count = 0;

    public Kitten(double cuteness)
    {
        this.cuteness = cuteness;
        count++;
    }

    // Public static property to access count
    public static int Count
    {
        get { return count; }
    }
}