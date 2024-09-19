// Step 1: Define the struct
struct Person
{
    public string Name;  // Field for the name of the person
    public int Age;      // Field for the age of the person
}

class Program
{
    static void Main()
    {
        // Step 2: Create an instance of the struct and assign values
        Person person1;
        person1.Name = "Alice";  // Assign a name
        person1.Age = 25;        // Assign an age

        // Step 3: Output the values
        Console.WriteLine("Name: " + person1.Name);
        Console.WriteLine("Age: " + person1.Age);
    }
}
