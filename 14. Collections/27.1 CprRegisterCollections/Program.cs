namespace _27._1_CprRegisterCollections;

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Step 1: Create a Dictionary and populate it with Person objects (assumed already done)
        Dictionary<string, Person> personDictionary = new Dictionary<string, Person>
        {
            { "010101-0101", new Person("Alice", 30, "010101-0101") },
            { "020202-0202", new Person("Bob", 25, "020202-0202") },
            { "030303-0303", new Person("Charlie", 40, "030303-0303") },
            { "040404-0404", new Person("Diana", 35, "040404-0404") },
            { "050505-0505", new Person("Eve", 28, "050505-0505") }
        };

        // Step 2: Search for the Person with the specified CPR number
        string targetCpr = "010101-0101";
        if (personDictionary.ContainsKey(targetCpr))
        {
            // Step 3: Retrieve the person and print their details
            Person person = personDictionary[targetCpr];
            Console.WriteLine(person); // Implicitly calls ToString()
        }
        else
        {
            Console.WriteLine("Person not found.");
        }
    }
}
