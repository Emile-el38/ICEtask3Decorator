using System;
namespace prjDecorator;
class Program
{

    static void Main()
    {
       // Step 1 — start with a plain person
        Human person = new BasicPerson();

        // Step 2 — wrap in a Sweater
        person = new Sweater(person);

        // Step 3 — wrap that in a Raincoat
        person = new Raincoat(person);

        // Step 4 — read the final state
        Console.WriteLine($"Description : {person.GetDescription()}");
        Console.WriteLine($"Warmth      : {person.GetWarmth()}");  

    }
}