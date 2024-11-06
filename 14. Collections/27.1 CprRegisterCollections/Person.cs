namespace _27._1_CprRegisterCollections;

public class Person
{
    private string name;
    private int age;
    private string cpr;

    public Person(string name, int age, string cpr)
    {
        this.name = name;
        this.age = age;
        this.cpr = cpr;
    }

    public string GetName() => name;

    public int GetAge() => age;

    public string GetCpr() => cpr;

    // Override ToString method
    public override string ToString()
    {
        return $"Name: {name}, Age: {age}, CPR: {cpr}";
    }
}
