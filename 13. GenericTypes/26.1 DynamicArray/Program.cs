namespace _26._1_DynamicArray;

using System;

public class Program
{
    public static void Main()
    {
        IDynArray<int> a = new DynArray<int>();

        Console.WriteLine("Add elements:");
        for (int i = 0; i < 20; i++)
        {
            a.Append(i);
            Console.WriteLine(a);
        }

        Random random = new Random();
        Console.WriteLine("Remove elements:");
        for (int i = 19; i >= 0; i--)
        {
            a.Remove(random.Next(a.GetFill()));
            Console.WriteLine(a);
        }
    }
}