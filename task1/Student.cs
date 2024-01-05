using System.Security.Cryptography;
using task1;

namespace task1;

public class Student : Person
{
     public void Study()
    {
        Console.WriteLine("I'm studying");
    }

    public void ShowAge()
    {
        Console.WriteLine("My age is: " + Age + " years old");
    }
}
