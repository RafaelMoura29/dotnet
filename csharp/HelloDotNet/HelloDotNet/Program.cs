using System;

namespace HelloDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the constructor that has no parameters.
            var person1 = new Person();
            Console.WriteLine(person1.Name);

            // Call the constructor that has one parameter.
            var person2 = new Person("Sarah Jones");
            person2.Name = "Rafael";
            Console.WriteLine(person2.Name);
            // Get the string representation of the person2 instance.
            Console.WriteLine(person2);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

public class Person
{
    // Constructor that takes no arguments:
    public Person()
    {
        Name = "unknown";
    }

    // Constructor that takes one argument:
    public Person(string name)
    {
        Name = name;
    }

    // Auto-implemented readonly property:
    public string Name { get; set; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Name;
    }
}